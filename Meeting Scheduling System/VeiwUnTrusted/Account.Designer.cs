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
            this.ButtonEditInfo = new System.Windows.Forms.Button();
            this.ButtonAddPayment = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LableTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonEditInfo
            // 
            this.ButtonEditInfo.Location = new System.Drawing.Point(688, 217);
            this.ButtonEditInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonEditInfo.Name = "ButtonEditInfo";
            this.ButtonEditInfo.Size = new System.Drawing.Size(310, 148);
            this.ButtonEditInfo.TabIndex = 0;
            this.ButtonEditInfo.Text = "Edit Info";
            this.ButtonEditInfo.UseVisualStyleBackColor = true;
            this.ButtonEditInfo.Click += new System.EventHandler(this.ButtonEditInfo_Click);
            // 
            // ButtonAddPayment
            // 
            this.ButtonAddPayment.Location = new System.Drawing.Point(688, 469);
            this.ButtonAddPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAddPayment.Name = "ButtonAddPayment";
            this.ButtonAddPayment.Size = new System.Drawing.Size(310, 150);
            this.ButtonAddPayment.TabIndex = 1;
            this.ButtonAddPayment.Text = "Add Payment";
            this.ButtonAddPayment.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // LableTitle
            // 
            this.LableTitle.AutoSize = true;
            this.LableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LableTitle.Location = new System.Drawing.Point(667, 62);
            this.LableTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LableTitle.Name = "LableTitle";
            this.LableTitle.Size = new System.Drawing.Size(336, 54);
            this.LableTitle.TabIndex = 5;
            this.LableTitle.Text = "Account Options";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.LableTitle);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddPayment);
            this.Controls.Add(this.ButtonEditInfo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonEditInfo;
        private Button ButtonAddPayment;
        private Button ButtonBack;
        private Label LableTitle;
    }
}