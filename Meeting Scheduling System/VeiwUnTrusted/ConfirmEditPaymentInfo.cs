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
    public partial class ConfirmEditPaymentInfo : Form
    {
        public ConfirmEditPaymentInfo()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string enteredPassword = MaskedConfirmPasswordField.Text;
            if (ControllerTrusted.AccountController.confirmPassword(ControllerTrusted.AccountController.CurrentAccount.Password, enteredPassword))
            {
                EditPayment EditPaymentForm = new EditPayment();
                this.Hide();
                EditPaymentForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                LabelIncorrectPassword.Visible = true;
            }
        }
    }
}
