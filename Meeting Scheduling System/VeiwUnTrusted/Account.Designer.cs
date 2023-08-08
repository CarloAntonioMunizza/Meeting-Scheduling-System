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
            ButtonEditPaymentInfo = new Button();
            ButtonAddPayment = new Button();
            LableTitle = new Label();
            ButtonEditAccountInfo = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ButtonEditPaymentInfo
            // 
            ButtonEditPaymentInfo.Location = new Point(197, 117);
            ButtonEditPaymentInfo.Name = "ButtonEditPaymentInfo";
            ButtonEditPaymentInfo.Size = new Size(146, 72);
            ButtonEditPaymentInfo.TabIndex = 0;
            ButtonEditPaymentInfo.Text = "Edit Payment Info";
            ButtonEditPaymentInfo.UseVisualStyleBackColor = true;
            ButtonEditPaymentInfo.Click += ButtonEditInfo_Click;
            // 
            // ButtonAddPayment
            // 
            ButtonAddPayment.Location = new Point(324, 229);
            ButtonAddPayment.Name = "ButtonAddPayment";
            ButtonAddPayment.Size = new Size(146, 73);
            ButtonAddPayment.TabIndex = 1;
            ButtonAddPayment.Text = "Add Payment";
            ButtonAddPayment.UseVisualStyleBackColor = true;
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
            // 
            // ButtonEditAccountInfo
            // 
            ButtonEditAccountInfo.Location = new Point(457, 117);
            ButtonEditAccountInfo.Name = "ButtonEditAccountInfo";
            ButtonEditAccountInfo.Size = new Size(146, 72);
            ButtonEditAccountInfo.TabIndex = 6;
            ButtonEditAccountInfo.Text = "Edit Account Info";
            ButtonEditAccountInfo.UseVisualStyleBackColor = true;
            ButtonEditAccountInfo.Click += ButtonEditAccountInfo_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 409);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(ButtonEditAccountInfo);
            Controls.Add(LableTitle);
            Controls.Add(ButtonAddPayment);
            Controls.Add(ButtonEditPaymentInfo);
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEditPaymentInfo;
        private Button ButtonAddPayment;
        private Label LableTitle;
        private Button ButtonEditAccountInfo;
        private Button BackButton;
    }
}