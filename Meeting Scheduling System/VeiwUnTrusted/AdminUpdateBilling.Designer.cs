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
            comboBox1 = new ComboBox();
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
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // AdminUpdateBilling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
    }
}