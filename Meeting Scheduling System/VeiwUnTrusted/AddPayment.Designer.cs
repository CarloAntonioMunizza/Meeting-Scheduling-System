﻿namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AddPayment
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
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.LabelCCV = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.MaskedCardInfoField = new System.Windows.Forms.MaskedTextBox();
            this.MaskedCCVField = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Location = new System.Drawing.Point(357, 644);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(557, 41);
            this.LabelCardNumber.TabIndex = 0;
            this.LabelCardNumber.Text = "Enter your Card Number without dashes:";
            // 
            // LabelCCV
            // 
            this.LabelCCV.AutoSize = true;
            this.LabelCCV.Location = new System.Drawing.Point(839, 849);
            this.LabelCCV.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LabelCCV.Name = "LabelCCV";
            this.LabelCCV.Size = new System.Drawing.Size(342, 41);
            this.LabelCCV.TabIndex = 2;
            this.LabelCCV.Text = "Enter your CCV Number:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(1405, 172);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(407, 41);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Enter Card Information Below";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(55, 1718);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(425, 121);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(3134, 1718);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(425, 121);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // MaskedCardInfoField
            // 
            this.MaskedCardInfoField.Location = new System.Drawing.Point(765, 314);
            this.MaskedCardInfoField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCardInfoField.Mask = "0000-0000-0000-0000";
            this.MaskedCardInfoField.Name = "MaskedCardInfoField";
            this.MaskedCardInfoField.Size = new System.Drawing.Size(261, 47);
            this.MaskedCardInfoField.TabIndex = 7;
            // 
            // MaskedCCVField
            // 
            this.MaskedCCVField.Location = new System.Drawing.Point(765, 408);
            this.MaskedCCVField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaskedCCVField.Mask = "000";
            this.MaskedCCVField.Name = "MaskedCCVField";
            this.MaskedCCVField.Size = new System.Drawing.Size(108, 47);
            this.MaskedCCVField.TabIndex = 8;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2135, 1007);
            this.Controls.Add(this.MaskedCCVField);
            this.Controls.Add(this.MaskedCardInfoField);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelCCV);
            this.Controls.Add(this.LabelCardNumber);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelCardNumber;
        private Label LabelCCV;
        private Label LabelTitle;
        private Button ButtonBack;
        private Button ButtonSubmit;
        private MaskedTextBox MaskedCardInfoField;
        private MaskedTextBox MaskedCCVField;
    }
}