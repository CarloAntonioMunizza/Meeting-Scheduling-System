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
    public partial class EditAccountInfo : Form
    {
        public EditAccountInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPayment EditPaymentForm = new EditPayment();
            this.Hide();
            EditPaymentForm.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
