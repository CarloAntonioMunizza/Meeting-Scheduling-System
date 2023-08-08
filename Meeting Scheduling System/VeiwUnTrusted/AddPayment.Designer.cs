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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelCCV = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Location = new System.Drawing.Point(168, 314);
            this.LabelCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(557, 41);
            this.LabelCardNumber.TabIndex = 0;
            this.LabelCardNumber.Text = "Enter your Card Number without dashes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(765, 308);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 47);
            this.textBox1.TabIndex = 1;
            // 
            // LabelCCV
            // 
            this.LabelCCV.AutoSize = true;
            this.LabelCCV.Location = new System.Drawing.Point(395, 414);
            this.LabelCCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCCV.Name = "LabelCCV";
            this.LabelCCV.Size = new System.Drawing.Size(342, 41);
            this.LabelCCV.TabIndex = 2;
            this.LabelCCV.Text = "Enter your CCV Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(765, 400);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 47);
            this.textBox2.TabIndex = 3;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(661, 84);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(407, 41);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Enter Card Information Below";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LabelCCV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelCardNumber);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelCardNumber;
        private TextBox textBox1;
        private Label LabelCCV;
        private TextBox textBox2;
        private Label LabelTitle;
        private Button ButtonBack;
        private Button ButtonSubmit;
    }
}