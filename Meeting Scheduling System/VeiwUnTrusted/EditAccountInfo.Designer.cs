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
            MaskedFirstNameField = new MaskedTextBox();
            MaskedLastNameField = new MaskedTextBox();
            MaskedSQField = new MaskedTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(15, 481);
            ButtonBack.Margin = new Padding(6);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(93, 29);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(766, 481);
            ButtonSubmit.Margin = new Padding(6);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(93, 29);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click_1;
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(319, 151);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(83, 20);
            LabelFirstName.TabIndex = 2;
            LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(317, 205);
            LabelLastName.Margin = new Padding(6, 0, 6, 0);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(82, 20);
            LabelLastName.TabIndex = 3;
            LabelLastName.Text = "Last Name:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(326, 262);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(73, 20);
            LabelPassword.TabIndex = 4;
            LabelPassword.Text = "Password:";
            // 
            // LabelSQ
            // 
            LabelSQ.AutoSize = true;
            LabelSQ.Location = new Point(95, 323);
            LabelSQ.Margin = new Padding(6, 0, 6, 0);
            LabelSQ.Name = "LabelSQ";
            LabelSQ.Size = new Size(304, 20);
            LabelSQ.TabIndex = 5;
            LabelSQ.Text = "Security Question, Whats your favouite color:";
            // 
            // MaskedFirstNameField
            // 
            MaskedFirstNameField.Location = new Point(408, 144);
            MaskedFirstNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            MaskedFirstNameField.Name = "MaskedFirstNameField";
            MaskedFirstNameField.Size = new Size(125, 27);
            MaskedFirstNameField.TabIndex = 6;
            // 
            // MaskedLastNameField
            // 
            MaskedLastNameField.Location = new Point(408, 202);
            MaskedLastNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            MaskedLastNameField.Name = "MaskedLastNameField";
            MaskedLastNameField.Size = new Size(125, 27);
            MaskedLastNameField.TabIndex = 7;
            // 
            // MaskedSQField
            // 
            MaskedSQField.Location = new Point(408, 316);
            MaskedSQField.Mask = "LLLLLLLLLLLLLLL";
            MaskedSQField.Name = "MaskedSQField";
            MaskedSQField.Size = new Size(125, 27);
            MaskedSQField.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 259);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '#';
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // EditAccountInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 525);
            Controls.Add(textBox1);
            Controls.Add(MaskedSQField);
            Controls.Add(MaskedLastNameField);
            Controls.Add(MaskedFirstNameField);
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
        private MaskedTextBox MaskedFirstNameField;
        private MaskedTextBox MaskedLastNameField;
        private MaskedTextBox MaskedSQField;
        private TextBox textBox1;
    }
}