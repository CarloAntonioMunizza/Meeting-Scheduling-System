namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AdminMeetingDisplay
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
            ButtonBack = new Button();
            RBWeek = new RadioButton();
            RBDay = new RadioButton();
            RBRoom = new RadioButton();
            RBPerson = new RadioButton();
            RBTime = new RadioButton();
            CBWeek = new ComboBox();
            CBDay = new ComboBox();
            CBTime = new ComboBox();
            CBRoom = new ComboBox();
            CBPerson = new ComboBox();
            ListBoxDisplay = new ListBox();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 409);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // RBWeek
            // 
            RBWeek.AutoSize = true;
            RBWeek.Location = new Point(12, 65);
            RBWeek.Name = "RBWeek";
            RBWeek.Size = new Size(86, 24);
            RBWeek.TabIndex = 2;
            RBWeek.TabStop = true;
            RBWeek.Text = "By Week";
            RBWeek.UseVisualStyleBackColor = true;
            RBWeek.CheckedChanged += RBWeek_CheckedChanged;
            // 
            // RBDay
            // 
            RBDay.AutoSize = true;
            RBDay.Location = new Point(12, 123);
            RBDay.Name = "RBDay";
            RBDay.Size = new Size(76, 24);
            RBDay.TabIndex = 3;
            RBDay.TabStop = true;
            RBDay.Text = "By Day";
            RBDay.UseVisualStyleBackColor = true;
            RBDay.CheckedChanged += RBDay_CheckedChanged;
            // 
            // RBRoom
            // 
            RBRoom.AutoSize = true;
            RBRoom.Location = new Point(12, 233);
            RBRoom.Name = "RBRoom";
            RBRoom.Size = new Size(90, 24);
            RBRoom.TabIndex = 4;
            RBRoom.TabStop = true;
            RBRoom.Text = "By Room";
            RBRoom.UseVisualStyleBackColor = true;
            RBRoom.CheckedChanged += RBRoom_CheckedChanged;
            // 
            // RBPerson
            // 
            RBPerson.AutoSize = true;
            RBPerson.Location = new Point(12, 292);
            RBPerson.Name = "RBPerson";
            RBPerson.Size = new Size(93, 24);
            RBPerson.TabIndex = 5;
            RBPerson.TabStop = true;
            RBPerson.Text = "By Person";
            RBPerson.UseVisualStyleBackColor = true;
            RBPerson.CheckedChanged += RBPerson_CheckedChanged;
            // 
            // RBTime
            // 
            RBTime.AutoSize = true;
            RBTime.Location = new Point(12, 178);
            RBTime.Name = "RBTime";
            RBTime.Size = new Size(83, 24);
            RBTime.TabIndex = 6;
            RBTime.TabStop = true;
            RBTime.Text = "By Time";
            RBTime.UseVisualStyleBackColor = true;
            RBTime.CheckedChanged += RBTime_CheckedChanged;
            // 
            // CBWeek
            // 
            CBWeek.FormattingEnabled = true;
            CBWeek.Location = new Point(177, 90);
            CBWeek.Name = "CBWeek";
            CBWeek.Size = new Size(151, 28);
            CBWeek.TabIndex = 7;
            CBWeek.Visible = false;
            // 
            // CBDay
            // 
            CBDay.FormattingEnabled = true;
            CBDay.Location = new Point(177, 90);
            CBDay.Name = "CBDay";
            CBDay.Size = new Size(151, 28);
            CBDay.TabIndex = 8;
            CBDay.Visible = false;
            // 
            // CBTime
            // 
            CBTime.FormattingEnabled = true;
            CBTime.Location = new Point(177, 90);
            CBTime.Name = "CBTime";
            CBTime.Size = new Size(151, 28);
            CBTime.TabIndex = 9;
            CBTime.Visible = false;
            // 
            // CBRoom
            // 
            CBRoom.FormattingEnabled = true;
            CBRoom.Location = new Point(177, 90);
            CBRoom.Name = "CBRoom";
            CBRoom.Size = new Size(151, 28);
            CBRoom.TabIndex = 10;
            CBRoom.Visible = false;
            // 
            // CBPerson
            // 
            CBPerson.FormattingEnabled = true;
            CBPerson.Location = new Point(177, 90);
            CBPerson.Name = "CBPerson";
            CBPerson.Size = new Size(151, 28);
            CBPerson.TabIndex = 11;
            CBPerson.Visible = false;
            // 
            // ListBoxDisplay
            // 
            ListBoxDisplay.AccessibleRole = AccessibleRole.None;
            ListBoxDisplay.FormattingEnabled = true;
            ListBoxDisplay.ItemHeight = 20;
            ListBoxDisplay.Location = new Point(600, 14);
            ListBoxDisplay.Name = "ListBoxDisplay";
            ListBoxDisplay.Size = new Size(188, 424);
            ListBoxDisplay.TabIndex = 12;
            // 
            // AdminMeetingDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxDisplay);
            Controls.Add(CBPerson);
            Controls.Add(CBRoom);
            Controls.Add(CBTime);
            Controls.Add(CBDay);
            Controls.Add(CBWeek);
            Controls.Add(RBTime);
            Controls.Add(RBPerson);
            Controls.Add(RBRoom);
            Controls.Add(RBDay);
            Controls.Add(RBWeek);
            Controls.Add(ButtonBack);
            Name = "AdminMeetingDisplay";
            Text = "AdminMeetingDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private RadioButton RBWeek;
        private RadioButton RBDay;
        private RadioButton RBRoom;
        private RadioButton RBPerson;
        private RadioButton RBTime;
        private ComboBox CBWeek;
        private ComboBox CBDay;
        private ComboBox CBTime;
        private ComboBox CBRoom;
        private ComboBox CBPerson;
        private ListBox ListBoxDisplay;
    }
}