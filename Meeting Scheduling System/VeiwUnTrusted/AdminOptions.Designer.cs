namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AdminOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonBack = new Button();
            ButtonEditRooms = new Button();
            ButtonBilling = new Button();
            ButtonDisplay = new Button();
            ButtonCreateAdmin = new Button();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click_1;
            // 
            // ButtonEditRooms
            // 
            ButtonEditRooms.Location = new Point(75, 124);
            ButtonEditRooms.Name = "ButtonEditRooms";
            ButtonEditRooms.Size = new Size(117, 54);
            ButtonEditRooms.TabIndex = 1;
            ButtonEditRooms.Text = "Edit Rooms";
            ButtonEditRooms.UseVisualStyleBackColor = true;
            ButtonEditRooms.Click += ButtonEditRooms_Click;
            // 
            // ButtonBilling
            // 
            ButtonBilling.Location = new Point(240, 124);
            ButtonBilling.Name = "ButtonBilling";
            ButtonBilling.Size = new Size(117, 54);
            ButtonBilling.TabIndex = 2;
            ButtonBilling.Text = "Update Billing Info";
            ButtonBilling.UseVisualStyleBackColor = true;
            ButtonBilling.Click += ButtonBilling_Click;
            // 
            // ButtonDisplay
            // 
            ButtonDisplay.Location = new Point(410, 124);
            ButtonDisplay.Name = "ButtonDisplay";
            ButtonDisplay.Size = new Size(117, 54);
            ButtonDisplay.TabIndex = 3;
            ButtonDisplay.Text = "Display Meetings";
            ButtonDisplay.UseVisualStyleBackColor = true;
            ButtonDisplay.Click += ButtonDisplay_Click;
            // 
            // ButtonCreateAdmin
            // 
            ButtonCreateAdmin.Location = new Point(574, 124);
            ButtonCreateAdmin.Name = "ButtonCreateAdmin";
            ButtonCreateAdmin.Size = new Size(117, 54);
            ButtonCreateAdmin.TabIndex = 4;
            ButtonCreateAdmin.Text = "Create Admins";
            ButtonCreateAdmin.UseVisualStyleBackColor = true;
            ButtonCreateAdmin.Click += ButtonCreateAdmin_Click;
            // 
            // AdminOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCreateAdmin);
            Controls.Add(ButtonDisplay);
            Controls.Add(ButtonBilling);
            Controls.Add(ButtonEditRooms);
            Controls.Add(ButtonBack);
            Name = "AdminOptions";
            Text = "AdminOptions";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonEditRooms;
        private Button ButtonBilling;
        private Button ButtonDisplay;
        private Button ButtonCreateAdmin;
    }
}