using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            public BillHolder(int nominal, int maxAmount)
            {
                mNominal = nominal;
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

            int mAmount;
            int mNominal;
            int mMaxAmount;
        };

        //========================================================
        public ATMData()
        {
            mMoneyStore.Add(BILL_TYPE.TYPE_10, new BillHolder(10, ATMConstants.kBillMaxAmount10));
            mMoneyStore.Add(BILL_TYPE.TYPE_50, new BillHolder(50, ATMConstants.kBillMaxAmount50));
            mMoneyStore.Add(BILL_TYPE.TYPE_100, new BillHolder(100, ATMConstants.kBillMaxAmount100));
            mMoneyStore.Add(BILL_TYPE.TYPE_500, new BillHolder(500, ATMConstants.kBillMaxAmount500));
        }
        public delegate void OnMoneyStoreChanged();
        public event OnMoneyStoreChanged MoneyChangedEvent; 
        SortedDictionary<BILL_TYPE, BillHolder> mMoneyStore = new SortedDictionary<BILL_TYPE, BillHolder>();

        public bool tryToGiveAwayMoney(int sum, BILL_TYPE preferedType, ref string outMessage, out Dictionary<BILL_TYPE, int> outputSum)
        {
            outputSum = new Dictionary<BILL_TYPE, int>();
            if(sum> getMoneySum())
            {
                outMessage = "Requested sum is not available";
                return false;
            }

            bool isSumCouldGiveAway = false;

            //if(sum < mMoneyStore[preferedType].getNomainal)
            int residueByPrefered = sum % mMoneyStore[preferedType].getMoneySum();
            if (residueByPrefered < mMoneyStore[preferedType].getNominal())
            {

            }
            else
            {
                int billsToRemove = sum / mMoneyStore[preferedType].getNominal();
                int sumResitual = sum - billsToRemove * mMoneyStore[preferedType].getNominal();

                //mMoneyStore[preferedType].tryDecrAmount(billsToRemove);
                outputSum.Add(preferedType, billsToRemove);
                foreach (var curPair in mMoneyStore.Reverse())
                {
                    if (curPair.Value.getNominal() > sumResitual || outputSum.ContainsKey(curPair.Key))
                    {
                        continue;
                    }
                    billsToRemove = sumResitual / mMoneyStore[curPair.Key].getNominal();
                    sumResitual = sum - billsToRemove * mMoneyStore[curPair.Key].getNominal();
                    //mMoneyStore[curPair.Key].tryDecrAmount(billsToRemove);
                    outputSum.Add(curPair.Key, billsToRemove);
                }    
                if(sumResitual>0)
                {
                    outMessage = "Could not give such sum";
                    return false;
                }
                else
                {
                    foreach(var curPair in outputSum)
                    {
                        mMoneyStore[curPair.Key].tryDecrAmount(curPair.Value);
                    }
                }
            }
            if(MoneyChangedEvent != null)
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
    }
}
