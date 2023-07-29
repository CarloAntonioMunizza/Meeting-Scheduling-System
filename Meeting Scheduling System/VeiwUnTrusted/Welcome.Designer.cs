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
            SuspendLayout();
            // 
            // LabelWelcome
            // 
            LabelWelcome.AutoSize = true;
            LabelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelWelcome.Location = new Point(163, 73);
            LabelWelcome.Margin = new Padding(4, 0, 4, 0);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.Size = new Size(504, 28);
            LabelWelcome.TabIndex = 0;
            LabelWelcome.Text = "Welcome to PennStateSoft's Meeting Scheduling System";
            LabelWelcome.Click += label1_Click;
            // 
            // ButtonLogIn
            // 
            ButtonLogIn.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogIn.Location = new Point(377, 223);
            ButtonLogIn.Name = "ButtonLogIn";
            ButtonLogIn.Size = new Size(94, 35);
            ButtonLogIn.TabIndex = 1;
            ButtonLogIn.Text = "Login";
            ButtonLogIn.UseVisualStyleBackColor = true;
            ButtonLogIn.Click += ButtonLogIn_Click;
            // 
            // ButtonSignUp
            // 
            ButtonSignUp.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSignUp.Location = new Point(377, 351);
            ButtonSignUp.Name = "ButtonSignUp";
            ButtonSignUp.Size = new Size(94, 35);
            ButtonSignUp.TabIndex = 2;
            ButtonSignUp.Text = "Sign Up";
            ButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // LabelLogIn
            // 
            LabelLogIn.AutoSize = true;
            LabelLogIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLogIn.Location = new Point(123, 229);
            LabelLogIn.Name = "LabelLogIn";
            LabelLogIn.Size = new Size(248, 23);
            LabelLogIn.TabIndex = 3;
            LabelLogIn.Text = "If you already have an account:";
            LabelLogIn.Click += label1_Click_1;
            // 
            // LabelSignUp
            // 
            LabelSignUp.AutoSize = true;
            LabelSignUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSignUp.Location = new Point(99, 357);
            LabelSignUp.Name = "LabelSignUp";
            LabelSignUp.Size = new Size(272, 23);
            LabelSignUp.TabIndex = 4;
            LabelSignUp.Text = "If you do not have an account yet:";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 503);
            Controls.Add(LabelSignUp);
            Controls.Add(LabelLogIn);
            Controls.Add(ButtonSignUp);
            Controls.Add(ButtonLogIn);
            Controls.Add(LabelWelcome);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
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
    }
}