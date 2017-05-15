using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATMData
    {
        public enum BILL_TYPE
        {
            TYPE_10 = 10,
            TYPE_50 = 50,
            TYPE_100 = 100,
            TYPE_500 = 500
        };

        class BillHolder
        {
            public BillHolder(int nominal, int startAmount, int maxAmount)
            {
                mNominal = nominal;
                mAmount = startAmount;
                mMaxAmount = maxAmount;
            }


            public bool tryAddAmount(int amount)
            {
                int sum = mAmount + amount;
                if (sum <= mMaxAmount)
                {
                    mAmount = sum;
                    return true;
                }
                return false;
            }

            public int getEmptyAmount()
            {
                return mMaxAmount - mAmount;
            }

            public int getAmount()
            {
                return mAmount;
            }

            public bool tryDecrAmount(int amount)
            {
                if (amount <= mAmount)
                {
                    mAmount -= amount;
                    return true;
                }
                return false;
            }

            public int getMoneySum()
            {
                return mAmount * mNominal;
            }

            public int getNominal()
            {
                return mNominal;
            }

            public int getMaxAmount()
            {
                return mMaxAmount;
            }

            int mAmount;
            int mNominal;
            int mMaxAmount;
        };

        //========================================================
        public ATMData()
        {
            mMoneyStore.Add(BILL_TYPE.TYPE_10, new BillHolder((int)BILL_TYPE.TYPE_10, ATMConstants.kBillStartAmount10, ATMConstants.kBillMaxAmount10));
            mMoneyStore.Add(BILL_TYPE.TYPE_50, new BillHolder((int)BILL_TYPE.TYPE_50, ATMConstants.kBillStartAmount50, ATMConstants.kBillMaxAmount50));
            mMoneyStore.Add(BILL_TYPE.TYPE_100, new BillHolder((int)BILL_TYPE.TYPE_100, ATMConstants.kBillStartAmount100, ATMConstants.kBillMaxAmount100));
            mMoneyStore.Add(BILL_TYPE.TYPE_500, new BillHolder((int)BILL_TYPE.TYPE_500, ATMConstants.kBillStartAmount500, ATMConstants.kBillMaxAmount500));

            mBillOrder.AddLast(BILL_TYPE.TYPE_10);
            mBillOrder.AddLast(BILL_TYPE.TYPE_50);
            mBillOrder.AddLast(BILL_TYPE.TYPE_100);
            mBillOrder.AddLast(BILL_TYPE.TYPE_500);
        }
        public delegate void OnMoneyStoreChanged();
        public event OnMoneyStoreChanged MoneyChangedEvent; 
        SortedDictionary<BILL_TYPE, BillHolder> mMoneyStore = new SortedDictionary<BILL_TYPE, BillHolder>();

        LinkedList<BILL_TYPE> mBillOrder = new LinkedList<BILL_TYPE>();

        public bool tryToGiveAwayMoney(int requesteSum, BILL_TYPE preferedType, ref string outMessage, out Dictionary<BILL_TYPE, int> outputSum)
        {
            outputSum = new Dictionary<BILL_TYPE, int> {
                {BILL_TYPE.TYPE_10, 0},
                {BILL_TYPE.TYPE_50, 0},
                {BILL_TYPE.TYPE_100, 0 },
                {BILL_TYPE.TYPE_500, 0 }
            };
            if(requesteSum == 0)
            {
                outMessage = "Requested sum is zero";
                return false;
            }
            if(requesteSum> getMoneySum())
            {
                outMessage = "Requested sum is not available";
                return false;
            }

            int sumNeeded = requesteSum;
            int resid = requesteSum;

            int prefBillsReserve = 0;
            var orderIter = mBillOrder.Find(preferedType);
            var nextIter = orderIter.Next;
            int prefBillsProxy = 0;
            if(nextIter != null)
            {
                prefBillsReserve = ((int)nextIter.Value / (int)preferedType) - 1;
                if(mMoneyStore[preferedType].getAmount()>prefBillsReserve)
                {
                    prefBillsProxy = mMoneyStore[preferedType].getAmount() - prefBillsReserve;

                }
            }

            foreach (var curPair in mMoneyStore.Reverse())
            {
                
            
                if (sumNeeded < mMoneyStore[curPair.Key].getNominal())
                {
                    continue;
                }
                else
                {
                    //try to use prefered
                    

                    if ((int)preferedType <= sumNeeded && prefBillsProxy > 0)
                    {
                        int prefAmountInCurBill = (int)curPair.Key / (int)preferedType;

                        if (nextIter != null && nextIter.Value == curPair.Key)
                        {
                            prefBillsProxy += prefBillsReserve;
                        }

                        int replaceAmount = prefBillsProxy / prefAmountInCurBill;
                        if (replaceAmount > 0)
                        {
                            int amountNeeded = sumNeeded / (int)curPair.Key;
                            int prefBillSpended = 0;
                            if(replaceAmount > amountNeeded)
                            {
                                prefBillSpended = amountNeeded * prefAmountInCurBill;
                            }
                            else
                            {
                                prefBillSpended = replaceAmount * prefAmountInCurBill;
                            }
                            prefBillsProxy -= prefBillSpended;
                            outputSum[preferedType] += prefBillSpended;
                            sumNeeded -= prefBillSpended * (int)preferedType;
                            if(sumNeeded == 0)
                            {
                                break;
                            }
                            if (sumNeeded < mMoneyStore[curPair.Key].getNominal())
                            {
                                continue;
                            }
                        }

                    }

                    int curBillNeeded = sumNeeded / mMoneyStore[curPair.Key].getNominal();
                    int billSpended = 0;
                    if(curBillNeeded > mMoneyStore[curPair.Key].getAmount())
                    {
                        billSpended = mMoneyStore[curPair.Key].getAmount();
                    }
                    else
                    {
                        billSpended = curBillNeeded;
                    }
                    outputSum[curPair.Key] += billSpended;
                    sumNeeded -= billSpended * mMoneyStore[curPair.Key].getNominal();
                    if(sumNeeded == 0)
                    {
                        break;
                    }
                }
            }
            
            
            if (sumNeeded == 0)
            {
                foreach (var curPair in outputSum)
                {
                    mMoneyStore[curPair.Key].tryDecrAmount(curPair.Value);
                }
                
            }
            else
            {
                outputSum.Clear();
                outMessage = "Could not return such sum";
                return false;
            }

            outMessage = "Take your money";

            if (MoneyChangedEvent != null)
            {
                MoneyChangedEvent();
            }

            return true;
        } 

        public bool tryToInsertMoney(int sum, Dictionary<BILL_TYPE, int> money, ref string outMessage)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(var curKey in money.Keys.ToList())
            {
                int billCouldBeAdded = mMoneyStore[curKey].getEmptyAmount();
                if(billCouldBeAdded>= money[curKey])
                {
                    mMoneyStore[curKey].tryAddAmount(money[curKey]);
                    money[curKey] = 0;                    
                }
                else
                {
                    //int billWouldBeAdded = money[curKey] - billCouldBeAdded;
                    mMoneyStore[curKey].tryAddAmount(billCouldBeAdded);
                    money[curKey] -= billCouldBeAdded;

                    sb.Append("Money holder for bill type: ");
                    sb.Append(curKey.ToString());
                    sb.Append(" is full, some bills returned");
                    sb.Append("\n");

                }
            }
            if (MoneyChangedEvent != null)
            {
                MoneyChangedEvent();
            }
            outMessage = sb.ToString();
            return true;
        }

        public int getMoneySum()
        {
            int sum = 0;

            foreach(var curPair in mMoneyStore)
            {
                sum += curPair.Value.getMoneySum();
            }

            return sum;
        }

        public int getNominalAmount(BILL_TYPE billType)
        {
            return mMoneyStore[billType].getAmount();
        }

        public int getMaxAmount(BILL_TYPE billType)
        {
            return mMoneyStore[billType].getMaxAmount();
        }
    }
}
