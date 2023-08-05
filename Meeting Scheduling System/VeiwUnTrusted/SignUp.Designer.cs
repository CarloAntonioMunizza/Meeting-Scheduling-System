namespace Meeting_Scheduling_System.Veiw_UnTrusted
{
    partial class SignUp
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
            FirstNameField = new TextBox();
            LastNameField = new TextBox();
            EmailField = new TextBox();
            SQField = new TextBox();
            labelTitle = new Label();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            LabelBuisness = new Label();
            LabelPassword = new Label();
            LabelConstraint1 = new Label();
            LabelConstraint2 = new Label();
            LabelConstraint3 = new Label();
            LabelConstraint4 = new Label();
            LabelConfirmPassword = new Label();
            LabelSQ = new Label();
            label1 = new Label();
            ButtonSubmit = new Button();
            ButtonBack = new Button();
            MaskedPasswordField = new MaskedTextBox();
            MaskedPasswordConfirmField = new MaskedTextBox();
            SuspendLayout();
            // 
            // FirstNameField
            // 
            FirstNameField.Location = new Point(366, 80);
            FirstNameField.Name = "FirstNameField";
            FirstNameField.Size = new Size(125, 27);
            FirstNameField.TabIndex = 0;
            // 
            // LastNameField
            // 
            LastNameField.Location = new Point(366, 113);
            LastNameField.Name = "LastNameField";
            LastNameField.Size = new Size(125, 27);
            LastNameField.TabIndex = 1;
            // 
            // EmailField
            // 
            EmailField.Location = new Point(366, 146);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(135, 27);
            EmailField.TabIndex = 2;
            EmailField.Text = "xyz1234@pss.com";
            // 
            // SQField
            // 
            SQField.Location = new Point(366, 329);
            SQField.Name = "SQField";
            SQField.Size = new Size(125, 27);
            SQField.TabIndex = 5;
            SQField.TextChanged += textBox6_TextChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(229, 37);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(370, 28);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Enter your buisness credentials below";
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(277, 83);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(83, 20);
            LabelFirstName.TabIndex = 7;
            LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(281, 116);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(82, 20);
            LabelLastName.TabIndex = 8;
            LabelLastName.Text = "Last Name:";
            // 
            // LabelBuisness
            // 
            LabelBuisness.AutoSize = true;
            LabelBuisness.Location = new Point(255, 149);
            LabelBuisness.Name = "LabelBuisness";
            LabelBuisness.Size = new Size(108, 20);
            LabelBuisness.TabIndex = 9;
            LabelBuisness.Text = "Buisness Email:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(287, 182);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(73, 20);
            LabelPassword.TabIndex = 10;
            LabelPassword.Text = "Password:";
            // 
            // LabelConstraint1
            // 
            LabelConstraint1.AutoSize = true;
            LabelConstraint1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConstraint1.Location = new Point(206, 209);
            LabelConstraint1.Name = "LabelConstraint1";
            LabelConstraint1.Size = new Size(157, 17);
            LabelConstraint1.TabIndex = 11;
            LabelConstraint1.Text = "Atleast 1 uppercase letter";
            // 
            // LabelConstraint2
            // 
            LabelConstraint2.AutoSize = true;
            LabelConstraint2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConstraint2.Location = new Point(209, 226);
            LabelConstraint2.Name = "LabelConstraint2";
            LabelConstraint2.Size = new Size(154, 17);
            LabelConstraint2.TabIndex = 12;
            LabelConstraint2.Text = "Atleast 1 lowercase letter";
            // 
            // LabelConstraint3
            // 
            LabelConstraint3.AutoSize = true;
            LabelConstraint3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConstraint3.Location = new Point(256, 243);
            LabelConstraint3.Name = "LabelConstraint3";
            LabelConstraint3.Size = new Size(107, 17);
            LabelConstraint3.TabIndex = 13;
            LabelConstraint3.Text = "Atleast 1 number";
            // 
            // LabelConstraint4
            // 
            LabelConstraint4.AutoSize = true;
            LabelConstraint4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConstraint4.Location = new Point(198, 260);
            LabelConstraint4.Name = "LabelConstraint4";
            LabelConstraint4.Size = new Size(165, 17);
            LabelConstraint4.TabIndex = 14;
            LabelConstraint4.Text = "Between 6 to 15 characters";
            // 
            // LabelConfirmPassword
            // 
            LabelConfirmPassword.AutoSize = true;
            LabelConfirmPassword.Location = new Point(230, 284);
            LabelConfirmPassword.Name = "LabelConfirmPassword";
            LabelConfirmPassword.Size = new Size(130, 20);
            LabelConfirmPassword.TabIndex = 15;
            LabelConfirmPassword.Text = "Confirm Password:";
            // 
            // LabelSQ
            // 
            LabelSQ.AutoSize = true;
            LabelSQ.Location = new Point(50, 332);
            LabelSQ.Name = "LabelSQ";
            LabelSQ.Size = new Size(313, 20);
            LabelSQ.TabIndex = 16;
            LabelSQ.Text = "Security Question, What is your favorite color?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 390);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 17;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(691, 458);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 18;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 458);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 19;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // MaskedPasswordField
            // 
            MaskedPasswordField.Location = new Point(366, 182);
            MaskedPasswordField.Name = "MaskedPasswordField";
            MaskedPasswordField.Size = new Size(125, 27);
            MaskedPasswordField.TabIndex = 20;
            // 
            // MaskedPasswordConfirmField
            // 
            MaskedPasswordConfirmField.Location = new Point(366, 281);
            MaskedPasswordConfirmField.Name = "MaskedPasswordConfirmField";
            MaskedPasswordConfirmField.Size = new Size(125, 27);
            MaskedPasswordConfirmField.TabIndex = 21;
            MaskedPasswordConfirmField.MaskInputRejected += MaskedPasswordConfirmField_MaskInputRejected;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 499);
            Controls.Add(MaskedPasswordConfirmField);
            Controls.Add(MaskedPasswordField);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonSubmit);
            Controls.Add(label1);
            Controls.Add(LabelSQ);
            Controls.Add(LabelConfirmPassword);
            Controls.Add(LabelConstraint4);
            Controls.Add(LabelConstraint3);
            Controls.Add(LabelConstraint2);
            Controls.Add(LabelConstraint1);
            Controls.Add(LabelPassword);
            Controls.Add(LabelBuisness);
            Controls.Add(LabelLastName);
            Controls.Add(LabelFirstName);
            Controls.Add(labelTitle);
            Controls.Add(SQField);
            Controls.Add(EmailField);
            Controls.Add(LastNameField);
            Controls.Add(FirstNameField);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameField;
        private TextBox LastNameField;
        private TextBox EmailField;
        private TextBox SQField;
        private Label labelTitle;
        private Label LabelFirstName;
        private Label LabelLastName;
        private Label LabelBuisness;
        private Label LabelPassword;
        private Label LabelConstraint1;
        private Label LabelConstraint2;
        private Label LabelConstraint3;
        private Label LabelConstraint4;
        private Label LabelConfirmPassword;
        private Label LabelSQ;
        private Label label1;
        private Button ButtonSubmit;
        private Button ButtonBack;
        private MaskedTextBox MaskedPasswordField;
        private MaskedTextBox MaskedPasswordConfirmField;
    }
}