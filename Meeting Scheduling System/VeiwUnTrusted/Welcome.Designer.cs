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
            ButtonLogin = new Button();
            ButtonSignUp = new Button();
            LabelTitle = new Label();
            LabelLogin = new Label();
            LabelSignUp = new Label();
            ButtonQuit = new Button();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(353, 148);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(94, 29);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // ButtonSignUp
            // 
            ButtonSignUp.Location = new Point(353, 242);
            ButtonSignUp.Name = "ButtonSignUp";
            ButtonSignUp.Size = new Size(94, 29);
            ButtonSignUp.TabIndex = 1;
            ButtonSignUp.Text = "SignUp";
            ButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(187, 45);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(431, 28);
            LabelTitle.TabIndex = 2;
            LabelTitle.Text = "Welcome to the Meeting Scheduling System";
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Location = new Point(187, 152);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(160, 20);
            LabelLogin.TabIndex = 3;
            LabelLogin.Text = "If you have an account:";
            // 
            // LabelSignUp
            // 
            LabelSignUp.AutoSize = true;
            LabelSignUp.Location = new Point(209, 251);
            LabelSignUp.Name = "LabelSignUp";
            LabelSignUp.Size = new Size(138, 20);
            LabelSignUp.TabIndex = 4;
            LabelSignUp.Text = "If you are new here:";
            // 
            // ButtonQuit
            // 
            ButtonQuit.Location = new Point(12, 409);
            ButtonQuit.Name = "ButtonQuit";
            ButtonQuit.Size = new Size(94, 29);
            ButtonQuit.TabIndex = 5;
            ButtonQuit.Text = "Quit";
            ButtonQuit.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonQuit);
            Controls.Add(LabelSignUp);
            Controls.Add(LabelLogin);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonSignUp);
            Controls.Add(ButtonLogin);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
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