namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class AdminRoomEdit
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
            this.LabelRoomNum = new System.Windows.Forms.Label();
            this.CheckSpecialRoom = new System.Windows.Forms.CheckBox();
            this.CheckedList = new System.Windows.Forms.CheckedListBox();
            this.LabelRemoveRoom = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.MaskedRoomNumField = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 838);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click_1);
            // 
            // LabelRoomNum
            // 
            this.LabelRoomNum.AutoSize = true;
            this.LabelRoomNum.Location = new System.Drawing.Point(246, 281);
            this.LabelRoomNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelRoomNum.Name = "LabelRoomNum";
            this.LabelRoomNum.Size = new System.Drawing.Size(380, 41);
            this.LabelRoomNum.TabIndex = 1;
            this.LabelRoomNum.Text = "Enter room number to add:";
            // 
            // CheckSpecialRoom
            // 
            this.CheckSpecialRoom.AutoSize = true;
            this.CheckSpecialRoom.Location = new System.Drawing.Point(325, 484);
            this.CheckSpecialRoom.Margin = new System.Windows.Forms.Padding(6);
            this.CheckSpecialRoom.Name = "CheckSpecialRoom";
            this.CheckSpecialRoom.Size = new System.Drawing.Size(236, 45);
            this.CheckSpecialRoom.TabIndex = 3;
            this.CheckSpecialRoom.Text = "Special Room";
            this.CheckSpecialRoom.UseVisualStyleBackColor = true;
            // 
            // CheckedList
            // 
            this.CheckedList.FormattingEnabled = true;
            this.CheckedList.Location = new System.Drawing.Point(1137, 369);
            this.CheckedList.Margin = new System.Windows.Forms.Padding(6);
            this.CheckedList.Name = "CheckedList";
            this.CheckedList.Size = new System.Drawing.Size(314, 224);
            this.CheckedList.TabIndex = 4;
            // 
            // LabelRemoveRoom
            // 
            this.LabelRemoveRoom.AutoSize = true;
            this.LabelRemoveRoom.Location = new System.Drawing.Point(1114, 281);
            this.LabelRemoveRoom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelRemoveRoom.Name = "LabelRemoveRoom";
            this.LabelRemoveRoom.Size = new System.Drawing.Size(341, 41);
            this.LabelRemoveRoom.TabIndex = 5;
            this.LabelRemoveRoom.Text = "Select rooms to remove:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(366, 98);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(879, 54);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Add a New Room or Remove a Existing Room";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(1475, 838);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(200, 59);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // MaskedRoomNumField
            // 
            this.MaskedRoomNumField.Location = new System.Drawing.Point(366, 369);
            this.MaskedRoomNumField.Margin = new System.Windows.Forms.Padding(6);
            this.MaskedRoomNumField.Mask = "000";
            this.MaskedRoomNumField.Name = "MaskedRoomNumField";
            this.MaskedRoomNumField.Size = new System.Drawing.Size(89, 47);
            this.MaskedRoomNumField.TabIndex = 8;
            // 
            // AdminRoomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 922);
            this.Controls.Add(this.MaskedRoomNumField);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelRemoveRoom);
            this.Controls.Add(this.CheckedList);
            this.Controls.Add(this.CheckSpecialRoom);
            this.Controls.Add(this.LabelRoomNum);
            this.Controls.Add(this.ButtonBack);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminRoomEdit";
            this.Text = "AdminRoomEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBack;
        private Label LabelRoomNum;
        private CheckBox CheckSpecialRoom;
        private CheckedListBox CheckedList;
        private Label LabelRemoveRoom;
        private Label LabelTitle;
        private Button ButtonSubmit;
        private MaskedTextBox MaskedRoomNumField;
    }
}