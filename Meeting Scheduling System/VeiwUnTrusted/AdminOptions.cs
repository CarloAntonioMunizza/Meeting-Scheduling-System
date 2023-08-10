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
    public partial class AdminOptions : Form
    {
        public AdminOptions()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonEditRooms_Click(object sender, EventArgs e)
        {
            AdminRoomEdit AdminRoomEditForm = new AdminRoomEdit();
            this.Hide();
            AdminRoomEditForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonBilling_Click(object sender, EventArgs e)
        {
            AdminUpdateBilling AdminUpdateBillingForm = new AdminUpdateBilling();
            this.Hide();
            AdminUpdateBillingForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            AdminMeetingDisplay AdminMeetingDisplayForm = new AdminMeetingDisplay();
            this.Hide();
            AdminMeetingDisplayForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonCreateAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmins CreateAdminsForm = new CreateAdmins();
            this.Hide();
            CreateAdminsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }
    }
}
