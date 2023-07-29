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
            SuspendLayout();
            // 
            // EmailField
            // 
            EmailField.Location = new Point(336, 126);
            EmailField.MaxLength = 15;
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(136, 27);
            EmailField.TabIndex = 0;
            EmailField.Text = "xyz1234@pss.com";
            EmailField.TextChanged += EmailField_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmailField);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailField;
    }
}