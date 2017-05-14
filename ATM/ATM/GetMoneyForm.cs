﻿using System;
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
    public partial class GetMoneyForm : Form
    {
        ATMData mAtmData = null;
        public delegate void OnClose();
        OnClose mOnCloseFunc; 
        public GetMoneyForm(ATMData atmData, OnClose closeFunc)
        {
            InitializeComponent();
            mAtmData = atmData;
            mOnCloseFunc = closeFunc;

            mPrefCB.Items.Add(ATMData.BILL_TYPE.TYPE_10);
            mPrefCB.Items.Add(ATMData.BILL_TYPE.TYPE_50);
            mPrefCB.Items.Add(ATMData.BILL_TYPE.TYPE_100);
            mPrefCB.Items.Add(ATMData.BILL_TYPE.TYPE_500);
            mPrefCB.SelectedIndex = 0;
        }

        private void mCancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mOnCloseFunc();
        }

        private void mGetMoneyBtn_Click(object sender, EventArgs e)
        {
            int sum = (int)mSumField.Value;
            ATMData.BILL_TYPE prefType = (ATMData.BILL_TYPE)mPrefCB.SelectedItem;
            string outputMessage = string.Empty;
            Dictionary<ATMData.BILL_TYPE, int> returnedMoney;
            OperationResultForm resultForm = null;
            if (mAtmData.tryToGiveAwayMoney(sum, prefType, ref outputMessage, out returnedMoney))
            {
                resultForm = new OperationResultForm(returnedMoney, outputMessage, sum);
            }
            {
                resultForm = new OperationResultForm(returnedMoney, outputMessage, 0);
            }
            
            resultForm.StartPosition = FormStartPosition.CenterParent;
            resultForm.ShowDialog();
            
            
        }
    }
}
