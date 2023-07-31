namespace Meeting_Scheduling_System.Veiw_UnTrusted
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
            LabelWelcome = new Label();
            ButtonLogIn = new Button();
            ButtonSignUp = new Button();
            LabelLogIn = new Label();
            LabelSignUp = new Label();
            ButtonQuit = new Button();
            SuspendLayout();
            // 
            // LabelWelcome
            // 
            LabelWelcome.AutoSize = true;
            LabelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelWelcome.Location = new Point(163, 73);
            LabelWelcome.Margin = new Padding(4, 0, 4, 0);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.Size = new Size(548, 28);
            LabelWelcome.TabIndex = 0;
            LabelWelcome.Text = "Welcome to PennStateSoft's Meeting Scheduling System";
            LabelWelcome.Click += label1_Click;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogIn.Location = new System.Drawing.Point(690, 266);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(161, 58);
            this.ButtonLogIn.TabIndex = 1;
            this.ButtonLogIn.Text = "Login";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignUp.Location = new System.Drawing.Point(718, 394);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(133, 55);
            this.ButtonSignUp.TabIndex = 2;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // LabelLogIn
            // 
            this.LabelLogIn.AutoSize = true;
            this.LabelLogIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLogIn.Location = new System.Drawing.Point(172, 270);
            this.LabelLogIn.Name = "LabelLogIn";
            this.LabelLogIn.Size = new System.Drawing.Size(480, 46);
            this.LabelLogIn.TabIndex = 3;
            this.LabelLogIn.Text = "If you already have an account:";
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.AutoSize = true;
            this.LabelSignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSignUp.Location = new System.Drawing.Point(172, 394);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(527, 46);
            this.LabelSignUp.TabIndex = 4;
            this.LabelSignUp.Text = "If you do not have an account yet:";
            // 
            // ButtonQuit
            // 
            ButtonQuit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonQuit.Location = new Point(12, 462);
            ButtonQuit.Name = "ButtonQuit";
            ButtonQuit.Size = new Size(94, 29);
            ButtonQuit.TabIndex = 5;
            ButtonQuit.Text = "Quit";
            ButtonQuit.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 503);
            Controls.Add(ButtonQuit);
            Controls.Add(LabelSignUp);
            Controls.Add(LabelLogIn);
            Controls.Add(ButtonSignUp);
            Controls.Add(ButtonLogIn);
            Controls.Add(LabelWelcome);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelWelcome;
        private Button ButtonLogIn;
        private Button ButtonSignUp;
        private Label LabelLogIn;
        private Label LabelSignUp;
        private Button ButtonQuit;
    }
}