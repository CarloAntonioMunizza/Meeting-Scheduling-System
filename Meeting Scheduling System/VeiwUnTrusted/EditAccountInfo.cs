using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meeting_Scheduling_System.ControllerTrusted;

namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    public partial class EditAccountInfo : Form
    {
        public EditAccountInfo()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AccountPage AccountForm = new AccountPage();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            AccountController.CurrentAccount.FirstName = MaskedFirstNameField.Text;
            AccountController.CurrentAccount.LastName = MaskedLastNameField.Text;
            AccountController.CurrentAccount.Password = MaskedPasswordField.Text;
            AccountController.CurrentAccount.SecurityA = MaskedSQField.Text;
            AccountPage AccountForm = new AccountPage();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }
    }
}
