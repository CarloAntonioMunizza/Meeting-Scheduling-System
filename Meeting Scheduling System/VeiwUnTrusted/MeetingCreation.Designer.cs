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
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.LabelRoomNum = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.LabelPeople = new System.Windows.Forms.Label();
            this.PeopleBox = new System.Windows.Forms.CheckedListBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomBox
            // 
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(570, 215);
            this.RoomBox.Margin = new System.Windows.Forms.Padding(6);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(316, 49);
            this.RoomBox.TabIndex = 0;
            this.RoomBox.SelectedIndexChanged += new System.EventHandler(this.RoomBox_SelectedIndexChanged);
            // 
            // LabelRoomNum
            // 
            this.LabelRoomNum.AutoSize = true;
            this.LabelRoomNum.Location = new System.Drawing.Point(570, 168);
            this.LabelRoomNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelRoomNum.Name = "LabelRoomNum";
            this.LabelRoomNum.Size = new System.Drawing.Size(308, 41);
            this.LabelRoomNum.TabIndex = 1;
            this.LabelRoomNum.Text = "Select Room Number:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(166, 168);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(236, 41);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "Select Time Slot:";
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(138, 215);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(6);
            this.TimeBox.MaxDropDownItems = 10;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(316, 49);
            this.TimeBox.TabIndex = 3;
            // 
            // LabelPeople
            // 
            this.LabelPeople.AutoSize = true;
            this.LabelPeople.Location = new System.Drawing.Point(1154, 168);
            this.LabelPeople.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPeople.Name = "LabelPeople";
            this.LabelPeople.Size = new System.Drawing.Size(179, 41);
            this.LabelPeople.TabIndex = 4;
            this.LabelPeople.Text = "Add People:";
            // 
            // PeopleBox
            // 
            this.PeopleBox.FormattingEnabled = true;
            this.PeopleBox.Location = new System.Drawing.Point(1092, 215);
            this.PeopleBox.Margin = new System.Windows.Forms.Padding(6);
            this.PeopleBox.Name = "PeopleBox";
            this.PeopleBox.Size = new System.Drawing.Size(314, 224);
            this.PeopleBox.TabIndex = 5;
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
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.Location = new System.Drawing.Point(1455, 799);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(188, 58);
            this.CreateMeetingButton.TabIndex = 7;
            this.CreateMeetingButton.Text = "Create";
            this.CreateMeetingButton.UseVisualStyleBackColor = true;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // MeetingCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.CreateMeetingButton);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.PeopleBox);
            this.Controls.Add(this.LabelPeople);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelRoomNum);
            this.Controls.Add(this.RoomBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MeetingCreation";
            this.Text = "MeetingCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox RoomBox;
        private Label LabelRoomNum;
        private Label LabelTime;
        private ComboBox TimeBox;
        private Label LabelPeople;
        private CheckedListBox PeopleBox;
        private Button ButtonBack;
        private Button CreateMeetingButton;
    }
}