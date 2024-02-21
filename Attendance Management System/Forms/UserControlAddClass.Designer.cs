namespace Attendance_Management_System.Forms
{
    partial class UserControlAddClass
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
            tabControlAddClass = new TabControl();
            tabPageAddClass = new TabPage();
            buttonAdd = new Button();
            labelTeacher = new Label();
            comboBoxTeacher = new ComboBox();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelAdd = new Label();
            tabPageUp = new TabPage();
            buttonDelete = new Button();
            buttonFind = new Button();
            button1 = new Button();
            label1 = new Label();
            comboBoxUpTeacher = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            labelUp = new Label();
            tabControlAddClass.SuspendLayout();
            tabPageAddClass.SuspendLayout();
            tabPageUp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Anchor = AnchorStyles.None;
            tabControlAddClass.Controls.Add(tabPageAddClass);
            tabControlAddClass.Controls.Add(tabPageUp);
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(942, 501);
            tabControlAddClass.TabIndex = 0;
            // 
            // tabPageAddClass
            // 
            tabPageAddClass.Controls.Add(buttonAdd);
            tabPageAddClass.Controls.Add(labelTeacher);
            tabPageAddClass.Controls.Add(comboBoxTeacher);
            tabPageAddClass.Controls.Add(textBoxID);
            tabPageAddClass.Controls.Add(labelID);
            tabPageAddClass.Controls.Add(textBoxName);
            tabPageAddClass.Controls.Add(labelName);
            tabPageAddClass.Controls.Add(labelAdd);
            tabPageAddClass.Location = new Point(4, 4);
            tabPageAddClass.Name = "tabPageAddClass";
            tabPageAddClass.Padding = new Padding(3);
            tabPageAddClass.Size = new Size(934, 468);
            tabPageAddClass.TabIndex = 0;
            tabPageAddClass.Text = "Add Class";
            tabPageAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(525, 263);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(179, 47);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTeacher.Location = new Point(80, 177);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(63, 20);
            labelTeacher.TabIndex = 6;
            labelTeacher.Text = "Teacher";
            // 
            // comboBoxTeacher
            // 
            comboBoxTeacher.FormattingEnabled = true;
            comboBoxTeacher.Location = new Point(80, 210);
            comboBoxTeacher.Name = "comboBoxTeacher";
            comboBoxTeacher.Size = new Size(210, 28);
            comboBoxTeacher.TabIndex = 5;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(506, 125);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(210, 27);
            textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelID.Location = new Point(506, 90);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 20);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(80, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 27);
            textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(80, 90);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAdd.Location = new Point(6, 3);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(77, 20);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Class";
            // 
            // tabPageUp
            // 
            tabPageUp.Controls.Add(buttonDelete);
            tabPageUp.Controls.Add(buttonFind);
            tabPageUp.Controls.Add(button1);
            tabPageUp.Controls.Add(label1);
            tabPageUp.Controls.Add(comboBoxUpTeacher);
            tabPageUp.Controls.Add(textBox1);
            tabPageUp.Controls.Add(label2);
            tabPageUp.Controls.Add(textBox2);
            tabPageUp.Controls.Add(label3);
            tabPageUp.Controls.Add(labelUp);
            tabPageUp.Location = new Point(4, 4);
            tabPageUp.Name = "tabPageUp";
            tabPageUp.Padding = new Padding(3);
            tabPageUp.Size = new Size(934, 468);
            tabPageUp.TabIndex = 1;
            tabPageUp.Text = "Update Class";
            tabPageUp.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.OrangeRed;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(669, 370);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(179, 47);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.DarkSlateBlue;
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFind.ForeColor = Color.White;
            buttonFind.Location = new Point(387, 114);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(182, 41);
            buttonFind.TabIndex = 16;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(484, 370);
            button1.Name = "button1";
            button1.Size = new Size(179, 47);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(94, 238);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 14;
            label1.Text = "Teacher";
            // 
            // comboBoxUpTeacher
            // 
            comboBoxUpTeacher.FormattingEnabled = true;
            comboBoxUpTeacher.Location = new Point(94, 282);
            comboBoxUpTeacher.Name = "comboBoxUpTeacher";
            comboBoxUpTeacher.Size = new Size(210, 28);
            comboBoxUpTeacher.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(94, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(94, 93);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(374, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(374, 238);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // labelUp
            // 
            labelUp.AutoSize = true;
            labelUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUp.Location = new Point(6, 3);
            labelUp.Name = "labelUp";
            labelUp.Size = new Size(99, 20);
            labelUp.TabIndex = 8;
            labelUp.Text = "Update Class";
            // 
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAddClass);
            Name = "UserControlAddClass";
            Size = new Size(942, 501);
            Load += UserControlAddClass_Load;
            tabControlAddClass.ResumeLayout(false);
            tabPageAddClass.ResumeLayout(false);
            tabPageAddClass.PerformLayout();
            tabPageUp.ResumeLayout(false);
            tabPageUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlAddClass;
        private TabPage tabPageAddClass;
        private TabPage tabPageUp;
        private Label labelName;
        private Label labelAdd;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label labelID;
        private Button buttonAdd;
        private Label labelTeacher;
        private ComboBox comboBoxTeacher;
        private Button buttonDelete;
        private Button buttonFind;
        private Button button1;
        private Label label1;
        private ComboBox comboBoxUpTeacher;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label labelUp;
    }
}
