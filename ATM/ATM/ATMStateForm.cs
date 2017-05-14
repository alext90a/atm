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
    public partial class ATMStateForm : Form
    {
        ATMData mAtmData = null;
        public ATMStateForm(ATMData atmData)
        {
            InitializeComponent();
            mAtmData = atmData;
            mAtmData.MoneyChangedEvent += onAtmMoneyChanged;
            onAtmMoneyChanged();
            FormClosing += (object sender, FormClosingEventArgs e) => { mAtmData.MoneyChangedEvent -= onAtmMoneyChanged; };
        }

        void onAtmMoneyChanged()
        {
            m10NominalField.Value = mAtmData.getNominalAmount(ATMData.BILL_TYPE.TYPE_10);
            m50NominalField.Value = mAtmData.getNominalAmount(ATMData.BILL_TYPE.TYPE_50);
            m100NominalField.Value = mAtmData.getNominalAmount(ATMData.BILL_TYPE.TYPE_100);
            m500NominalField.Value = mAtmData.getNominalAmount(ATMData.BILL_TYPE.TYPE_500);

            mMax10TB.Text = mAtmData.getMaxAmount(ATMData.BILL_TYPE.TYPE_10).ToString();
            mMax50TB.Text = mAtmData.getMaxAmount(ATMData.BILL_TYPE.TYPE_50).ToString();
            mMax100TB.Text = mAtmData.getMaxAmount(ATMData.BILL_TYPE.TYPE_100).ToString();
            mMax500TB.Text = mAtmData.getMaxAmount(ATMData.BILL_TYPE.TYPE_500).ToString();
            mSumField.Text = mAtmData.getMoneySum().ToString();
        }
    }
}
