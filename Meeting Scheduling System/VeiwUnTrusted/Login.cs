﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduling_System.Veiw_UnTrusted
{
    public partial class Login : Form
    {
        bool hasBeenClicked = false;
        public Login()
        {
            InitializeComponent();
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }
    }
}
