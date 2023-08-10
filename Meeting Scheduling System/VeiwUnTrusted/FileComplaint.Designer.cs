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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelResponse = new System.Windows.Forms.Label();
            this.ResponseReadOnlyField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(644, 43);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(420, 54);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "File Complaint Below";
            // 
            // DescriptionField
            // 
            this.DescriptionField.Location = new System.Drawing.Point(238, 301);
            this.DescriptionField.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(656, 482);
            this.DescriptionField.TabIndex = 3;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(38, 301);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(176, 41);
            this.LabelDescription.TabIndex = 4;
            this.LabelDescription.Text = "Description:";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 5;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
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
            // LabelResponse
            // 
            this.LabelResponse.AutoSize = true;
            this.LabelResponse.Location = new System.Drawing.Point(912, 308);
            this.LabelResponse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelResponse.Name = "LabelResponse";
            this.LabelResponse.Size = new System.Drawing.Size(153, 41);
            this.LabelResponse.TabIndex = 7;
            this.LabelResponse.Text = "Response:";
            // 
            // ResponseReadOnlyField
            // 
            this.ResponseReadOnlyField.BackColor = System.Drawing.SystemColors.Window;
            this.ResponseReadOnlyField.Location = new System.Drawing.Point(1084, 301);
            this.ResponseReadOnlyField.Margin = new System.Windows.Forms.Padding(6);
            this.ResponseReadOnlyField.Multiline = true;
            this.ResponseReadOnlyField.Name = "ResponseReadOnlyField";
            this.ResponseReadOnlyField.ReadOnly = true;
            this.ResponseReadOnlyField.Size = new System.Drawing.Size(586, 482);
            this.ResponseReadOnlyField.TabIndex = 8;
            // 
            // FileComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ResponseReadOnlyField);
            this.Controls.Add(this.LabelResponse);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FileComplaint";
            this.Text = "FileComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelTitle;
        private TextBox DescriptionField;
        private Label LabelDescription;
        private Button ButtonSubmit;
        private Button ButtonBack;
        private Label LabelResponse;
        private TextBox ResponseReadOnlyField;
    }
}