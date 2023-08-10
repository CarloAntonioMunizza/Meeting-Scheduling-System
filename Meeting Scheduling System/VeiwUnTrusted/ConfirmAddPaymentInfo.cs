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
    public partial class ConfirmAddPaymentInfo : Form
    {
        public ConfirmAddPaymentInfo()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string enteredPassword = MaskedConfirmPasswordField.Text;
            if (ControllerTrusted.AccountController.confirmPassword(ControllerTrusted.AccountController.CurrentAccount.Password, enteredPassword))
            {
                AddPayment AddPaymentForm = new AddPayment();
                this.Hide();
                AddPaymentForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                LabelIncorrectPassword.Visible = true;
            }
        }
    }
}
