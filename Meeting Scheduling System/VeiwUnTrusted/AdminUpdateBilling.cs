using Meeting_Scheduling_System.ControllerTrusted;
using Meeting_Scheduling_System.ModelTrusted;
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
    public partial class AdminUpdateBilling : Form
    {
        public AdminUpdateBilling()
        {
            InitializeComponent();
            List<Account> accountIndex = new List<Account>();
            foreach (var account in AccountController.Accounts) 
            {
                EmailComboBox.Items.Add(account.Email);
                accountIndex.Add(account);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int accountindex = EmailComboBox.SelectedIndex;
            Account account = AccountController.Accounts[accountindex];
            account.PaymentMethod.CardNumber = Int32.Parse(MaskedCardNumField.Text);
            account.PaymentMethod.Ccv = Int32.Parse(MaskedCCVField.Text);


            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click_1(object sender, EventArgs e)
        {
            int accountindex = EmailComboBox.SelectedIndex;
            Account account = AccountController.Accounts[accountindex];
            Console.WriteLine(MaskedCardNumField.Text.Replace("-",""));
            BillingInfo bi = new BillingInfo(Int64.Parse(MaskedCardNumField.Text.Replace("-", "")), Int32.Parse(MaskedCCVField.Text));
            account.PaymentMethod= bi;


            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }
    }
}
