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
    public partial class Meetings : Form
    {
        public Meetings()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {

            MeetingCreation MeetingCreationForm = new MeetingCreation();
            this.Hide();
            MeetingCreationForm.ShowDialog();
            this.Dispose();

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            MeetingEditor MeetingEditorForm = new MeetingEditor();
            this.Hide();
            MeetingEditorForm.ShowDialog();
            this.Dispose();
        }


        private void ButtonView_Click(object sender, EventArgs e)
        {
            ViewMeetings ViewMeetingsForm = new ViewMeetings();
            this.Hide();
            ViewMeetingsForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }
    }
}
