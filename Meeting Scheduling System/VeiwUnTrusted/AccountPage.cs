using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void ButtonEditInfo_Click(object sender, EventArgs e)
        {
            ConfirmEditPaymentInfo ConfirmEditPaymentInfoForm = new ConfirmEditPaymentInfo();
            this.Hide();
            ConfirmEditPaymentInfoForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonEditAccountInfo_Click(object sender, EventArgs e)
        {
            ConfirmEditAccountInfo ConfirmEditAccountInfoForm = new ConfirmEditAccountInfo();
            this.Hide();
            ConfirmEditAccountInfoForm.ShowDialog();
            this.Dispose();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonAddPayment_Click(object sender, EventArgs e)
        {
            ConfirmAddPaymentInfo ConfirmAddPaymentInfoForm = new ConfirmAddPaymentInfo();
            this.Hide();
            ConfirmAddPaymentInfoForm.ShowDialog();
            this.Dispose();
        }
    }
}
