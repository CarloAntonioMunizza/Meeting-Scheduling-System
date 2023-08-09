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
            LabelCardNumber.AutoSize = true;
            LabelCardNumber.Location = new Point(103, 200);
            LabelCardNumber.Margin = new Padding(6, 0, 6, 0);
            LabelCardNumber.Name = "LabelCardNumber";
            LabelCardNumber.Size = new Size(275, 20);
            LabelCardNumber.TabIndex = 0;
            LabelCardNumber.Text = "Enter your Card Number without dashes:";
            // 
            // LabelCCV
            // 
            LabelCCV.AutoSize = true;
            LabelCCV.Location = new Point(210, 269);
            LabelCCV.Margin = new Padding(6, 0, 6, 0);
            LabelCCV.Name = "LabelCCV";
            LabelCCV.Size = new Size(168, 20);
            LabelCCV.TabIndex = 2;
            LabelCCV.Text = "Enter your CCV Number:";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(330, 60);
            LabelTitle.Margin = new Padding(6, 0, 6, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(205, 20);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Enter Card Information Below";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(15, 472);
            ButtonBack.Margin = new Padding(6);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(773, 472);
            ButtonSubmit.Margin = new Padding(6);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 6;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // MaskedCardInfoField
            // 
            MaskedCardInfoField.Location = new Point(387, 193);
            MaskedCardInfoField.Mask = "0000-0000-0000-0000";
            MaskedCardInfoField.Name = "MaskedCardInfoField";
            MaskedCardInfoField.Size = new Size(125, 27);
            MaskedCardInfoField.TabIndex = 7;
            // 
            // MaskedCCVField
            // 
            MaskedCCVField.Location = new Point(387, 266);
            MaskedCCVField.Mask = "000";
            MaskedCCVField.Name = "MaskedCCVField";
            MaskedCCVField.Size = new Size(53, 27);
            MaskedCCVField.TabIndex = 8;
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 516);
            Controls.Add(MaskedCCVField);
            Controls.Add(MaskedCardInfoField);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Controls.Add(LabelTitle);
            Controls.Add(LabelCCV);
            Controls.Add(LabelCardNumber);
            Name = "AddPayment";
            Text = "AddPayment";
            Load += AddPayment_Load;
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