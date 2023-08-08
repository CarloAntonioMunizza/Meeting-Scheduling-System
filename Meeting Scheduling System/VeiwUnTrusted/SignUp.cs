using Meeting_Scheduling_System.ControllerTrusted;
using Meeting_Scheduling_System.VeiwUnTrusted;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduling_System.Veiw_UnTrusted
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskedPasswordConfirmField_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Welcome WelcomeForm = new Welcome();
            this.Hide();
            WelcomeForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            InvalidPassword.Visible = false;

            string firstname = FirstNameMaskedField.Text;
            string lastname = LastNameMaskedField.Text;
            string email = EmailField.Text;
            string password1 = PasswordField.Text;
            string password2 = MaskedPasswordConfirmField.Text;
            string sQ = SQField.Text;

            bool validPass = AccountController.verifySignUpPassword(password1, password2);
            if (validPass)
            {
                AccountController.Createuser(firstname, lastname, email, password1, sQ);
                MainMenu MainMenuForm = new MainMenu();
                this.Hide();
                MainMenuForm.ShowDialog();
                this.Dispose();

            }
            else
            {
                InvalidPassword.Visible = true;
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
