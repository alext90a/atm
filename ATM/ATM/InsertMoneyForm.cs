using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class InsertMoneyForm : Form
    {

        ATMData mAtmData = null;
        public delegate void OnCloseClicked();
        OnCloseClicked mOnCloseFunc = null;
        Dictionary<ATMData.BILL_TYPE, int> mMoneyInserted = new Dictionary<ATMData.BILL_TYPE, int> {
            { ATMData.BILL_TYPE.TYPE_10, 0 },
            { ATMData.BILL_TYPE.TYPE_50, 0 },
            { ATMData.BILL_TYPE.TYPE_100, 0 },
            { ATMData.BILL_TYPE.TYPE_500, 0 } };
        public InsertMoneyForm(ATMData atmData, OnCloseClicked closeFunc)
        {
            InitializeComponent();
            mAtmData = atmData;
            mOnCloseFunc = closeFunc;
        }

        private void mCancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mOnCloseFunc();
        }

        int calculateSum()
        {
            int sum = 0;
            foreach(var curPair in mMoneyInserted)
            {
                sum += (int)curPair.Key * curPair.Value;
            }
            if(sum == 0)
            {
                mInsertBtn.Enabled = false;
            }
            else
            {
                mInsertBtn.Enabled = true;
            }
            return sum;
        }

        

        private void mInsertBtn_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(mSumTB.Text);
            string outputMessage = string.Empty;
            bool res = mAtmData.tryToInsertMoney(sum, mMoneyInserted, ref outputMessage);

            int returnedSum = 0;
            foreach(var curPair in mMoneyInserted)
            {
                returnedSum += (int)curPair.Key * curPair.Value;
            }
            if(sum != returnedSum)
            {
                outputMessage += "\nInserted sum is " + (sum - returnedSum).ToString();
            }
            OperationResultForm resultForm = new OperationResultForm(mMoneyInserted, outputMessage, returnedSum);
            resultForm.StartPosition = FormStartPosition.CenterParent;
            resultForm.ShowDialog();
            if(res)
            {
                updateInsertedMoney();
            }

        }

        void updateInsertedMoney()
        {
            m10NominalField.Value = mMoneyInserted[ATMData.BILL_TYPE.TYPE_10];
            m50NominalField.Value = mMoneyInserted[ATMData.BILL_TYPE.TYPE_50];
            m100NominalField.Value = mMoneyInserted[ATMData.BILL_TYPE.TYPE_100];
            m500NominalField.Value = mMoneyInserted[ATMData.BILL_TYPE.TYPE_500];
            Update();
        }

        private void m10NominalField_ValueChanged(object sender, EventArgs e)
        {
            mMoneyInserted[ATMData.BILL_TYPE.TYPE_10] = (int)m10NominalField.Value;
            mSumTB.Text = calculateSum().ToString();
        }

        private void m50NominalField_ValueChanged(object sender, EventArgs e)
        {
            mMoneyInserted[ATMData.BILL_TYPE.TYPE_50] = (int)m50NominalField.Value;
            mSumTB.Text = calculateSum().ToString();
        }

        private void m100NominalField_ValueChanged(object sender, EventArgs e)
        {
            mMoneyInserted[ATMData.BILL_TYPE.TYPE_100] = (int)m100NominalField.Value;
            mSumTB.Text = calculateSum().ToString();
        }

        private void m500NominalField_ValueChanged(object sender, EventArgs e)
        {
            mMoneyInserted[ATMData.BILL_TYPE.TYPE_500] = (int)m500NominalField.Value;
            mSumTB.Text = calculateSum().ToString();
        }
    }
}
