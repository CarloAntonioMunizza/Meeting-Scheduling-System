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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void LableTitle_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonEditInfo_Click(object sender, EventArgs e)
        {
            EditPayment EditPaymentForm = new EditPayment();
            this.Hide();
            EditPaymentForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAccountInfo EditAccountInfoForm = new EditAccountInfo();
            this.Hide();
            EditAccountInfoForm.ShowDialog();
            this.Dispose();
        }
    }
}
