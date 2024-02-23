
namespace Attendance_Management_System.Forms
{
    partial class UserControlMarkAttendance
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageMarkAttendence = new TabPage();
            dataGridViewMarkAttendence = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            comboBoxClass = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageMarkAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendence).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(42, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 501);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPageMarkAttendence);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendence
            // 
            tabPageMarkAttendence.Controls.Add(dataGridViewMarkAttendence);
            tabPageMarkAttendence.Controls.Add(comboBoxClass);
            tabPageMarkAttendence.Controls.Add(label3);
            tabPageMarkAttendence.Controls.Add(dateTimePicker1);
            tabPageMarkAttendence.Controls.Add(panel6);
            tabPageMarkAttendence.Controls.Add(panel5);
            tabPageMarkAttendence.Controls.Add(panel4);
            tabPageMarkAttendence.Controls.Add(panel3);
            tabPageMarkAttendence.Controls.Add(panel2);
            tabPageMarkAttendence.Controls.Add(label2);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(934, 473);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "Mark Attendence";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            tabPageMarkAttendence.Click += tabPageMarkAttendence_Click;
            // 
            // dataGridViewMarkAttendence
            // 
            dataGridViewMarkAttendence.AllowUserToAddRows = false;
            dataGridViewMarkAttendence.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendence.BackgroundColor = Color.White;
            dataGridViewMarkAttendence.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMarkAttendence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendence.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewMarkAttendence.Location = new Point(-1, 163);
            dataGridViewMarkAttendence.Name = "dataGridViewMarkAttendence";
            dataGridViewMarkAttendence.ScrollBars = ScrollBars.Vertical;
            dataGridViewMarkAttendence.Size = new Size(935, 150);
            dataGridViewMarkAttendence.TabIndex = 10;
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
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.Name = "Column4";
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(549, 73);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 23);
            comboBoxClass.TabIndex = 9;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 46);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Class";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(120, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel6
            // 
            panel6.Location = new Point(347, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 23);
            panel6.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(389, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 23);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(111, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 23);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(120, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 10);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(120, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 10);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 46);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 0;
            label1.Text = "Mark Attendence";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 473);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserControlMarkAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UserControlMarkAttendance";
            Size = new Size(1027, 526);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageMarkAttendence.ResumeLayout(false);
            tabPageMarkAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageMarkAttendence;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBoxClass;
        private DataGridView dataGridViewMarkAttendence;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private EventHandler comboBoxClass_SelectedIndexChanged;
        private TabPage tabPage1;
    }
}
