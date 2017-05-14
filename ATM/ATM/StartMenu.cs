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
        public StartMenu(ATMData atmData)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            mAtmData = atmData;
            
            
            
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
            ATMStateForm stateForm = new ATMStateForm(mAtmData);
            stateForm.Show(this);
            Point startPoint = new Point();
            startPoint.X = Location.X + Width;
            startPoint.Y = Location.Y;
            stateForm.Location = startPoint;
            stateForm.StartPosition = FormStartPosition.Manual;
        }
    }
}
