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
            Account AccountForm = new Account();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click_1(object sender, EventArgs e)
        {
            AccountController.CurrentAccount.FirstName = FirstNameField.Text;
            AccountController.CurrentAccount.LastName= LastNameField.Text;
            AccountController.CurrentAccount.Password= PasswordField.Text;
            AccountController.CurrentAccount.SecurityA = SQField.Text;

            Account AccountForm = new Account();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();

        }
    }
}
