using Meeting_Scheduling_System.ControllerTrusted;
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
    public partial class FileComplaint : Form
    {
        public FileComplaint()
        {
            InitializeComponent();
            if(AccountController.CurrentAccount.Complaint.IsReviewed)
            {
                DescriptionField.Text = AccountController.CurrentAccount.Complaint.Message;
                ResponseReadOnlyField.Text = AccountController.CurrentAccount.Complaint.Response;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ComplaintController.addComplaint(DescriptionField.Text);

            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Dispose();
        }
    }
}
