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
            LabelCardNumber = new Label();
            textBox1 = new TextBox();
            LabelCCV = new Label();
            textBox2 = new TextBox();
            LabelTitle = new Label();
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            SuspendLayout();
            // 
            // LabelCardNumber
            // 
            LabelCardNumber.AutoSize = true;
            LabelCardNumber.Location = new Point(79, 153);
            LabelCardNumber.Name = "LabelCardNumber";
            LabelCardNumber.Size = new Size(275, 20);
            LabelCardNumber.TabIndex = 0;
            LabelCardNumber.Text = "Enter your Card Number without dashes:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 1;
            // 
            // LabelCCV
            // 
            LabelCCV.AutoSize = true;
            LabelCCV.Location = new Point(186, 202);
            LabelCCV.Name = "LabelCCV";
            LabelCCV.Size = new Size(168, 20);
            LabelCCV.TabIndex = 2;
            LabelCCV.Text = "Enter your CCV Number:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 27);
            textBox2.TabIndex = 3;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(311, 41);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(205, 20);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Enter Card Information Below";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 6;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Controls.Add(LabelTitle);
            Controls.Add(textBox2);
            Controls.Add(LabelCCV);
            Controls.Add(textBox1);
            Controls.Add(LabelCardNumber);
            Name = "AddPayment";
            Text = "AddPayment";
            ResumeLayout(false);
            PerformLayout();
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