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
    public partial class OperationResultForm : Form
    {
        public OperationResultForm(Dictionary<ATMData.BILL_TYPE, int> returnedMoney, string outputMessage, int returnedSum)
        {
            InitializeComponent();
            
            mOutMessageField.Text = outputMessage;
            //mNomGB.Parent = mRetMoneyGB;

            if(returnedSum == 0)
            {
                mRetMoneyGB.Visible = false;
                mNomGB.Visible = false;
            }
            else
            {
                mRetMoneyGB.Visible = true;
                mNomGB.Visible = true;
                m10NominalField.Value = returnedMoney[ATMData.BILL_TYPE.TYPE_10];
                m50NominalField.Value = returnedMoney[ATMData.BILL_TYPE.TYPE_50];
                m100NominalField.Value = returnedMoney[ATMData.BILL_TYPE.TYPE_100];
                m500NominalField.Value = returnedMoney[ATMData.BILL_TYPE.TYPE_500];
                mRetSum.Text = returnedSum.ToString();
            }
        }

        private void mOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
