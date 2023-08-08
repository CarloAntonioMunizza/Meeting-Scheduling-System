namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class MeetingCreation
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
            comboBox1 = new ComboBox();
            LabelRoomNum = new Label();
            LabelTime = new Label();
            comboBox2 = new ComboBox();
            LabelPeople = new Label();
            checkedListBox1 = new CheckedListBox();
            ButtonBack = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // LabelRoomNum
            // 
            LabelRoomNum.AutoSize = true;
            LabelRoomNum.Location = new Point(268, 82);
            LabelRoomNum.Name = "LabelRoomNum";
            LabelRoomNum.Size = new Size(154, 20);
            LabelRoomNum.TabIndex = 1;
            LabelRoomNum.Text = "Select Room Number:";
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Location = new Point(78, 82);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(119, 20);
            LabelTime.TabIndex = 2;
            LabelTime.Text = "Select Time Slot:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(65, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // LabelPeople
            // 
            LabelPeople.AutoSize = true;
            LabelPeople.Location = new Point(543, 82);
            LabelPeople.Name = "LabelPeople";
            LabelPeople.Size = new Size(89, 20);
            LabelPeople.TabIndex = 4;
            LabelPeople.Text = "Add People:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(514, 105);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 5;
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
            // MeetingCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonBack);
            Controls.Add(checkedListBox1);
            Controls.Add(LabelPeople);
            Controls.Add(comboBox2);
            Controls.Add(LabelTime);
            Controls.Add(LabelRoomNum);
            Controls.Add(comboBox1);
            Name = "MeetingCreation";
            Text = "MeetingCreation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label LabelRoomNum;
        private Label LabelTime;
        private ComboBox comboBox2;
        private Label LabelPeople;
        private CheckedListBox checkedListBox1;
        private Button ButtonBack;
    }
}