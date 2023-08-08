namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class Meetings
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
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonView = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(716, 193);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(270, 84);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Create Meeting";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.Location = new System.Drawing.Point(716, 488);
            this.ButtonView.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(270, 84);
            this.ButtonView.TabIndex = 1;
            this.ButtonView.Text = "View Meeting";
            this.ButtonView.UseVisualStyleBackColor = true;
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(716, 340);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(270, 84);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit Meeting";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(695, 59);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(300, 54);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Meeting Menu";
            // 
            // Meetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonView);
            this.Controls.Add(this.ButtonCreate);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Meetings";
            this.Text = "Meetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonCreate;
        private Button ButtonView;
        private Button ButtonEdit;
        private Button ButtonBack;
        private Label LabelTitle;
    }
}