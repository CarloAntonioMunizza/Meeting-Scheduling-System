using Meeting_Scheduling_System.ControllerTrusted;
using Meeting_Scheduling_System.ModelTrusted;
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
    public partial class AdminMeetingDisplay : Form
    {
        public AdminMeetingDisplay()
        {
            InitializeComponent();
            List<Room> rooms = new List<Room>();
            foreach (Room room in rooms) 
            { 
                rooms.Add(room);
            }
            List<Account> accountIndex = new List<Account>();
            foreach (var account in AccountController.Accounts)
            {
                CBPerson.Items.Add(account.Email);
                accountIndex.Add(account);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void RBWeek_CheckedChanged(object sender, EventArgs e)
        {
            CBWeek.Visible = true;

            CBDay.Visible = false;
            CBTime.Visible = false;
            CBRoom.Visible = false;
            CBPerson.Visible = false;
        }

        private void RBDay_CheckedChanged(object sender, EventArgs e)
        {
            CBDay.Visible = true;

            CBWeek.Visible = false;
            CBTime.Visible = false;
            CBRoom.Visible = false;
            CBPerson.Visible = false;
        }

        private void RBTime_CheckedChanged(object sender, EventArgs e)
        {
            CBTime.Visible = true;

            CBWeek.Visible = false;
            CBDay.Visible = false;
            CBRoom.Visible = false;
            CBPerson.Visible = false;
        }

        private void RBRoom_CheckedChanged(object sender, EventArgs e)
        {
            CBRoom.Visible = true;

            CBWeek.Visible = false;
            CBDay.Visible = false;
            CBTime.Visible = false;
            CBPerson.Visible = false;
        }

        private void RBPerson_CheckedChanged(object sender, EventArgs e)
        {
            CBPerson.Visible = true;

            CBWeek.Visible = false;
            CBDay.Visible = false;
            CBTime.Visible = false;
            CBRoom.Visible = false;
        }
    }
}
