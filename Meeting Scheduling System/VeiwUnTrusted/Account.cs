﻿using System;
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
            MeetingCreation MeetingCreationForm = new MeetingCreation();
            this.Hide();
            MeetingCreationForm.ShowDialog();
            this.Dispose();
        }
    }
}
