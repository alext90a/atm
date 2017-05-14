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
        InsertMoneyForm mInsertMoneyForm = null;
        GetMoneyForm mGetMoneyForm = null;
        ATMStateForm mStateForm = null;
        public StartMenu(ATMData atmData)
        {
            InitializeComponent();
            mInsertMoneyForm = new InsertMoneyForm(atmData, onInsertMoneyCanceled);
            mGetMoneyForm = new GetMoneyForm(atmData, onInsertMoneyCanceled);
            mStateForm = new ATMStateForm(atmData);
        }

        private void mInsertMoneyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mInsertMoneyForm.Show();
        }

        void onInsertMoneyCanceled()
        {
            this.Show();
        }

        private void mGetMoneyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mGetMoneyForm.Show();
        }

        private void mShowBankStatButton_Click(object sender, EventArgs e)
        {
            mStateForm.Show(this);
            Point startPoint = new Point();
            startPoint.X = Location.X + Width;
            startPoint.Y = Location.Y;
            mStateForm.Location = startPoint;
            mStateForm.StartPosition = FormStartPosition.Manual;
        }
    }
}
