namespace Meeting_Scheduling_System.VeiwUnTrusted
{
    partial class Meetings
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
            ButtonCreate = new Button();
            ButtonView = new Button();
            ButtonEdit = new Button();
            ButtonAdminEditRooms = new Button();
            ButtonBack = new Button();
            LabelTitle = new Label();
            SuspendLayout();
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(337, 94);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(127, 41);
            ButtonCreate.TabIndex = 0;
            ButtonCreate.Text = "Create Meeting";
            ButtonCreate.UseVisualStyleBackColor = true;
            // 
            // ButtonView
            // 
            ButtonView.Location = new Point(337, 238);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(127, 41);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "View Meeting";
            ButtonView.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(337, 166);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(127, 41);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Edit Meeting";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonAdminEditRooms
            // 
            ButtonAdminEditRooms.Location = new Point(327, 328);
            ButtonAdminEditRooms.Name = "ButtonAdminEditRooms";
            ButtonAdminEditRooms.Size = new Size(146, 65);
            ButtonAdminEditRooms.TabIndex = 3;
            ButtonAdminEditRooms.Text = "Admin Edit Rooms";
            ButtonAdminEditRooms.UseVisualStyleBackColor = true;
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
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(327, 29);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(151, 28);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Meeting Menu";
            // 
            // Meetings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonAdminEditRooms);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonView);
            Controls.Add(ButtonCreate);
            Name = "Meetings";
            Text = "Meetings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCreate;
        private Button ButtonView;
        private Button ButtonEdit;
        private Button ButtonAdminEditRooms;
        private Button ButtonBack;
        private Label LabelTitle;
    }
}