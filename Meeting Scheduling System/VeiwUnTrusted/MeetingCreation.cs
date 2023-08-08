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
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Meetings MeetingsForm = new Meetings();
            this.Hide();
            MeetingsForm.ShowDialog();
            this.Dispose();
        }
    }
}
