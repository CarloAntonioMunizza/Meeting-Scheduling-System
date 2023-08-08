namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class MeetingEditor
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
            LabelCreatedMeetings = new Label();
            LabelTime = new Label();
            comboBox2 = new ComboBox();
            LabelEditRoom = new Label();
            comboBox3 = new ComboBox();
            ButtonBack = new Button();
            checkedListBox1 = new CheckedListBox();
            LabelEditPeople = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // LabelCreatedMeetings
            // 
            LabelCreatedMeetings.AutoSize = true;
            LabelCreatedMeetings.Location = new Point(48, 124);
            LabelCreatedMeetings.Name = "LabelCreatedMeetings";
            LabelCreatedMeetings.Size = new Size(129, 20);
            LabelCreatedMeetings.TabIndex = 1;
            LabelCreatedMeetings.Text = "Created Meetings:";
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Location = new Point(253, 124);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(75, 20);
            LabelTime.TabIndex = 2;
            LabelTime.Text = "Edit Time:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(214, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // LabelEditRoom
            // 
            LabelEditRoom.AutoSize = true;
            LabelEditRoom.Location = new Point(428, 124);
            LabelEditRoom.Name = "LabelEditRoom";
            LabelEditRoom.Size = new Size(82, 20);
            LabelEditRoom.TabIndex = 4;
            LabelEditRoom.Text = "Edit Room:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(392, 147);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 5;
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
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(591, 147);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 7;
            // 
            // LabelEditPeople
            // 
            LabelEditPeople.AutoSize = true;
            LabelEditPeople.Location = new Point(610, 124);
            LabelEditPeople.Name = "LabelEditPeople";
            LabelEditPeople.Size = new Size(118, 20);
            LabelEditPeople.TabIndex = 8;
            LabelEditPeople.Text = "Edit Attendance:";
            // 
            // MeetingEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEditPeople);
            Controls.Add(checkedListBox1);
            Controls.Add(ButtonBack);
            Controls.Add(comboBox3);
            Controls.Add(LabelEditRoom);
            Controls.Add(comboBox2);
            Controls.Add(LabelTime);
            Controls.Add(LabelCreatedMeetings);
            Controls.Add(comboBox1);
            Name = "MeetingEditor";
            Text = "MeetingEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label LabelCreatedMeetings;
        private Label LabelTime;
        private ComboBox comboBox2;
        private Label LabelEditRoom;
        private ComboBox comboBox3;
        private Button ButtonBack;
        private CheckedListBox checkedListBox1;
        private Label LabelEditPeople;
    }
}