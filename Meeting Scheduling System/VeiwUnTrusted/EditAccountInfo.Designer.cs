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
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(234, 103);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(83, 20);
            LabelFirstName.TabIndex = 2;
            LabelFirstName.Text = "First Name:";
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
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(243, 189);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(73, 20);
            LabelPassword.TabIndex = 4;
            LabelPassword.Text = "Password:";
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
            // MaskedFirstNameField
            // 
            MaskedFirstNameField.Location = new Point(322, 100);
            MaskedFirstNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            MaskedFirstNameField.Name = "MaskedFirstNameField";
            MaskedFirstNameField.Size = new Size(125, 27);
            MaskedFirstNameField.TabIndex = 6;
            // 
            // MaskedLastNameField
            // 
            MaskedLastNameField.Location = new Point(322, 137);
            MaskedLastNameField.Mask = "LLLLLLLLLLLLLLLLLLLL";
            MaskedLastNameField.Name = "MaskedLastNameField";
            MaskedLastNameField.Size = new Size(125, 27);
            MaskedLastNameField.TabIndex = 7;
            // 
            // MaskedSQField
            // 
            MaskedSQField.Location = new Point(322, 238);
            MaskedSQField.Mask = "LLLLLLLLLLLLLLL";
            MaskedSQField.Name = "MaskedSQField";
            MaskedSQField.Size = new Size(125, 27);
            MaskedSQField.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 186);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '#';
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // EditAccountInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
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