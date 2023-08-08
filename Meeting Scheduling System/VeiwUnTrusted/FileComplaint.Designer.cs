namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class FileComplaint
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
            SubjectField = new TextBox();
            LabelSubject = new Label();
            LabelTitle = new Label();
            DescriptionField = new TextBox();
            LabelDescription = new Label();
            ButtonSubmit = new Button();
            ButtonBack = new Button();
            LabelResponse = new Label();
            ResponseReadOnlyField = new TextBox();
            SuspendLayout();
            // 
            // SubjectField
            // 
            SubjectField.Location = new Point(112, 66);
            SubjectField.Name = "SubjectField";
            SubjectField.Size = new Size(311, 27);
            SubjectField.TabIndex = 0;
            // 
            // LabelSubject
            // 
            LabelSubject.AutoSize = true;
            LabelSubject.Location = new Point(45, 69);
            LabelSubject.Name = "LabelSubject";
            LabelSubject.Size = new Size(61, 20);
            LabelSubject.TabIndex = 1;
            LabelSubject.Text = "Subject:";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(303, 21);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(212, 28);
            LabelTitle.TabIndex = 2;
            LabelTitle.Text = "File Complaint Below";
            // 
            // DescriptionField
            // 
            DescriptionField.Location = new Point(112, 147);
            DescriptionField.Multiline = true;
            DescriptionField.Name = "DescriptionField";
            DescriptionField.Size = new Size(311, 237);
            DescriptionField.TabIndex = 3;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(18, 147);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(88, 20);
            LabelDescription.TabIndex = 4;
            LabelDescription.Text = "Description:";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 5;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // LabelResponse
            // 
            LabelResponse.AutoSize = true;
            LabelResponse.Location = new Point(429, 150);
            LabelResponse.Name = "LabelResponse";
            LabelResponse.Size = new Size(75, 20);
            LabelResponse.TabIndex = 7;
            LabelResponse.Text = "Response:";
            // 
            // ResponseReadOnlyField
            // 
            ResponseReadOnlyField.BackColor = SystemColors.Window;
            ResponseReadOnlyField.Location = new Point(510, 147);
            ResponseReadOnlyField.Multiline = true;
            ResponseReadOnlyField.Name = "ResponseReadOnlyField";
            ResponseReadOnlyField.ReadOnly = true;
            ResponseReadOnlyField.Size = new Size(278, 237);
            ResponseReadOnlyField.TabIndex = 8;
            // 
            // FileComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResponseReadOnlyField);
            Controls.Add(LabelResponse);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelDescription);
            Controls.Add(DescriptionField);
            Controls.Add(LabelTitle);
            Controls.Add(LabelSubject);
            Controls.Add(SubjectField);
            Name = "FileComplaint";
            Text = "FileComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubjectField;
        private Label LabelSubject;
        private Label LabelTitle;
        private TextBox DescriptionField;
        private Label LabelDescription;
        private Button ButtonSubmit;
        private Button ButtonBack;
        private Label LabelResponse;
        private TextBox ResponseReadOnlyField;
    }
}