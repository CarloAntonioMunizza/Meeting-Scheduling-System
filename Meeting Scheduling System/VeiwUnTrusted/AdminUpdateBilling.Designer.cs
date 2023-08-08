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
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            LabelTitle = new Label();
            LabelUserSelect = new Label();
            EmailComboBox = new ComboBox();
            CardNumberField = new TextBox();
            LabelCardNumber = new Label();
            LabelCCV = new Label();
            CCVField = new TextBox();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(247, 37);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(328, 28);
            LabelTitle.TabIndex = 3;
            LabelTitle.Text = "Update User's Billing Information";
            // 
            // LabelUserSelect
            // 
            LabelUserSelect.AutoSize = true;
            LabelUserSelect.Location = new Point(73, 142);
            LabelUserSelect.Name = "LabelUserSelect";
            LabelUserSelect.Size = new Size(156, 20);
            LabelUserSelect.TabIndex = 4;
            LabelUserSelect.Text = "Select User to Update:";
            // 
            // EmailComboBox
            // 
            EmailComboBox.FormattingEnabled = true;
            EmailComboBox.Location = new Point(73, 165);
            EmailComboBox.Name = "EmailComboBox";
            EmailComboBox.Size = new Size(151, 28);
            EmailComboBox.TabIndex = 5;
            // 
            // CardNumberField
            // 
            CardNumberField.Location = new Point(307, 165);
            CardNumberField.Name = "CardNumberField";
            CardNumberField.Size = new Size(177, 27);
            CardNumberField.TabIndex = 6;
            // 
            // LabelCardNumber
            // 
            LabelCardNumber.AutoSize = true;
            LabelCardNumber.Location = new Point(297, 142);
            LabelCardNumber.Name = "LabelCardNumber";
            LabelCardNumber.Size = new Size(197, 20);
            LabelCardNumber.TabIndex = 7;
            LabelCardNumber.Text = "Change User's Card Number:";
            // 
            // LabelCCV
            // 
            LabelCCV.AutoSize = true;
            LabelCCV.Location = new Point(597, 142);
            LabelCCV.Name = "LabelCCV";
            LabelCCV.Size = new Size(93, 20);
            LabelCCV.TabIndex = 8;
            LabelCCV.Text = "Change CCV:";
            // 
            // CCVField
            // 
            CCVField.Location = new Point(609, 165);
            CCVField.Name = "CCVField";
            CCVField.Size = new Size(67, 27);
            CCVField.TabIndex = 9;
            // 
            // AdminUpdateBilling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CCVField);
            Controls.Add(LabelCCV);
            Controls.Add(LabelCardNumber);
            Controls.Add(CardNumberField);
            Controls.Add(EmailComboBox);
            Controls.Add(LabelUserSelect);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Name = "AdminUpdateBilling";
            Text = "AdminUpdateBilling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label LabelTitle;
        private Label LabelUserSelect;
        private ComboBox EmailComboBox;
        private TextBox CardNumberField;
        private Label LabelCardNumber;
        private Label LabelCCV;
        private TextBox CCVField;
    }
}