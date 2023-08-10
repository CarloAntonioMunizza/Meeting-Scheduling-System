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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AccountPage accountForm = new AccountPage();
            this.Hide();
            accountForm.ShowDialog();
            this.Dispose();
        }
        
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string tempCardNum = MaskedCardInfoField.Text;
            tempCardNum = tempCardNum.Replace("-", "");
            string tempCCV = MaskedCCVField.Text;
            long cardNumber = Int64.Parse(tempCardNum);
            int ccv = Int32.Parse(tempCCV);

            AccountController.CurrentAccount.PaymentMethod.CardNumber = cardNumber;
            AccountController.CurrentAccount.PaymentMethod.Ccv = ccv;

            AccountPage AccountForm = new AccountPage();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {

        }

        private void MaskedCCVField_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotSupportedException();
        }
    }
}
