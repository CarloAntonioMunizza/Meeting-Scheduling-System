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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonEditRooms = new System.Windows.Forms.Button();
            this.ButtonBilling = new System.Windows.Forms.Button();
            this.ButtonDisplay = new System.Windows.Forms.Button();
            this.ButtonCreateAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonEditRooms
            // 
            this.ButtonEditRooms.Location = new System.Drawing.Point(159, 254);
            this.ButtonEditRooms.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonEditRooms.Name = "ButtonEditRooms";
            this.ButtonEditRooms.Size = new System.Drawing.Size(249, 111);
            this.ButtonEditRooms.TabIndex = 1;
            this.ButtonEditRooms.Text = "Edit Rooms";
            this.ButtonEditRooms.UseVisualStyleBackColor = true;
            this.ButtonEditRooms.Click += new System.EventHandler(this.ButtonEditRooms_Click);
            // 
            // ButtonBilling
            // 
            this.ButtonBilling.Location = new System.Drawing.Point(510, 254);
            this.ButtonBilling.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBilling.Name = "ButtonBilling";
            this.ButtonBilling.Size = new System.Drawing.Size(249, 111);
            this.ButtonBilling.TabIndex = 2;
            this.ButtonBilling.Text = "Update Billing Info";
            this.ButtonBilling.UseVisualStyleBackColor = true;
            this.ButtonBilling.Click += new System.EventHandler(this.ButtonBilling_Click);
            // 
            // ButtonDisplay
            // 
            this.ButtonDisplay.Location = new System.Drawing.Point(871, 254);
            this.ButtonDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonDisplay.Name = "ButtonDisplay";
            this.ButtonDisplay.Size = new System.Drawing.Size(249, 111);
            this.ButtonDisplay.TabIndex = 3;
            this.ButtonDisplay.Text = "Display Meetings";
            this.ButtonDisplay.UseVisualStyleBackColor = true;
            this.ButtonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // ButtonCreateAdmin
            // 
            this.ButtonCreateAdmin.Location = new System.Drawing.Point(1220, 254);
            this.ButtonCreateAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonCreateAdmin.Name = "ButtonCreateAdmin";
            this.ButtonCreateAdmin.Size = new System.Drawing.Size(249, 111);
            this.ButtonCreateAdmin.TabIndex = 4;
            this.ButtonCreateAdmin.Text = "Create Admins";
            this.ButtonCreateAdmin.UseVisualStyleBackColor = true;
            this.ButtonCreateAdmin.Click += new System.EventHandler(this.ButtonCreateAdmin_Click);
            // 
            // AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ButtonCreateAdmin);
            this.Controls.Add(this.ButtonDisplay);
            this.Controls.Add(this.ButtonBilling);
            this.Controls.Add(this.ButtonEditRooms);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminOptions";
            this.Text = "AdminOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonBack;
        private Button ButtonEditRooms;
        private Button ButtonBilling;
        private Button ButtonDisplay;
        private Button ButtonCreateAdmin;
    }
}