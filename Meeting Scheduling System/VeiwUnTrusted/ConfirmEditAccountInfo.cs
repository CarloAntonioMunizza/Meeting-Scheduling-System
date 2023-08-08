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
    public partial class ConfirmEditAccountInfo : Form
    {
        public ConfirmEditAccountInfo()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            EditAccountInfo EditAccountInfoForm = new EditAccountInfo();
            this.Hide();
            EditAccountInfoForm.ShowDialog();
            this.Dispose();
        }
    }
}
