namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class MainMenu
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonMeeting = new System.Windows.Forms.Button();
            this.ButtonFileComplaint = new System.Windows.Forms.Button();
            this.ButtonAccount = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonAdminViewComplaint = new System.Windows.Forms.Button();
            this.ButtonAdminOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(716, 45);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(237, 54);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Main Menu";
            // 
            // ButtonMeeting
            // 
            this.ButtonMeeting.Location = new System.Drawing.Point(255, 303);
            this.ButtonMeeting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonMeeting.Name = "ButtonMeeting";
            this.ButtonMeeting.Size = new System.Drawing.Size(268, 109);
            this.ButtonMeeting.TabIndex = 1;
            this.ButtonMeeting.Text = "Meetings";
            this.ButtonMeeting.UseVisualStyleBackColor = true;
            this.ButtonMeeting.Click += new System.EventHandler(this.ButtonMeeting_Click);
            // 
            // ButtonFileComplaint
            // 
            this.ButtonFileComplaint.Location = new System.Drawing.Point(716, 303);
            this.ButtonFileComplaint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonFileComplaint.Name = "ButtonFileComplaint";
            this.ButtonFileComplaint.Size = new System.Drawing.Size(268, 109);
            this.ButtonFileComplaint.TabIndex = 2;
            this.ButtonFileComplaint.Text = "File Complaint";
            this.ButtonFileComplaint.UseVisualStyleBackColor = true;
            this.ButtonFileComplaint.Click += new System.EventHandler(this.ButtonFileComplaint_Click);
            // 
            // ButtonAccount
            // 
            this.ButtonAccount.Location = new System.Drawing.Point(1154, 303);
            this.ButtonAccount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAccount.Name = "ButtonAccount";
            this.ButtonAccount.Size = new System.Drawing.Size(268, 109);
            this.ButtonAccount.TabIndex = 3;
            this.ButtonAccount.Text = "Account";
            this.ButtonAccount.UseVisualStyleBackColor = true;
            this.ButtonAccount.Click += new System.EventHandler(this.ButtonAccount_Click);
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(352, 409);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(94, 29);
            ButtonLogout.TabIndex = 4;
            ButtonLogout.Text = "Log Out";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            this.ButtonLogout.Location = new System.Drawing.Point(748, 838);
            this.ButtonLogout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(200, 59);
            this.ButtonLogout.TabIndex = 4;
            this.ButtonLogout.Text = "Log Out";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            // 
            // ButtonAdminViewComplaint
            // 
            this.ButtonAdminViewComplaint.Location = new System.Drawing.Point(931, 537);
            this.ButtonAdminViewComplaint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAdminViewComplaint.Name = "ButtonAdminViewComplaint";
            this.ButtonAdminViewComplaint.Size = new System.Drawing.Size(312, 133);
            this.ButtonAdminViewComplaint.TabIndex = 5;
            this.ButtonAdminViewComplaint.Text = "Admin View Complaint";
            this.ButtonAdminViewComplaint.UseVisualStyleBackColor = true;
            this.ButtonAdminViewComplaint.Click += new System.EventHandler(this.ButtonAdminViewComplaint_Click);
            // 
            // ButtonAdminOptions
            // 
            this.ButtonAdminOptions.Location = new System.Drawing.Point(440, 537);
            this.ButtonAdminOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAdminOptions.Name = "ButtonAdminOptions";
            this.ButtonAdminOptions.Size = new System.Drawing.Size(312, 133);
            this.ButtonAdminOptions.TabIndex = 6;
            this.ButtonAdminOptions.Text = "Admin Options";
            this.ButtonAdminOptions.UseVisualStyleBackColor = true;
            this.ButtonAdminOptions.Click += new System.EventHandler(this.ButtonAdminOptions_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ButtonAdminOptions);
            this.Controls.Add(this.ButtonAdminViewComplaint);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ButtonAccount);
            this.Controls.Add(this.ButtonFileComplaint);
            this.Controls.Add(this.ButtonMeeting);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTitle;
        private Button ButtonMeeting;
        private Button ButtonFileComplaint;
        private Button ButtonAccount;
        private Button ButtonLogout;
        private Button ButtonAdminViewComplaint;
        private Button ButtonAdminOptions;
    }
}