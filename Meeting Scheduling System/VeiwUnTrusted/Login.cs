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
    public partial class Login : Form
    {
        readonly bool hasBeenClicked;
        public Login()
        {
            InitializeComponent();
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
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
            InvalidCredentials.Visible = false;

            string email = MaskedEmailField.Text;
            string password = PasswordField.Text;
            string sQ = MaskedSQField.Text;

            bool validLogin = AccountController.login(email, password, sQ);
            if (validLogin)
            {
                MainMenu MainMenuForm = new MainMenu();
                this.Hide();
                MainMenuForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                InvalidCredentials.Visible = true;
            }
        }

        private void MaskedEmailField_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
