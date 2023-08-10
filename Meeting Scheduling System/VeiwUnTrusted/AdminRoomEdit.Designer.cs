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
            ButtonBack = new Button();
            LabelRoomNum = new Label();
            CheckSpecialRoom = new CheckBox();
            CheckedList = new CheckedListBox();
            LabelRemoveRoom = new Label();
            LabelTitle = new Label();
            ButtonSubmit = new Button();
            MaskedRoomNumField = new MaskedTextBox();
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
            // LabelRoomNum
            // 
            LabelRoomNum.AutoSize = true;
            LabelRoomNum.Location = new Point(116, 137);
            LabelRoomNum.Name = "LabelRoomNum";
            LabelRoomNum.Size = new Size(189, 20);
            LabelRoomNum.TabIndex = 1;
            LabelRoomNum.Text = "Enter room number to add:";
            // 
            // CheckSpecialRoom
            // 
            CheckSpecialRoom.AutoSize = true;
            CheckSpecialRoom.Location = new Point(153, 236);
            CheckSpecialRoom.Name = "CheckSpecialRoom";
            CheckSpecialRoom.Size = new Size(123, 24);
            CheckSpecialRoom.TabIndex = 3;
            CheckSpecialRoom.Text = "Special Room";
            CheckSpecialRoom.UseVisualStyleBackColor = true;
            // 
            // CheckedList
            // 
            CheckedList.FormattingEnabled = true;
            CheckedList.Location = new Point(535, 180);
            CheckedList.Name = "CheckedList";
            CheckedList.Size = new Size(150, 92);
            CheckedList.TabIndex = 4;
            // 
            // LabelRemoveRoom
            // 
            LabelRemoveRoom.AutoSize = true;
            LabelRemoveRoom.Location = new Point(524, 137);
            LabelRemoveRoom.Name = "LabelRemoveRoom";
            LabelRemoveRoom.Size = new Size(170, 20);
            LabelRemoveRoom.TabIndex = 5;
            LabelRemoveRoom.Text = "Select rooms to remove:";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(172, 48);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(444, 28);
            LabelTitle.TabIndex = 6;
            LabelTitle.Text = "Add a New Room or Remove a Existing Room";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(694, 409);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // MaskedRoomNumField
            // 
            MaskedRoomNumField.Location = new Point(172, 180);
            MaskedRoomNumField.Mask = "000";
            MaskedRoomNumField.Name = "MaskedRoomNumField";
            MaskedRoomNumField.Size = new Size(44, 27);
            MaskedRoomNumField.TabIndex = 8;
            // 
            // AdminRoomEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MaskedRoomNumField);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelTitle);
            Controls.Add(LabelRemoveRoom);
            Controls.Add(CheckedList);
            Controls.Add(CheckSpecialRoom);
            Controls.Add(LabelRoomNum);
            Controls.Add(ButtonBack);
            Name = "AdminRoomEdit";
            Text = "AdminRoomEdit";
            ResumeLayout(false);
            PerformLayout();
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