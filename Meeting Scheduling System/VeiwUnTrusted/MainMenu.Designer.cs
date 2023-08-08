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
            LabelTitle = new Label();
            ButtonMeeting = new Button();
            ButtonFileComplaint = new Button();
            ButtonAccount = new Button();
            ButtonLogout = new Button();
            ButtonAdminViewComplaint = new Button();
            ButtonAdminOptions = new Button();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(337, 22);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(120, 28);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Main Menu";
            // 
            // ButtonMeeting
            // 
            ButtonMeeting.Location = new Point(120, 148);
            ButtonMeeting.Name = "ButtonMeeting";
            ButtonMeeting.Size = new Size(126, 53);
            ButtonMeeting.TabIndex = 1;
            ButtonMeeting.Text = "Meetings";
            ButtonMeeting.UseVisualStyleBackColor = true;
            // 
            // ButtonFileComplaint
            // 
            ButtonFileComplaint.Location = new Point(337, 148);
            ButtonFileComplaint.Name = "ButtonFileComplaint";
            ButtonFileComplaint.Size = new Size(126, 53);
            ButtonFileComplaint.TabIndex = 2;
            ButtonFileComplaint.Text = "File Complaint";
            ButtonFileComplaint.UseVisualStyleBackColor = true;
            // 
            // ButtonAccount
            // 
            ButtonAccount.Location = new Point(543, 148);
            ButtonAccount.Name = "ButtonAccount";
            ButtonAccount.Size = new Size(126, 53);
            ButtonAccount.TabIndex = 3;
            ButtonAccount.Text = "Account";
            ButtonAccount.UseVisualStyleBackColor = true;
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
            // 
            // ButtonAdminViewComplaint
            // 
            ButtonAdminViewComplaint.Location = new Point(438, 262);
            ButtonAdminViewComplaint.Name = "ButtonAdminViewComplaint";
            ButtonAdminViewComplaint.Size = new Size(147, 65);
            ButtonAdminViewComplaint.TabIndex = 5;
            ButtonAdminViewComplaint.Text = "Admin View Complaint";
            ButtonAdminViewComplaint.UseVisualStyleBackColor = true;
            // 
            // ButtonAdminOptions
            // 
            ButtonAdminOptions.Location = new Point(207, 262);
            ButtonAdminOptions.Name = "ButtonAdminOptions";
            ButtonAdminOptions.Size = new Size(147, 65);
            ButtonAdminOptions.TabIndex = 6;
            ButtonAdminOptions.Text = "Admin Options";
            ButtonAdminOptions.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonAdminOptions);
            Controls.Add(ButtonAdminViewComplaint);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonAccount);
            Controls.Add(ButtonFileComplaint);
            Controls.Add(ButtonMeeting);
            Controls.Add(LabelTitle);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
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