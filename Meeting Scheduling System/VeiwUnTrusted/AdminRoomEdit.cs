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
    public partial class AdminRoomEdit : Form
    {
        public AdminRoomEdit()
        {
            InitializeComponent();
            foreach (var room in RoomController.Rooms)
            {
                if(room.IsSpecial)
                {
                    CheckedList.Items.Add(room.RoomNumber + " S");
                }
                else
                {
                    CheckedList.Items.Add(room.RoomNumber);
                }
                
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //adding room
            if (MaskedRoomNumField.Text.Length > 0)
            {
                int roomNum = Int32.Parse(MaskedRoomNumField.Text);
                bool special = CheckSpecialRoom.Checked;
                RoomController.addRoom(new ModelTrusted.Room(roomNum, special));
            }
            //removing checked rooms
            foreach (var item in CheckedList.CheckedItems)
            {
                for (int i = 0; i < RoomController.Rooms.Count; i++)
                {
                    Room temp = RoomController.Rooms[i];
                    if (temp.RoomNumber.ToString().Equals((item.ToString().Substring(0, 3))))
                    {
                        RoomController.Rooms.Remove(temp);
                    }
                }
            }

            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
            

        }

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }
    }
}
