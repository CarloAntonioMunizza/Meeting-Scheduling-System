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
    public partial class AdminViewComplaint : Form
    {
        static List<Complaint> complaintIndex = new List<Complaint>();
        public AdminViewComplaint()
        {
            InitializeComponent();
            

            foreach (var complaint in ComplaintController.ComplaintList)
            {
                if(!complaint.IsReviewed)
                {
                    comboBox1.Items.Add(complaint.Sender.Email);
                    complaintIndex.Add(complaint);
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
            complaintIndex[comboBox1.SelectedIndex].Response = textBox2.Text;
            ComplaintController.respondToComplaint(complaintIndex[comboBox1.SelectedIndex]);

            AdminOptions AdminOptionsForm = new AdminOptions();
            this.Hide();
            AdminOptionsForm.ShowDialog();
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectDetailsField.Text = complaintIndex[comboBox1.SelectedIndex].Message;

        }
    }
}
