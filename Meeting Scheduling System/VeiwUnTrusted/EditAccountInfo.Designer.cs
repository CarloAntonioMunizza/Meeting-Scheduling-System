namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class EditAccountInfo
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
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelSQ = new System.Windows.Forms.Label();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.SQField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1396, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click_1);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(495, 205);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(167, 41);
            this.LabelFirstName.TabIndex = 2;
            this.LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(497, 287);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(164, 41);
            this.LabelLastName.TabIndex = 3;
            this.LabelLastName.Text = "Last Name:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(516, 379);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(150, 41);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password:";
            // 
            // LabelSQ
            // 
            this.LabelSQ.AutoSize = true;
            this.LabelSQ.Location = new System.Drawing.Point(26, 494);
            this.LabelSQ.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSQ.Name = "LabelSQ";
            this.LabelSQ.Size = new System.Drawing.Size(614, 41);
            this.LabelSQ.TabIndex = 5;
            this.LabelSQ.Text = "Security Question, Whats your favouite color:";
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(684, 199);
            this.FirstNameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(261, 47);
            this.FirstNameField.TabIndex = 6;
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(682, 281);
            this.LastNameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(261, 47);
            this.LastNameField.TabIndex = 7;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(684, 365);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(261, 47);
            this.PasswordField.TabIndex = 8;
            // 
            // SQField
            // 
            this.SQField.Location = new System.Drawing.Point(684, 488);
            this.SQField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SQField.Name = "SQField";
            this.SQField.Size = new System.Drawing.Size(261, 47);
            this.SQField.TabIndex = 9;
            // 
            // EditAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 922);
            this.Controls.Add(this.SQField);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LastNameField);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.LabelSQ);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditAccountInfo";
            this.Text = "EditAccountInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label LabelFirstName;
        private Label LabelLastName;
        private Label LabelPassword;
        private Label LabelSQ;
        private TextBox FirstNameField;
        private TextBox LastNameField;
        private TextBox PasswordField;
        private TextBox SQField;
    }
}