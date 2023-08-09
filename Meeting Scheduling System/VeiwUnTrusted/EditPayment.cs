using Meeting_Scheduling_System.ControllerTrusted;
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
    public partial class EditPayment : Form
    {
        public EditPayment()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Account AccountForm = new Account();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int cardNumber = Int32.Parse(MaskedCardNumField.Text);
            int ccv = Int32.Parse(MaskedCCVField.Text);

            AccountController.CurrentAccount.PaymentMethod.CardNumber = cardNumber;
            AccountController.CurrentAccount.PaymentMethod.Ccv = ccv;

            Account AccountForm = new Account();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();

        }
    }
}
