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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    public partial class MeetingEditor : Form
    {
        public MeetingEditor()
        {
            InitializeComponent();
            foreach (var meeting in AccountController.CurrentAccount.Meetings)
            {
                comboBox1.Items.Add(meeting.Time + meeting.Room);
            }
            foreach (var time in MeetingController.TimeList)
            {
                comboBox2.Items.Add(time);
            }
            foreach (var room in RoomController.Rooms)
            {
                comboBox3.Items.Add(room.RoomName);
            }
            foreach (var person in AccountController.Accounts)
            {
                checkedListBox1.Items.Add(person.Email);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Meetings MeetingsForm = new Meetings();
            this.Hide();
            MeetingsForm.ShowDialog();
            this.Dispose();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = MeetingController.CurrentMeeting;
            MeetingController.CurrentMeeting.Time = comboBox2.SelectedItem.ToString();
            MeetingController.CurrentMeeting.Room = (Room)comboBox3.SelectedItem;

            Meetings MeetingsForm = new Meetings();
            this.Hide();
            MeetingsForm.ShowDialog();
            this.Dispose();
        }
    }
}
