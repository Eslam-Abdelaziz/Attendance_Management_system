
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
            btnSave = new Button();
            dataGridViewMarkAttendance = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            comboBoxClass = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel6 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageMarkAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).BeginInit();
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
            tabPageMarkAttendence.Controls.Add(btnSave);
            tabPageMarkAttendence.Controls.Add(dataGridViewMarkAttendance);
            tabPageMarkAttendence.Controls.Add(comboBoxClass);
            tabPageMarkAttendence.Controls.Add(label3);
            tabPageMarkAttendence.Controls.Add(dateTimePicker1);
            tabPageMarkAttendence.Controls.Add(panel6);
            tabPageMarkAttendence.Controls.Add(label2);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(934, 473);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "Mark Attendence";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(744, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // dataGridViewMarkAttendance
            // 
            dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendance.BackgroundColor = Color.White;
            dataGridViewMarkAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { id, name, status });
            dataGridViewMarkAttendance.Location = new Point(-1, 180);
            dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            dataGridViewMarkAttendance.ScrollBars = ScrollBars.Vertical;
            dataGridViewMarkAttendance.Size = new Size(935, 150);
            dataGridViewMarkAttendance.TabIndex = 12;
            dataGridViewMarkAttendance.CellContentClick += dataGridViewMarkAttendance_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "name";
            id.Name = "id";
            // 
            // name
            // 
            name.HeaderText = "id";
            name.Name = "name";
            // 
            // status
            // 
            status.HeaderText = "status";
            status.Name = "status";
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // 
            // panel6
            // 
            panel6.Location = new Point(347, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 23);
            panel6.TabIndex = 6;
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
            Load += UserControlMarkAttendance_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageMarkAttendence.ResumeLayout(false);
            tabPageMarkAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageMarkAttendence;
        private Label label1;
        private Label label2;
        private Panel panel6;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBoxClass;
      //  private EventHandler comboBoxClass_SelectedIndexChanged;
        private TabPage tabPage1;
        private DataGridView dataGridViewMarkAttendance;
        private Button btnSave;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn status;
    }
}
