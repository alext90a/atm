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
    public partial class StartMenu : Form
    {
        
        ATMData mAtmData = null;
        ATMStateForm mStateForm = null;
        public StartMenu(ATMData atmData)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
            mAtmData = atmData;
            mStateForm = new ATMStateForm(mAtmData);
        }

        private void mInsertMoneyButton_Click(object sender, EventArgs e)
        {
            InsertMoneyForm insertMoneyForm = new InsertMoneyForm(mAtmData, onInsertMoneyCanceled);
            insertMoneyForm.StartPosition = FormStartPosition.CenterParent;
            insertMoneyForm.ShowDialog(this);
        }

        void onInsertMoneyCanceled()
        {
            this.Show();
        }

        private void mGetMoneyButton_Click(object sender, EventArgs e)
        {
            GetMoneyForm getMoneyForm = new GetMoneyForm(mAtmData, onInsertMoneyCanceled);
            getMoneyForm.StartPosition = FormStartPosition.CenterParent;
            getMoneyForm.ShowDialog(this);
        }

        private void mShowBankStatButton_Click(object sender, EventArgs e)
        {
            if(!mStateForm.Visible)
            {
                mStateForm = new ATMStateForm(mAtmData);
                mStateForm.Show(this);
            }
            mStateForm.Focus();
            Point startPoint = new Point();
            startPoint.X = Location.X + Width;
            startPoint.Y = Location.Y;
            mStateForm.Location = startPoint;
            mStateForm.StartPosition = FormStartPosition.Manual;
        }

        private void mHelpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1kYYyRPC9Z0SKLHP9dTGTYbeXhQwlCyWfZpSrtgu6ck0/edit?usp=sharing");
        }
    }
}
