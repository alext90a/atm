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
        }
        public delegate void OnMoneyStoreChanged();
        public event OnMoneyStoreChanged MoneyChangedEvent; 
        SortedDictionary<BILL_TYPE, BillHolder> mMoneyStore = new SortedDictionary<BILL_TYPE, BillHolder>();

        public bool tryToGiveAwayMoney(int sum, BILL_TYPE preferedType, ref string outMessage, out Dictionary<BILL_TYPE, int> outputSum)
        {
            outputSum = new Dictionary<BILL_TYPE, int> {
                {BILL_TYPE.TYPE_10, 0},
                {BILL_TYPE.TYPE_50, 0},
                {BILL_TYPE.TYPE_100, 0 },
                {BILL_TYPE.TYPE_500, 0 }
            };
            if(sum == 0)
            {
                outMessage = "Requested sum is zero";
                return false;
            }
            if(sum> getMoneySum())
            {
                outMessage = "Requested sum is not available";
                return false;
            }

            int sumNeeded = sum;
            foreach(var curKey in mMoneyStore.Reverse())
            {
                if(sumNeeded >= mMoneyStore[preferedType].getNominal())
                {
                    int prefBillAvailable = mMoneyStore[preferedType].getAmount() - outputSum[preferedType];
                    int sumAvailaleByPrefBill = mMoneyStore[preferedType].getNominal() * prefBillAvailable;
                    if(sumNeeded < sumAvailaleByPrefBill)
                    {
                        int billWouldBeSpended = sumNeeded / mMoneyStore[preferedType].getNominal();                        
                        outputSum[preferedType] += billWouldBeSpended;
                        sumNeeded -= billWouldBeSpended * mMoneyStore[preferedType].getNominal();
                        if (sumNeeded == 0)
                        {
                            break;
                        }
                    }                    
                }

                if(sumNeeded >= mMoneyStore[curKey.Key].getNominal())
                {
                    int prefBillAvailable = mMoneyStore[preferedType].getAmount() - outputSum[preferedType];
                    int sumAvailaleByPrefBill = mMoneyStore[preferedType].getNominal() * prefBillAvailable;
                    if (curKey.Key == preferedType)
                    {
                        outputSum[curKey.Key] += prefBillAvailable;
                        sumNeeded -= prefBillAvailable * mMoneyStore[preferedType].getNominal();
                        if (sumNeeded == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        int curBillAmount = (sumNeeded - sumAvailaleByPrefBill) / mMoneyStore[curKey.Key].getNominal();
                        int resid = (sumNeeded - sumAvailaleByPrefBill) % mMoneyStore[curKey.Key].getNominal();
                        if(resid != 0)
                        {
                            ++curBillAmount;
                        }
                        outputSum[curKey.Key] += curBillAmount;
                        sumNeeded -= curBillAmount * mMoneyStore[curKey.Key].getNominal();
                        if (sumNeeded == 0)
                        {
                            break;
                        }
                    }
                }
            }

            if(sumNeeded == 0)
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
