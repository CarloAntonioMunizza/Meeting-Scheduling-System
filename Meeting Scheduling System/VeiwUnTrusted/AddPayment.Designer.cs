namespace Meeting_Scheduling_System.VeiwUnTrusted
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
            LabelCardNumber = new Label();
            LabelCCV = new Label();
            LabelTitle = new Label();
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            MaskedCardInfoField = new MaskedTextBox();
            MaskedCCVField = new MaskedTextBox();
            SuspendLayout();
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Location = new System.Drawing.Point(168, 314);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(557, 41);
            this.LabelCardNumber.TabIndex = 0;
            this.LabelCardNumber.Text = "Enter your Card Number without dashes:";
            // 
            // LabelCCV
            // 
            this.LabelCCV.AutoSize = true;
            this.LabelCCV.Location = new System.Drawing.Point(395, 414);
            this.LabelCCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCCV.Name = "LabelCCV";
            this.LabelCCV.Size = new System.Drawing.Size(342, 41);
            this.LabelCCV.TabIndex = 2;
            this.LabelCCV.Text = "Enter your CCV Number:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(661, 84);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(407, 41);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Enter Card Information Below";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // MaskedCardInfoField
            // 
            MaskedCardInfoField.Location = new Point(360, 153);
            MaskedCardInfoField.Mask = "0000-0000-0000-0000";
            MaskedCardInfoField.Name = "MaskedCardInfoField";
            MaskedCardInfoField.Size = new Size(125, 27);
            MaskedCardInfoField.TabIndex = 7;
            // 
            // MaskedCCVField
            // 
            MaskedCCVField.Location = new Point(360, 199);
            MaskedCCVField.Mask = "000";
            MaskedCCVField.Name = "MaskedCCVField";
            MaskedCCVField.Size = new Size(53, 27);
            MaskedCCVField.TabIndex = 8;
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MaskedCCVField);
            Controls.Add(MaskedCardInfoField);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Controls.Add(LabelTitle);
            Controls.Add(LabelCCV);
            Controls.Add(LabelCardNumber);
            Name = "AddPayment";
            Text = "AddPayment";
            ResumeLayout(false);
            PerformLayout();
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