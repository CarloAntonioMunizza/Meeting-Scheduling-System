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
            this.EmailField = new System.Windows.Forms.TextBox();
            this.LabelBuisness = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.SQField = new System.Windows.Forms.TextBox();
            this.LabelSQ = new System.Windows.Forms.Label();
            this.LabelLoginTitle = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.MaskedPasswordField = new System.Windows.Forms.MaskedTextBox();
            this.InvalidCredentials = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(812, 359);
            this.EmailField.Margin = new System.Windows.Forms.Padding(6);
            this.EmailField.MaxLength = 15;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(284, 47);
            this.EmailField.TabIndex = 0;
            // 
            // LabelBuisness
            // 
            this.LabelBuisness.AutoSize = true;
            this.LabelBuisness.Location = new System.Drawing.Point(570, 359);
            this.LabelBuisness.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelBuisness.Name = "LabelBuisness";
            this.LabelBuisness.Size = new System.Drawing.Size(216, 41);
            this.LabelBuisness.TabIndex = 1;
            this.LabelBuisness.Text = "Buisness Email:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(644, 549);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(150, 41);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password:";
            // 
            // SQField
            // 
            this.SQField.Location = new System.Drawing.Point(812, 726);
            this.SQField.Margin = new System.Windows.Forms.Padding(6);
            this.SQField.Name = "SQField";
            this.SQField.Size = new System.Drawing.Size(261, 47);
            this.SQField.TabIndex = 4;
            // 
            // LabelSQ
            // 
            this.LabelSQ.AutoSize = true;
            this.LabelSQ.Location = new System.Drawing.Point(151, 732);
            this.LabelSQ.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSQ.Name = "LabelSQ";
            this.LabelSQ.Size = new System.Drawing.Size(613, 41);
            this.LabelSQ.TabIndex = 5;
            this.LabelSQ.Text = "Security Question, Whats your favorite color?";
            // 
            // LabelLoginTitle
            // 
            this.LabelLoginTitle.AutoSize = true;
            this.LabelLoginTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLoginTitle.Location = new System.Drawing.Point(540, 80);
            this.LabelLoginTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelLoginTitle.Name = "LabelLoginTitle";
            this.LabelLoginTitle.Size = new System.Drawing.Size(667, 54);
            this.LabelLoginTitle.TabIndex = 6;
            this.LabelLoginTitle.Text = "Please enter your login info below";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1556, 937);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 937);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // MaskedPasswordField
            // 
            this.MaskedPasswordField.Location = new System.Drawing.Point(812, 543);
            this.MaskedPasswordField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedPasswordField.Name = "MaskedPasswordField";
            this.MaskedPasswordField.PasswordChar = '*';
            this.MaskedPasswordField.Size = new System.Drawing.Size(261, 47);
            this.MaskedPasswordField.TabIndex = 9;
            // 
            // InvalidCredentials
            // 
            this.InvalidCredentials.Location = new System.Drawing.Point(1215, 468);
            this.InvalidCredentials.Multiline = true;
            this.InvalidCredentials.Name = "InvalidCredentials";
            this.InvalidCredentials.ReadOnly = true;
            this.InvalidCredentials.Size = new System.Drawing.Size(308, 161);
            this.InvalidCredentials.TabIndex = 10;
            this.InvalidCredentials.Text = "Invalid credentials.\r\nPlease try again.";
            this.InvalidCredentials.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1021);
            this.Controls.Add(this.InvalidCredentials);
            this.Controls.Add(this.MaskedPasswordField);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelLoginTitle);
            this.Controls.Add(this.LabelSQ);
            this.Controls.Add(this.SQField);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelBuisness);
            this.Controls.Add(this.EmailField);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox InvalidCredentials;
    }
}