using Meeting_Scheduling_System.Veiw_UnTrusted;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();
            this.Hide();
            SignUpForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.ShowDialog();
            this.Dispose();
        }
    }
}
