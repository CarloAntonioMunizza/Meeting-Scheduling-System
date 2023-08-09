namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AdminUpdateBilling
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelUserSelect = new System.Windows.Forms.Label();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.LabelCCV = new System.Windows.Forms.Label();
            this.MaskedCardNumField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedCCVField = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click_1);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(525, 76);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(653, 54);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Update User\'s Billing Information";
            // 
            // LabelUserSelect
            // 
            this.LabelUserSelect.AutoSize = true;
            this.LabelUserSelect.Location = new System.Drawing.Point(155, 291);
            this.LabelUserSelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUserSelect.Name = "LabelUserSelect";
            this.LabelUserSelect.Size = new System.Drawing.Size(314, 41);
            this.LabelUserSelect.TabIndex = 4;
            this.LabelUserSelect.Text = "Select User to Update:";
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Location = new System.Drawing.Point(155, 338);
            this.EmailComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(316, 49);
            this.EmailComboBox.TabIndex = 5;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Location = new System.Drawing.Point(631, 291);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(402, 41);
            this.LabelCardNumber.TabIndex = 7;
            this.LabelCardNumber.Text = "Change User\'s Card Number:";
            // 
            // LabelCCV
            // 
            this.LabelCCV.AutoSize = true;
            this.LabelCCV.Location = new System.Drawing.Point(1269, 291);
            this.LabelCCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCCV.Name = "LabelCCV";
            this.LabelCCV.Size = new System.Drawing.Size(191, 41);
            this.LabelCCV.TabIndex = 8;
            this.LabelCCV.Text = "Change CCV:";
            // 
            // MaskedCardNumField
            // 
            this.MaskedCardNumField.Location = new System.Drawing.Point(631, 340);
            this.MaskedCardNumField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCardNumField.Mask = "0000-0000-0000-0000";
            this.MaskedCardNumField.Name = "MaskedCardNumField";
            this.MaskedCardNumField.Size = new System.Drawing.Size(438, 47);
            this.MaskedCardNumField.TabIndex = 9;
            // 
            // MaskedCCVField
            // 
            this.MaskedCCVField.Location = new System.Drawing.Point(1303, 338);
            this.MaskedCCVField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCCVField.Mask = "000";
            this.MaskedCCVField.Name = "MaskedCCVField";
            this.MaskedCCVField.Size = new System.Drawing.Size(136, 47);
            this.MaskedCCVField.TabIndex = 10;
            // 
            // AdminUpdateBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.MaskedCCVField);
            this.Controls.Add(this.MaskedCardNumField);
            this.Controls.Add(this.LabelCCV);
            this.Controls.Add(this.LabelCardNumber);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.LabelUserSelect);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminUpdateBilling";
            this.Text = "AdminUpdateBilling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label LabelTitle;
        private Label LabelUserSelect;
        private ComboBox EmailComboBox;
        private Label LabelCardNumber;
        private Label LabelCCV;
        private MaskedTextBox MaskedCardNumField;
        private MaskedTextBox MaskedCCVField;
    }
}