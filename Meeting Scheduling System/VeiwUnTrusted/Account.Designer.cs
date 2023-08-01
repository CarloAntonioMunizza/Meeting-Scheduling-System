namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class Account
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
            ButtonEditInfo = new Button();
            ButtonAddPayment = new Button();
            ButtonAdminBilling = new Button();
            ButtonBack = new Button();
            ButtonAddAdmin = new Button();
            LableTitle = new Label();
            SuspendLayout();
            // 
            // ButtonEditInfo
            // 
            ButtonEditInfo.Location = new Point(338, 205);
            ButtonEditInfo.Name = "ButtonEditInfo";
            ButtonEditInfo.Size = new Size(108, 47);
            ButtonEditInfo.TabIndex = 0;
            ButtonEditInfo.Text = "Edit Info";
            ButtonEditInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPayment
            // 
            ButtonAddPayment.Location = new Point(338, 109);
            ButtonAddPayment.Name = "ButtonAddPayment";
            ButtonAddPayment.Size = new Size(108, 47);
            ButtonAddPayment.TabIndex = 1;
            ButtonAddPayment.Text = "Add Payment";
            ButtonAddPayment.UseVisualStyleBackColor = true;
            // 
            // ButtonAdminBilling
            // 
            ButtonAdminBilling.Location = new Point(194, 318);
            ButtonAdminBilling.Name = "ButtonAdminBilling";
            ButtonAdminBilling.Size = new Size(132, 51);
            ButtonAdminBilling.TabIndex = 2;
            ButtonAdminBilling.Text = "Admin Update Client Info";
            ButtonAdminBilling.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 3;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonAddAdmin
            // 
            ButtonAddAdmin.Location = new Point(458, 318);
            ButtonAddAdmin.Name = "ButtonAddAdmin";
            ButtonAddAdmin.Size = new Size(132, 51);
            ButtonAddAdmin.TabIndex = 4;
            ButtonAddAdmin.Text = "Create Admin Accounts";
            ButtonAddAdmin.UseVisualStyleBackColor = true;
            // 
            // LableTitle
            // 
            LableTitle.AutoSize = true;
            LableTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LableTitle.Location = new Point(314, 30);
            LableTitle.Name = "LableTitle";
            LableTitle.Size = new Size(170, 28);
            LableTitle.TabIndex = 5;
            LableTitle.Text = "Account Options";
            LableTitle.Click += LableTitle_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LableTitle);
            Controls.Add(ButtonAddAdmin);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonAdminBilling);
            Controls.Add(ButtonAddPayment);
            Controls.Add(ButtonEditInfo);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEditInfo;
        private Button ButtonAddPayment;
        private Button ButtonAdminBilling;
        private Button ButtonBack;
        private Button ButtonAddAdmin;
        private Label LableTitle;
    }
}