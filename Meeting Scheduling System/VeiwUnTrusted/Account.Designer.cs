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
            ButtonBack = new Button();
            LableTitle = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ButtonEditPaymentInfo
            // 
            ButtonEditPaymentInfo.Location = new Point(447, 108);
            ButtonEditPaymentInfo.Name = "ButtonEditPaymentInfo";
            ButtonEditPaymentInfo.Size = new Size(146, 72);
            ButtonEditPaymentInfo.TabIndex = 0;
            ButtonEditPaymentInfo.Text = "Edit Payment Info";
            ButtonEditPaymentInfo.UseVisualStyleBackColor = true;
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
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 3;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
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
            // button1
            // 
            button1.Location = new Point(212, 108);
            button1.Name = "button1";
            button1.Size = new Size(146, 72);
            button1.TabIndex = 6;
            button1.Text = "Edit Account Info";
            button1.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LableTitle);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonAddPayment);
            Controls.Add(ButtonEditPaymentInfo);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEditPaymentInfo;
        private Button ButtonAddPayment;
        private Button ButtonBack;
        private Label LableTitle;
        private Button button1;
    }
}