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
    public partial class AdminViewComplaint : Form
    {
        public AdminViewComplaint()
        {
            InitializeComponent();
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
            //still need to save info
            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }
    }
}
