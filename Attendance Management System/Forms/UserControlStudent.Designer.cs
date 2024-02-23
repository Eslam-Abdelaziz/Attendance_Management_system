namespace Attendance_Management_System.Forms
{
    partial class UserControlStudent
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            label1 = new Label();
            dataGridViewStudent = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tabPageMarkAttendence = new TabPage();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            tabPageMarkAttendence.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPageMarkAttendence);
            tabControl1.Location = new Point(35, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(365, 50);
            label1.Name = "label1";
            label1.Size = new Size(190, 49);
            label1.TabIndex = 0;
            label1.Text = "Student Report";
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Date });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewStudent.Location = new Point(-1, 163);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridViewStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewStudent.ScrollBars = ScrollBars.Vertical;
            dataGridViewStudent.Size = new Size(935, 150);
            dataGridViewStudent.TabIndex = 10;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "Student Name";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // tabPageMarkAttendence
            // 
            tabPageMarkAttendence.Controls.Add(dataGridViewStudent);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(934, 473);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "Mark Attendence";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            // 
            // UserControlStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UserControlStudent";
            Size = new Size(1012, 519);
            Load += UserControlStudent_Load;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            tabPageMarkAttendence.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageMarkAttendence;
        private DataGridView dataGridViewStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Date;
        private Label label1;
    }
}
