namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class CreateAdmins
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(453, 55);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(766, 54);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Select a user to give admin permissions";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Location = new System.Drawing.Point(690, 211);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(302, 49);
            this.EmailComboBox.TabIndex = 4;
            this.EmailComboBox.Text = "Select User";
            // 
            // CreateAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.EmailComboBox);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateAdmins";
            this.Text = "CreateAdmins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTitle;
        private Button ButtonBack;
        private Button ButtonSubmit;
        private ComboBox EmailComboBox;
    }
}