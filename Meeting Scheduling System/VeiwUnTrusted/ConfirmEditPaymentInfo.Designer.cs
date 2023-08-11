namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class ConfirmEditPaymentInfo
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
            ButtonSubmit = new Button();
            LabelIncorrectPassword = new Label();
            SuspendLayout();
            // 
            // MaskedConfirmPasswordField
            // 
            MaskedConfirmPasswordField.Location = new Point(334, 141);
            MaskedConfirmPasswordField.Name = "MaskedConfirmPasswordField";
            MaskedConfirmPasswordField.PasswordChar = '#';
            MaskedConfirmPasswordField.Size = new Size(125, 27);
            MaskedConfirmPasswordField.TabIndex = 0;
            // 
            // LabelEnterPassword
            // 
            LabelEnterPassword.AutoSize = true;
            LabelEnterPassword.Location = new Point(182, 144);
            LabelEnterPassword.Name = "LabelEnterPassword";
            LabelEnterPassword.Size = new Size(146, 20);
            LabelEnterPassword.TabIndex = 1;
            LabelEnterPassword.Text = "Enter your password:";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(354, 356);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 2;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // LabelIncorrectPassword
            // 
            LabelIncorrectPassword.AutoSize = true;
            LabelIncorrectPassword.Location = new Point(272, 184);
            LabelIncorrectPassword.Name = "LabelIncorrectPassword";
            LabelIncorrectPassword.Size = new Size(231, 20);
            LabelIncorrectPassword.TabIndex = 3;
            LabelIncorrectPassword.Text = "The password entered is incorrect";
            LabelIncorrectPassword.Visible = false;
            // 
            // ConfirmEditPaymentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelIncorrectPassword);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelEnterPassword);
            Controls.Add(MaskedConfirmPasswordField);
            Name = "ConfirmEditPaymentInfo";
            Text = "ConfirmInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaskedConfirmPasswordField;
        private Label LabelEnterPassword;
        private Button ButtonSubmit;
        private Label LabelIncorrectPassword;
    }
}