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
    public partial class MeetingCreation : Form
    {
        
        

        public MeetingCreation()
        {
            InitializeComponent();

            foreach (var time in MeetingController.TimeList)
            {
                TimeBox.Items.Add(time);
            }
            foreach (var room in RoomController.Rooms)
            {
                RoomBox.Items.Add(room.RoomName);
            }
            foreach (var person in AccountController.Accounts)
            {
                PeopleBox.Items.Add(person.Email);
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Meetings MeetingsForm = new Meetings();
            this.Hide();
            MeetingsForm.ShowDialog();
            this.Dispose();
        }

       

        private void RoomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!MeetingController.checkAvailability(RoomController.Rooms[RoomBox.SelectedIndex], TimeBox.Text))
            {
                MessageBox.Show("This Room is not available at this time.");
            }
        }

        private void CreateMeetingButton_Click(object sender, EventArgs e)
        {
            if (!MeetingController.checkAvailability(RoomController.Rooms[RoomBox.SelectedIndex], TimeBox.Text))
            {
                MessageBox.Show("This Room is not available at this time.");
            } else
            {
                List<Account> paricipants = new List<Account>();


                

                foreach (var person in PeopleBox.CheckedItems)
                {
                    for (int i = 0; i < AccountController.Accounts.Count; i++)
                    {
                        if (AccountController.Accounts[i].Email.Equals(person))
                        {
                            paricipants.Add(AccountController.Accounts[i]);
                        }
                    }
                   
                }
                MeetingController.createMeeting(RoomController.Rooms[RoomBox.SelectedIndex], TimeBox.Text, paricipants, AccountController.CurrentAccount);
                Meetings MeetingsForm = new Meetings();
                this.Hide();
                MeetingsForm.ShowDialog();
                this.Dispose();
            }

            
        }
    }
}
