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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTeacherReport));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPageMarkAttendence = new TabPage();
            pictureBoxPrint = new PictureBox();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            dataGridViewTeacherReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            comboBoxClass = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel6 = new Panel();
            label2 = new Label();
            label1 = new Label();
            toolTip = new ToolTip(components);
            ExportPdf_Button = new Button();
            ExportExcel_Button = new Button();
            tabControl1.SuspendLayout();
            tabPageMarkAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacherReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPageMarkAttendence);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(33, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1168, 568);
            tabControl1.TabIndex = 1;
            // 
            // tabPageMarkAttendence
            // 
            tabPageMarkAttendence.Controls.Add(pictureBoxPrint);
            tabPageMarkAttendence.Controls.Add(tabControl2);
            tabPageMarkAttendence.Controls.Add(dataGridViewTeacherReport);
            tabPageMarkAttendence.Controls.Add(comboBoxClass);
            tabPageMarkAttendence.Controls.Add(label3);
            tabPageMarkAttendence.Controls.Add(dateTimePicker1);
            tabPageMarkAttendence.Controls.Add(panel6);
            tabPageMarkAttendence.Controls.Add(label2);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(1160, 538);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "Class Report";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Anchor = AnchorStyles.None;
            pictureBoxPrint.Cursor = Cursors.Hand;
            pictureBoxPrint.Image = (Image)resources.GetObject("pictureBoxPrint.Image");
            pictureBoxPrint.Location = new Point(1072, 1);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(87, 65);
            pictureBoxPrint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint.TabIndex = 16;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            pictureBoxPrint.MouseHover += pictureBoxPrint_Hover;
            // 
            // tabControl2
            // 
            tabControl2.AccessibleName = "";
            tabControl2.Alignment = TabAlignment.Bottom;
            tabControl2.Anchor = AnchorStyles.None;
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Font = new Font("Segoe UI", 10F);
            tabControl2.Location = new Point(1029, 832);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(513, 115);
            tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(505, 85);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Mark Attendence";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(0, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1103, 406);
            dataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Status";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Date";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-1, 173);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(935, 150);
            dataGridView2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(549, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 25);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 55);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 8;
            label4.Text = "Class";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(120, 73);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(270, 25);
            dateTimePicker2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(347, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 23);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 55);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 0;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.ForeColor = Color.FromArgb(67, 31, 125);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 0;
            label6.Text = "Mark Attendence";
            // 
            // dataGridViewTeacherReport
            // 
            dataGridViewTeacherReport.AllowUserToAddRows = false;
            dataGridViewTeacherReport.AllowUserToDeleteRows = false;
            dataGridViewTeacherReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeacherReport.BackgroundColor = Color.White;
            dataGridViewTeacherReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTeacherReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacherReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Date });
            dataGridViewTeacherReport.Location = new Point(-1, 183);
            dataGridViewTeacherReport.Name = "dataGridViewTeacherReport";
            dataGridViewTeacherReport.ScrollBars = ScrollBars.Vertical;
            dataGridViewTeacherReport.Size = new Size(1161, 352);
            dataGridViewTeacherReport.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Class";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Student Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            // 
            // Date
            // 
            Date.HeaderText = "Status";
            Date.Name = "Date";
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.Font = new Font("Segoe UI", 10F);
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(597, 74);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 25);
            comboBoxClass.TabIndex = 9;
            comboBoxClass.SelectedIndexChanged += ComboBoxClass_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.5F);
            label3.Location = new Point(597, 49);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 8;
            label3.Text = "Class";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(120, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 25);
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
            label2.Font = new Font("Segoe UI", 10.5F);
            label2.Location = new Point(120, 49);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 0;
            label1.Text = "Class Report";
            // 
            // ExportPdf_Button
            // 
            ExportPdf_Button.BackColor = SystemColors.InactiveCaption;
            ExportPdf_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ExportPdf_Button.ForeColor = Color.FromArgb(250, 50, 50);
            ExportPdf_Button.Image = (Image)resources.GetObject("ExportPdf_Button.Image");
            ExportPdf_Button.Location = new Point(915, 609);
            ExportPdf_Button.Name = "ExportPdf_Button";
            ExportPdf_Button.Size = new Size(132, 41);
            ExportPdf_Button.TabIndex = 2;
            ExportPdf_Button.Text = "Export Pdf";
            ExportPdf_Button.TextAlign = ContentAlignment.MiddleLeft;
            ExportPdf_Button.TextImageRelation = TextImageRelation.TextBeforeImage;
            ExportPdf_Button.UseVisualStyleBackColor = false;
            ExportPdf_Button.Click += ExportPdf_Button_click;
            // 
            // ExportExcel_Button
            // 
            ExportExcel_Button.BackColor = SystemColors.InactiveCaption;
            ExportExcel_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ExportExcel_Button.ForeColor = Color.FromArgb(29, 111, 66);
            ExportExcel_Button.Image = Properties.Resources.excel;
            ExportExcel_Button.Location = new Point(1060, 609);
            ExportExcel_Button.Name = "ExportExcel_Button";
            ExportExcel_Button.Size = new Size(132, 41);
            ExportExcel_Button.TabIndex = 3;
            ExportExcel_Button.Text = "Export Excel";
            ExportExcel_Button.TextAlign = ContentAlignment.MiddleLeft;
            ExportExcel_Button.TextImageRelation = TextImageRelation.TextBeforeImage;
            ExportExcel_Button.UseVisualStyleBackColor = false;
            ExportExcel_Button.Click += ExportExcel_Button_Click;
            // 
            // UserControlTeacherReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExportExcel_Button);
            Controls.Add(ExportPdf_Button);
            Controls.Add(tabControl1);
            Name = "UserControlTeacherReport";
            Size = new Size(1289, 710);
            Load += UserControlTeacherReport_Load;
            tabControl1.ResumeLayout(false);
            tabPageMarkAttendence.ResumeLayout(false);
            tabPageMarkAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacherReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TabControl tabControl1;
        public TabPage tabPageMarkAttendence;
        public TabControl tabControl2;
        public TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private DataGridView dataGridViewTeacherReport;
        private ComboBox comboBoxClass;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Date;
        private PictureBox pictureBoxPrint;
        private ToolTip toolTip;
        private Button ExportPdf_Button;
        private Button ExportExcel_Button;
    }
}
