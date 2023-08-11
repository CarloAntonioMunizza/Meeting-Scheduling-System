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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelCreatedMeetings = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LabelEditRoom = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.LabelEditPeople = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 301);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 49);
            this.comboBox1.TabIndex = 0;
            // 
            // LabelCreatedMeetings
            // 
            this.LabelCreatedMeetings.AutoSize = true;
            this.LabelCreatedMeetings.Location = new System.Drawing.Point(102, 254);
            this.LabelCreatedMeetings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCreatedMeetings.Name = "LabelCreatedMeetings";
            this.LabelCreatedMeetings.Size = new System.Drawing.Size(261, 41);
            this.LabelCreatedMeetings.TabIndex = 1;
            this.LabelCreatedMeetings.Text = "Created Meetings:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(538, 254);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(148, 41);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "Edit Time:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(455, 301);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 49);
            this.comboBox2.TabIndex = 3;
            // 
            // LabelEditRoom
            // 
            this.LabelEditRoom.AutoSize = true;
            this.LabelEditRoom.Location = new System.Drawing.Point(910, 254);
            this.LabelEditRoom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelEditRoom.Name = "LabelEditRoom";
            this.LabelEditRoom.Size = new System.Drawing.Size(162, 41);
            this.LabelEditRoom.TabIndex = 4;
            this.LabelEditRoom.Text = "Edit Room:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(833, 301);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(316, 49);
            this.comboBox3.TabIndex = 5;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1256, 301);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(314, 224);
            this.checkedListBox1.TabIndex = 7;
            // 
            // LabelEditPeople
            // 
            this.LabelEditPeople.AutoSize = true;
            this.LabelEditPeople.Location = new System.Drawing.Point(1296, 254);
            this.LabelEditPeople.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelEditPeople.Name = "LabelEditPeople";
            this.LabelEditPeople.Size = new System.Drawing.Size(235, 41);
            this.LabelEditPeople.TabIndex = 8;
            this.LabelEditPeople.Text = "Edit Attendance:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(1396, 782);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(188, 58);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "confirm";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MeetingEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.LabelEditPeople);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.LabelEditRoom);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelCreatedMeetings);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MeetingEditor";
            this.Text = "MeetingEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button submitButton;
    }
}