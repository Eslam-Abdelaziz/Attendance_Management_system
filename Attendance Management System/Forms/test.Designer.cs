namespace Attendance_Management_System.Forms
{
    partial class test
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
            userControlStudent1 = new UserControlStudent();
            SuspendLayout();
            // 
            // userControlStudent1
            // 
            userControlStudent1.Location = new Point(-64, 12);
            userControlStudent1.Name = "userControlStudent1";
            userControlStudent1.Size = new Size(1012, 519);
            userControlStudent1.TabIndex = 0;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlStudent1);
            Name = "test";
            Text = "test";
            ResumeLayout(false);
        }

        #endregion

        private UserControlStudent userControlStudent1;
    }
}