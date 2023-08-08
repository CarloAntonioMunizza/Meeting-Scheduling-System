namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class ConfirmInfo
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
            MaskedConfirmPasswordField = new TextBox();
            LabelEnterPassword = new Label();
            SuspendLayout();
            // 
            // MaskedConfirmPasswordField
            // 
            MaskedConfirmPasswordField.Location = new Point(230, 137);
            MaskedConfirmPasswordField.Name = "MaskedConfirmPasswordField";
            MaskedConfirmPasswordField.Size = new Size(125, 27);
            MaskedConfirmPasswordField.TabIndex = 0;
            // 
            // LabelEnterPassword
            // 
            LabelEnterPassword.AutoSize = true;
            LabelEnterPassword.Location = new Point(69, 144);
            LabelEnterPassword.Name = "LabelEnterPassword";
            LabelEnterPassword.Size = new Size(143, 20);
            LabelEnterPassword.TabIndex = 1;
            LabelEnterPassword.Text = "Enter your password";
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEnterPassword);
            Controls.Add(MaskedConfirmPasswordField);
            Name = "AddPayment";
            Text = "AddPayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaskedConfirmPasswordField;
        private Label LabelEnterPassword;
    }
}