namespace Meeting_Scheduling_System.Veiw_UnTrusted
{
    partial class Login
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
            EmailField = new TextBox();
            LabelBuisness = new Label();
            LabelPassword = new Label();
            SQField = new TextBox();
            LabelSQ = new Label();
            LabelLoginTitle = new Label();
            ButtonSubmit = new Button();
            ButtonBack = new Button();
            MaskedPasswordField = new MaskedTextBox();
            SuspendLayout();
            // 
            // EmailField
            // 
            EmailField.Location = new Point(382, 175);
            EmailField.MaxLength = 15;
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(136, 27);
            EmailField.TabIndex = 0;
            EmailField.TextChanged += EmailField_TextChanged;
            // 
            // LabelBuisness
            // 
            LabelBuisness.AutoSize = true;
            LabelBuisness.Location = new Point(268, 175);
            LabelBuisness.Name = "LabelBuisness";
            LabelBuisness.Size = new Size(108, 20);
            LabelBuisness.TabIndex = 1;
            LabelBuisness.Text = "Buisness Email:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(303, 268);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(73, 20);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password:";
            // 
            // SQField
            // 
            SQField.Location = new Point(382, 354);
            SQField.Name = "SQField";
            SQField.Size = new Size(125, 27);
            SQField.TabIndex = 4;
            // 
            // LabelSQ
            // 
            LabelSQ.AutoSize = true;
            LabelSQ.Location = new Point(71, 357);
            LabelSQ.Name = "LabelSQ";
            LabelSQ.Size = new Size(305, 20);
            LabelSQ.TabIndex = 5;
            LabelSQ.Text = "Security Question, Whats your favorite color?";
            // 
            // LabelLoginTitle
            // 
            LabelLoginTitle.AutoSize = true;
            LabelLoginTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLoginTitle.Location = new Point(254, 39);
            LabelLoginTitle.Name = "LabelLoginTitle";
            LabelLoginTitle.Size = new Size(338, 28);
            LabelLoginTitle.TabIndex = 6;
            LabelLoginTitle.Text = "Please enter your login info below";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(732, 457);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 457);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 8;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // MaskedPasswordField
            // 
            MaskedPasswordField.Location = new Point(382, 265);
            MaskedPasswordField.Name = "MaskedPasswordField";
            MaskedPasswordField.Size = new Size(125, 27);
            MaskedPasswordField.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 498);
            Controls.Add(MaskedPasswordField);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelLoginTitle);
            Controls.Add(LabelSQ);
            Controls.Add(SQField);
            Controls.Add(LabelPassword);
            Controls.Add(LabelBuisness);
            Controls.Add(EmailField);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailField;
        private Label LabelBuisness;
        private Label LabelPassword;
        private TextBox SQField;
        private Label LabelSQ;
        private Label LabelLoginTitle;
        private Button ButtonSubmit;
        private Button ButtonBack;
        private MaskedTextBox MaskedPasswordField;
    }
}