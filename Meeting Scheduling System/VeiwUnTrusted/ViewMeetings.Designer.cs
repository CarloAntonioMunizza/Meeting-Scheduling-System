namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class ViewMeetings
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1409, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "please refer to zoom.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 922);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ViewMeetings";
            this.Text = "ViewMeetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label label1;
    }
}