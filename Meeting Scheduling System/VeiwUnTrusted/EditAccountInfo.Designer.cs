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
            this.MaskedFirstNameField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedLastNameField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedSQField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedPasswordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(32, 986);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(198, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1608, 972);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(198, 59);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(678, 310);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(167, 41);
            this.LabelFirstName.TabIndex = 2;
            this.LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(674, 420);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(164, 41);
            this.LabelLastName.TabIndex = 3;
            this.LabelLastName.Text = "Last Name:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(693, 537);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(150, 41);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password:";
            // 
            // LabelSQ
            // 
            this.LabelSQ.AutoSize = true;
            this.LabelSQ.Location = new System.Drawing.Point(202, 662);
            this.LabelSQ.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LabelSQ.Name = "LabelSQ";
            this.LabelSQ.Size = new System.Drawing.Size(614, 41);
            this.LabelSQ.TabIndex = 5;
            this.LabelSQ.Text = "Security Question, Whats your favouite color:";
            // 
            // MaskedFirstNameField
            // 
            this.MaskedFirstNameField.Location = new System.Drawing.Point(867, 295);
            this.MaskedFirstNameField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedFirstNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.MaskedFirstNameField.Name = "MaskedFirstNameField";
            this.MaskedFirstNameField.Size = new System.Drawing.Size(261, 47);
            this.MaskedFirstNameField.TabIndex = 6;
            // 
            // MaskedLastNameField
            // 
            this.MaskedLastNameField.Location = new System.Drawing.Point(867, 414);
            this.MaskedLastNameField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedLastNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.MaskedLastNameField.Name = "MaskedLastNameField";
            this.MaskedLastNameField.Size = new System.Drawing.Size(261, 47);
            this.MaskedLastNameField.TabIndex = 7;
            // 
            // MaskedSQField
            // 
            this.MaskedSQField.Location = new System.Drawing.Point(867, 648);
            this.MaskedSQField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedSQField.Mask = "LLLLLLLLLLLLLLL";
            this.MaskedSQField.Name = "MaskedSQField";
            this.MaskedSQField.Size = new System.Drawing.Size(261, 47);
            this.MaskedSQField.TabIndex = 9;
            // 
            // MaskedPasswordField
            // 
            this.MaskedPasswordField.Location = new System.Drawing.Point(867, 531);
            this.MaskedPasswordField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedPasswordField.Name = "MaskedPasswordField";
            this.MaskedPasswordField.PasswordChar = '#';
            this.MaskedPasswordField.Size = new System.Drawing.Size(261, 47);
            this.MaskedPasswordField.TabIndex = 10;
            // 
            // EditAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 1076);
            this.Controls.Add(this.MaskedPasswordField);
            this.Controls.Add(this.MaskedSQField);
            this.Controls.Add(this.MaskedLastNameField);
            this.Controls.Add(this.MaskedFirstNameField);
            this.Controls.Add(this.LabelSQ);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private MaskedTextBox MaskedFirstNameField;
        private MaskedTextBox MaskedLastNameField;
        private MaskedTextBox MaskedSQField;
        private TextBox MaskedPasswordField;
    }
}