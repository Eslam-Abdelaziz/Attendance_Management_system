namespace Attendance_Management_System.Forms
{
    partial class UserControlTeacherReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControlMarkAttendance1 = new UserControlMarkAttendance();
            SuspendLayout();
            // 
            // userControlMarkAttendance1
            // 
            userControlMarkAttendance1.BackColor = Color.White;
            userControlMarkAttendance1.Location = new Point(148, 79);
            userControlMarkAttendance1.Name = "userControlMarkAttendance1";
            userControlMarkAttendance1.Size = new Size(1027, 526);
            userControlMarkAttendance1.TabIndex = 1;
            userControlMarkAttendance1.Load += userControlMarkAttendance1_Load;
            // 
            // UserControlTeacherReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userControlMarkAttendance1);
            Name = "UserControlTeacherReport";
            Size = new Size(1289, 710);
            ResumeLayout(false);
        }

        #endregion

        private UserControlMarkAttendance userControlMarkAttendance1;
    }
}
