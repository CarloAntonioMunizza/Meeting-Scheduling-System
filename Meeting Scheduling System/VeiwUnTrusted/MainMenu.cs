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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Welcome WelcomeForm = new Welcome();
            this.Hide();
            WelcomeForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonMeeting_Click(object sender, EventArgs e)
        {
            Meetings MeetingsForm = new Meetings();
            this.Hide();
            MeetingsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonFileComplaint_Click(object sender, EventArgs e)
        {
            FileComplaint FileComplaintForm = new FileComplaint();
            this.Hide();
            FileComplaintForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonAccount_Click(object sender, EventArgs e)
        {
            Account AccountForm = new Account();
            this.Hide();
            AccountForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonAdminOptions_Click(object sender, EventArgs e)
        {
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonAdminViewComplaint_Click(object sender, EventArgs e)
        {
            AdminViewComplaint AdminViewComplaintForm = new AdminViewComplaint();
            this.Hide();
            AdminViewComplaintForm.ShowDialog();
            this.Dispose();
        }
    }
}
