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
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            LabelPassword = new Label();
            LabelSQ = new Label();
            FirstNameField = new TextBox();
            LastNameField = new TextBox();
            PasswordField = new TextBox();
            SQField = new TextBox();
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
            ButtonBack.Click += button1_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(657, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += button2_Click;
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(233, 100);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(83, 20);
            LabelFirstName.TabIndex = 2;
            LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(234, 140);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(82, 20);
            LabelLastName.TabIndex = 3;
            LabelLastName.Text = "Last Name:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(243, 185);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(73, 20);
            LabelPassword.TabIndex = 4;
            LabelPassword.Text = "Password:";
            // 
            // LabelSQ
            // 
            LabelSQ.AutoSize = true;
            LabelSQ.Location = new Point(12, 241);
            LabelSQ.Name = "LabelSQ";
            LabelSQ.Size = new Size(304, 20);
            LabelSQ.TabIndex = 5;
            LabelSQ.Text = "Security Question, Whats your favouite color:";
            // 
            // FirstNameField
            // 
            FirstNameField.Location = new Point(322, 97);
            FirstNameField.Name = "FirstNameField";
            FirstNameField.Size = new Size(125, 27);
            FirstNameField.TabIndex = 6;
            // 
            // LastNameField
            // 
            LastNameField.Location = new Point(321, 137);
            LastNameField.Name = "LastNameField";
            LastNameField.Size = new Size(125, 27);
            LastNameField.TabIndex = 7;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(322, 178);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(125, 27);
            PasswordField.TabIndex = 8;
            // 
            // SQField
            // 
            SQField.Location = new Point(322, 238);
            SQField.Name = "SQField";
            SQField.Size = new Size(125, 27);
            SQField.TabIndex = 9;
            // 
            // EditAccountInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(SQField);
            Controls.Add(PasswordField);
            Controls.Add(LastNameField);
            Controls.Add(FirstNameField);
            Controls.Add(LabelSQ);
            Controls.Add(LabelPassword);
            Controls.Add(LabelLastName);
            Controls.Add(LabelFirstName);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Name = "EditAccountInfo";
            Text = "EditAccountInfo";
            ResumeLayout(false);
            PerformLayout();
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