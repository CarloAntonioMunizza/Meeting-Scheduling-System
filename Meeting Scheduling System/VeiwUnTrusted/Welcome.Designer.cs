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
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.LabelLogIn = new System.Windows.Forms.Label();
            this.LabelSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.AutoSize = true;
            this.LabelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelWelcome.Location = new System.Drawing.Point(163, 73);
            this.LabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(1022, 54);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "Welcome to PennStateSoft\'s Meeting Scheduling System";
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
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 773);
            this.Controls.Add(this.LabelSignUp);
            this.Controls.Add(this.LabelLogIn);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.LabelWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelWelcome;
        private Button ButtonLogIn;
        private Button ButtonSignUp;
        private Label LabelLogIn;
        private Label LabelSignUp;
    }
}