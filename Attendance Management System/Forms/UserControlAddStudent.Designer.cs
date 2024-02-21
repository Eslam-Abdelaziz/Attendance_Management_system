namespace Attendance_Management_System.Forms
{
    partial class UserControlAddStudent
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
            tabControlAddStudent = new TabControl();
            tabPageAdd = new TabPage();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelAdd = new Label();
            tabPageUpdate = new TabPage();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPass = new TextBox();
            labelPass = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            textBoxUpPass = new TextBox();
            labelUpPass = new Label();
            textBoxUpEmail = new TextBox();
            labelUpEmail = new Label();
            textBoxUpID = new TextBox();
            labelUpID = new Label();
            textBoxUpName = new TextBox();
            labelUpName = new Label();
            labelUpdate = new Label();
            comboBoxClass = new ComboBox();
            labelClass = new Label();
            labelUpClass = new Label();
            comboBoxUpClass = new ComboBox();
            tabControlAddStudent.SuspendLayout();
            tabPageAdd.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Anchor = AnchorStyles.None;
            tabControlAddStudent.Controls.Add(tabPageAdd);
            tabControlAddStudent.Controls.Add(tabPageUpdate);
            tabControlAddStudent.Location = new Point(0, 0);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(942, 501);
            tabControlAddStudent.TabIndex = 1;
            // 
            // tabPageAdd
            // 
            tabPageAdd.Controls.Add(labelClass);
            tabPageAdd.Controls.Add(comboBoxClass);
            tabPageAdd.Controls.Add(buttonAdd);
            tabPageAdd.Controls.Add(textBoxPass);
            tabPageAdd.Controls.Add(labelPass);
            tabPageAdd.Controls.Add(textBoxEmail);
            tabPageAdd.Controls.Add(labelEmail);
            tabPageAdd.Controls.Add(textBoxID);
            tabPageAdd.Controls.Add(labelID);
            tabPageAdd.Controls.Add(textBoxName);
            tabPageAdd.Controls.Add(labelName);
            tabPageAdd.Controls.Add(labelAdd);
            tabPageAdd.Location = new Point(4, 4);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(934, 468);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Add Student";
            tabPageAdd.UseVisualStyleBackColor = true;
            tabPageAdd.Click += tabPageAdd_Click;
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
            labelID.Location = new Point(509, 93);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 20);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(83, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 27);
            textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(83, 93);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAdd.Location = new Point(9, 6);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(97, 20);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Student";
            labelAdd.Click += labelAdd_Click;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(labelUpClass);
            tabPageUpdate.Controls.Add(comboBoxUpClass);
            tabPageUpdate.Controls.Add(buttonUpdate);
            tabPageUpdate.Controls.Add(textBoxUpPass);
            tabPageUpdate.Controls.Add(labelUpPass);
            tabPageUpdate.Controls.Add(textBoxUpEmail);
            tabPageUpdate.Controls.Add(labelUpEmail);
            tabPageUpdate.Controls.Add(textBoxUpID);
            tabPageUpdate.Controls.Add(labelUpID);
            tabPageUpdate.Controls.Add(textBoxUpName);
            tabPageUpdate.Controls.Add(labelUpName);
            tabPageUpdate.Controls.Add(labelUpdate);
            tabPageUpdate.Location = new Point(4, 4);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(934, 468);
            tabPageUpdate.TabIndex = 1;
            tabPageUpdate.Text = "Update Student";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(83, 229);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmail.Location = new Point(80, 197);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Location = new Point(506, 229);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(210, 27);
            textBoxPass.TabIndex = 8;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPass.Location = new Point(509, 197);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(76, 20);
            labelPass.TabIndex = 7;
            labelPass.Text = "Password";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(612, 405);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(146, 44);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkSlateBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(612, 405);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(152, 43);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxUpPass
            // 
            textBoxUpPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpPass.Location = new Point(504, 232);
            textBoxUpPass.Name = "textBoxUpPass";
            textBoxUpPass.Size = new Size(210, 27);
            textBoxUpPass.TabIndex = 18;
            // 
            // labelUpPass
            // 
            labelUpPass.AutoSize = true;
            labelUpPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpPass.Location = new Point(507, 200);
            labelUpPass.Name = "labelUpPass";
            labelUpPass.Size = new Size(76, 20);
            labelUpPass.TabIndex = 17;
            labelUpPass.Text = "Password";
            // 
            // textBoxUpEmail
            // 
            textBoxUpEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpEmail.Location = new Point(80, 229);
            textBoxUpEmail.Name = "textBoxUpEmail";
            textBoxUpEmail.Size = new Size(210, 27);
            textBoxUpEmail.TabIndex = 16;
            // 
            // labelUpEmail
            // 
            labelUpEmail.AutoSize = true;
            labelUpEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpEmail.Location = new Point(83, 196);
            labelUpEmail.Name = "labelUpEmail";
            labelUpEmail.Size = new Size(47, 20);
            labelUpEmail.TabIndex = 15;
            labelUpEmail.Text = "Email";
            // 
            // textBoxUpID
            // 
            textBoxUpID.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpID.Location = new Point(504, 125);
            textBoxUpID.Name = "textBoxUpID";
            textBoxUpID.Size = new Size(210, 27);
            textBoxUpID.TabIndex = 14;
            // 
            // labelUpID
            // 
            labelUpID.AutoSize = true;
            labelUpID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpID.Location = new Point(507, 93);
            labelUpID.Name = "labelUpID";
            labelUpID.Size = new Size(25, 20);
            labelUpID.TabIndex = 13;
            labelUpID.Text = "ID";
            // 
            // textBoxUpName
            // 
            textBoxUpName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpName.Location = new Point(80, 125);
            textBoxUpName.Name = "textBoxUpName";
            textBoxUpName.Size = new Size(210, 27);
            textBoxUpName.TabIndex = 12;
            // 
            // labelUpName
            // 
            labelUpName.AutoSize = true;
            labelUpName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpName.Location = new Point(83, 93);
            labelUpName.Name = "labelUpName";
            labelUpName.Size = new Size(51, 20);
            labelUpName.TabIndex = 11;
            labelUpName.Text = "Name";
            // 
            // labelUpdate
            // 
            labelUpdate.AutoSize = true;
            labelUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpdate.Location = new Point(0, 0);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(119, 20);
            labelUpdate.TabIndex = 10;
            labelUpdate.Text = "Update Student";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(83, 323);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(210, 28);
            comboBoxClass.TabIndex = 10;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelClass.Location = new Point(83, 291);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(44, 20);
            labelClass.TabIndex = 11;
            labelClass.Text = "Class";
            // 
            // labelUpClass
            // 
            labelUpClass.AutoSize = true;
            labelUpClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpClass.Location = new Point(83, 302);
            labelUpClass.Name = "labelUpClass";
            labelUpClass.Size = new Size(44, 20);
            labelUpClass.TabIndex = 21;
            labelUpClass.Text = "Class";
            // 
            // comboBoxUpClass
            // 
            comboBoxUpClass.FormattingEnabled = true;
            comboBoxUpClass.Location = new Point(83, 336);
            comboBoxUpClass.Name = "comboBoxUpClass";
            comboBoxUpClass.Size = new Size(210, 28);
            comboBoxUpClass.TabIndex = 20;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Name = "UserControlAddStudent";
            Size = new Size(942, 501);
            tabControlAddStudent.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddStudent;
        private TabPage tabPageAdd;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelAdd;
        private TabPage tabPageUpdate;
        private TextBox textBoxPass;
        private Label labelPass;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonAdd;
        private Button buttonUpdate;
        private TextBox textBoxUpPass;
        private Label labelUpPass;
        private TextBox textBoxUpEmail;
        private Label labelUpEmail;
        private TextBox textBoxUpID;
        private Label labelUpID;
        private TextBox textBoxUpName;
        private Label labelUpName;
        private Label labelUpdate;
        private Label labelClass;
        private ComboBox comboBoxClass;
        private Label labelUpClass;
        private ComboBox comboBoxUpClass;
    }
}
