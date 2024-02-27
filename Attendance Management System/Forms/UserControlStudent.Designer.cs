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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPageMarkAttendence = new TabPage();
            dataGridViewStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageMarkAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
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
            // tabPageMarkAttendence
            // 
            tabPageMarkAttendence.Controls.Add(dataGridViewStudent);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(934, 473);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "Student Report";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            tabPageMarkAttendence.Click += tabPageMarkAttendence_Click_1;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Date });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStudent.Location = new Point(6, 179);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewStudent.ScrollBars = ScrollBars.Vertical;
            dataGridViewStudent.Size = new Size(919, 150);
            dataGridViewStudent.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Student Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(358, 71);
            label1.Name = "label1";
            label1.Size = new Size(190, 49);
            label1.TabIndex = 0;
            label1.Text = "Student Report";
            label1.Click += label1_Click;
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
            tabPageMarkAttendence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
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
