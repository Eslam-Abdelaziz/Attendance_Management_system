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
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPageAddClass = new TabPage();
            tabPage2 = new TabPage();
            labelAdd = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            labelID = new Label();
            tabControlAddClass.SuspendLayout();
            tabPageAddClass.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Anchor = AnchorStyles.None;
            tabControlAddClass.Controls.Add(tabPageAddClass);
            tabControlAddClass.Controls.Add(tabPage2);
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(942, 501);
            tabControlAddClass.TabIndex = 0;
            // 
            // tabPageAddClass
            // 
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(80, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 27);
            textBoxName.TabIndex = 2;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(506, 125);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(210, 27);
            textBoxID.TabIndex = 4;
            textBoxID.TextChanged += textBox1_TextChanged;
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
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAddClass);
            Name = "UserControlAddClass";
            Size = new Size(942, 501);
            tabControlAddClass.ResumeLayout(false);
            tabPageAddClass.ResumeLayout(false);
            tabPageAddClass.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlAddClass;
        private TabPage tabPageAddClass;
        private TabPage tabPage2;
        private Label labelName;
        private Label labelAdd;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label labelID;
    }
}
