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
            this.LabelSelect = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SubjectDetailsField = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.LabelResponse = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSelect
            // 
            this.LabelSelect.AutoSize = true;
            this.LabelSelect.Location = new System.Drawing.Point(157, 228);
            this.LabelSelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(249, 41);
            this.LabelSelect.TabIndex = 0;
            this.LabelSelect.Text = "Select Complaint:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 275);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(525, 49);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SubjectDetailsField
            // 
            this.SubjectDetailsField.BackColor = System.Drawing.SystemColors.Window;
            this.SubjectDetailsField.Location = new System.Drawing.Point(589, 275);
            this.SubjectDetailsField.Margin = new System.Windows.Forms.Padding(6);
            this.SubjectDetailsField.Multiline = true;
            this.SubjectDetailsField.Name = "SubjectDetailsField";
            this.SubjectDetailsField.ReadOnly = true;
            this.SubjectDetailsField.Size = new System.Drawing.Size(497, 443);
            this.SubjectDetailsField.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1126, 275);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(544, 443);
            this.textBox2.TabIndex = 3;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Location = new System.Drawing.Point(661, 228);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(259, 41);
            this.LabelDetails.TabIndex = 4;
            this.LabelDetails.Text = "Complaint Details:";
            // 
            // LabelResponse
            // 
            this.LabelResponse.AutoSize = true;
            this.LabelResponse.Location = new System.Drawing.Point(1326, 228);
            this.LabelResponse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelResponse.Name = "LabelResponse";
            this.LabelResponse.Size = new System.Drawing.Size(142, 41);
            this.LabelResponse.TabIndex = 5;
            this.LabelResponse.Text = "Respond:";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // AdminViewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelResponse);
            this.Controls.Add(this.LabelDetails);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SubjectDetailsField);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelSelect);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminViewComplaint";
            this.Text = "AdminViewComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

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