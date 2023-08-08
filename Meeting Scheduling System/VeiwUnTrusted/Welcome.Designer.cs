namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class Welcome
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelSignUp = new System.Windows.Forms.Label();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(353, 152);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(94, 29);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Location = new System.Drawing.Point(750, 303);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(200, 59);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonSignUp
            // 
            ButtonSignUp.Location = new Point(353, 247);
            ButtonSignUp.Name = "ButtonSignUp";
            ButtonSignUp.Size = new Size(94, 29);
            ButtonSignUp.TabIndex = 1;
            ButtonSignUp.Text = "SignUp";
            ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Location = new System.Drawing.Point(750, 496);
            this.ButtonSignUp.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(200, 59);
            this.ButtonSignUp.TabIndex = 1;
            this.ButtonSignUp.Text = "SignUp";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(397, 92);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(855, 54);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Welcome to the Meeting Scheduling System";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(397, 312);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(323, 41);
            this.LabelLogin.TabIndex = 3;
            this.LabelLogin.Text = "If you have an account:";
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.AutoSize = true;
            this.LabelSignUp.Location = new System.Drawing.Point(444, 515);
            this.LabelSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(279, 41);
            this.LabelSignUp.TabIndex = 4;
            this.LabelSignUp.Text = "If you are new here:";
            // 
            // ButtonQuit
            // 
            ButtonQuit.Location = new Point(12, 409);
            ButtonQuit.Name = "ButtonQuit";
            ButtonQuit.Size = new Size(94, 29);
            ButtonQuit.TabIndex = 5;
            ButtonQuit.Text = "Quit";
            ButtonQuit.UseVisualStyleBackColor = true;
            ButtonQuit.Click += ButtonQuit_Click;
            this.ButtonQuit.Location = new System.Drawing.Point(26, 838);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(200, 59);
            this.ButtonQuit.TabIndex = 5;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.LabelSignUp);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogin);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonLogin;
        private Button ButtonSignUp;
        private Label LabelTitle;
        private Label LabelLogin;
        private Label LabelSignUp;
        private Button ButtonQuit;
    }
}