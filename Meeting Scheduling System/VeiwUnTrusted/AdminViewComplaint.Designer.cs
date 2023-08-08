namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AdminViewComplaint
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
            LabelSelect = new Label();
            comboBox1 = new ComboBox();
            SubjectDetailsField = new TextBox();
            textBox2 = new TextBox();
            LabelDetails = new Label();
            LabelResponse = new Label();
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            SuspendLayout();
            // 
            // LabelSelect
            // 
            LabelSelect.AutoSize = true;
            LabelSelect.Location = new Point(74, 111);
            LabelSelect.Name = "LabelSelect";
            LabelSelect.Size = new Size(125, 20);
            LabelSelect.TabIndex = 0;
            LabelSelect.Text = "Select Complaint:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 28);
            comboBox1.TabIndex = 1;
            // 
            // SubjectDetailsField
            // 
            SubjectDetailsField.BackColor = SystemColors.Window;
            SubjectDetailsField.Location = new Point(267, 134);
            SubjectDetailsField.Multiline = true;
            SubjectDetailsField.Name = "SubjectDetailsField";
            SubjectDetailsField.ReadOnly = true;
            SubjectDetailsField.Size = new Size(236, 218);
            SubjectDetailsField.TabIndex = 2;
            SubjectDetailsField.TextChanged += SubjectDetailsField_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(530, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 218);
            textBox2.TabIndex = 3;
            // 
            // LabelDetails
            // 
            LabelDetails.AutoSize = true;
            LabelDetails.Location = new Point(311, 111);
            LabelDetails.Name = "LabelDetails";
            LabelDetails.Size = new Size(131, 20);
            LabelDetails.TabIndex = 4;
            LabelDetails.Text = "Complaint Details:";
            // 
            // LabelResponse
            // 
            LabelResponse.AutoSize = true;
            LabelResponse.Location = new Point(624, 111);
            LabelResponse.Name = "LabelResponse";
            LabelResponse.Size = new Size(70, 20);
            LabelResponse.TabIndex = 5;
            LabelResponse.Text = "Respond:";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // AdminViewComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Controls.Add(LabelResponse);
            Controls.Add(LabelDetails);
            Controls.Add(textBox2);
            Controls.Add(SubjectDetailsField);
            Controls.Add(comboBox1);
            Controls.Add(LabelSelect);
            Name = "AdminViewComplaint";
            Text = "AdminViewComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSelect;
        private ComboBox comboBox1;
        private TextBox SubjectDetailsField;
        private TextBox textBox2;
        private Label LabelDetails;
        private Label LabelResponse;
        private Button ButtonBack;
        private Button ButtonSubmit;
    }
}