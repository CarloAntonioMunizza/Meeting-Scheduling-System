namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class EditPayment
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
            NewCardField = new TextBox();
            LabelNewCard = new Label();
            LabelNewCCV = new Label();
            textBox1 = new TextBox();
            ButtonBack = new Button();
            ButtonSubmit = new Button();
            LabelTitle = new Label();
            SuspendLayout();
            // 
            // NewCardField
            // 
            NewCardField.Location = new Point(341, 162);
            NewCardField.Name = "NewCardField";
            NewCardField.Size = new Size(125, 27);
            NewCardField.TabIndex = 0;
            // 
            // LabelNewCard
            // 
            LabelNewCard.AutoSize = true;
            LabelNewCard.Location = new Point(162, 165);
            LabelNewCard.Name = "LabelNewCard";
            LabelNewCard.Size = new Size(173, 20);
            LabelNewCard.TabIndex = 1;
            LabelNewCard.Text = "Enter New Card Number:";
            // 
            // LabelNewCCV
            // 
            LabelNewCCV.AutoSize = true;
            LabelNewCCV.Location = new Point(224, 245);
            LabelNewCCV.Name = "LabelNewCCV";
            LabelNewCCV.Size = new Size(111, 20);
            LabelNewCCV.TabIndex = 2;
            LabelNewCCV.Text = "Enter New CCV:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 4;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
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
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(224, 32);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(328, 28);
            LabelTitle.TabIndex = 6;
            LabelTitle.Text = "Enter your New Card Information";
            // 
            // EditPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonBack);
            Controls.Add(textBox1);
            Controls.Add(LabelNewCCV);
            Controls.Add(LabelNewCard);
            Controls.Add(NewCardField);
            Name = "EditPayment";
            Text = "EditPayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewCardField;
        private Label LabelNewCard;
        private Label LabelNewCCV;
        private TextBox textBox1;
        private Button ButtonBack;
        private Button ButtonSubmit;
        private Label LabelTitle;
    }
}