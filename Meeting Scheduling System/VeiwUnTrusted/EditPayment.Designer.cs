namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class EditPayment
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
            this.LabelNewCard = new System.Windows.Forms.Label();
            this.LabelNewCCV = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.MaskedCardNumField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedCCVField = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LabelNewCard
            // 
            this.LabelNewCard.AutoSize = true;
            this.LabelNewCard.Location = new System.Drawing.Point(344, 338);
            this.LabelNewCard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelNewCard.Name = "LabelNewCard";
            this.LabelNewCard.Size = new System.Drawing.Size(348, 41);
            this.LabelNewCard.TabIndex = 1;
            this.LabelNewCard.Text = "Enter New Card Number:";
            // 
            // LabelNewCCV
            // 
            this.LabelNewCCV.AutoSize = true;
            this.LabelNewCCV.Location = new System.Drawing.Point(476, 502);
            this.LabelNewCCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelNewCCV.Name = "LabelNewCCV";
            this.LabelNewCCV.Size = new System.Drawing.Size(225, 41);
            this.LabelNewCCV.TabIndex = 2;
            this.LabelNewCCV.Text = "Enter New CCV:";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 5;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(476, 66);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(652, 54);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Enter your New Card Information";
            // 
            // MaskedCardNumField
            // 
            this.MaskedCardNumField.Location = new System.Drawing.Point(725, 332);
            this.MaskedCardNumField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCardNumField.Mask = "0000-0000-0000-0000";
            this.MaskedCardNumField.Name = "MaskedCardNumField";
            this.MaskedCardNumField.Size = new System.Drawing.Size(304, 47);
            this.MaskedCardNumField.TabIndex = 7;
            // 
            // MaskedCCVField
            // 
            this.MaskedCCVField.Location = new System.Drawing.Point(725, 496);
            this.MaskedCCVField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCCVField.Mask = "000";
            this.MaskedCCVField.Name = "MaskedCCVField";
            this.MaskedCCVField.Size = new System.Drawing.Size(102, 47);
            this.MaskedCCVField.TabIndex = 8;
            // 
            // EditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.MaskedCCVField);
            this.Controls.Add(this.MaskedCardNumField);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelNewCCV);
            this.Controls.Add(this.LabelNewCard);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditPayment";
            this.Text = "EditPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelNewCard;
        private Label LabelNewCCV;
        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label LabelTitle;
        private MaskedTextBox MaskedCardNumField;
        private MaskedTextBox MaskedCCVField;
    }
}