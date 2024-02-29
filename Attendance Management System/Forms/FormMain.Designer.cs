namespace Attendance_Management_system
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonRegister = new Button();
            buttonReport = new Button();
            buttonAddStudent = new Button();
            buttonAddClass = new Button();
            buttonAddTeacher = new Button();
            buttonDashboard = new Button();
            panel4 = new Panel();
            panelSlide = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            panel3 = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            labelRole = new Label();
            label7 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            userControlAddTeacher1 = new Attendance_Management_System.Forms.UserControlAddTeacher();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlDashboard1 = new PAL.User_Control.UserControlDashboard();
            userControlAddClass1 = new Attendance_Management_System.Forms.UserControlAddClass();
            userControlAddStudent1 = new Attendance_Management_System.Forms.UserControlAddStudent();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAddStudent);
            panel1.Controls.Add(buttonAddClass);
            panel1.Controls.Add(buttonAddTeacher);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 681);
            panel1.TabIndex = 0;
            // 
            // buttonRegister
            // 
            buttonRegister.Dock = DockStyle.Top;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(8, 415);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 47);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Attendance";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonReport
            // 
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Location = new Point(8, 368);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(250, 47);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "Report";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Dock = DockStyle.Top;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(8, 321);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(250, 47);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Dock = DockStyle.Top;
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Location = new Point(8, 274);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(250, 47);
            buttonAddClass.TabIndex = 0;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.Dock = DockStyle.Top;
            buttonAddTeacher.FlatAppearance.BorderSize = 0;
            buttonAddTeacher.FlatStyle = FlatStyle.Flat;
            buttonAddTeacher.ForeColor = Color.White;
            buttonAddTeacher.Location = new Point(8, 227);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(250, 47);
            buttonAddTeacher.TabIndex = 0;
            buttonAddTeacher.Text = "Add Teacher";
            buttonAddTeacher.UseVisualStyleBackColor = true;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(8, 180);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(250, 47);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelSlide);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 501);
            panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 47);
            panelSlide.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 142);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 103);
            label1.Name = "label1";
            label1.Size = new Size(264, 23);
            label1.TabIndex = 1;
            label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(926, 165);
            panelBack.TabIndex = 3;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(67, 3, 125);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(panel3);
            panelExpand.Location = new Point(720, 58);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 107);
            panelExpand.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Top;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            buttonLogOut.ForeColor = Color.FromArgb(67, 3, 125);
            buttonLogOut.Location = new Point(0, 53);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(198, 48);
            buttonLogOut.TabIndex = 2;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 9F);
            buttonMinimize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMinimize.Location = new Point(0, 5);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(198, 48);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "Minimize";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 5);
            panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(796, 34);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 9;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(730, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelTime.Location = new Point(24, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(35, 23);
            labelTime.TabIndex = 3;
            labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(67, 3, 125);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 65);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(926, 100);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(67, 3, 125);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(154, 57);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(35, 23);
            labelRole.TabIndex = 7;
            labelRole.Text = "{?}";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(67, 3, 125);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 57);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 6;
            label7.Text = "Role:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(67, 3, 125);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(154, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(35, 23);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(67, 3, 125);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 22);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 4;
            label4.Text = "Welcome:";
            // 
            // userControlAddTeacher1
            // 
            userControlAddTeacher1.Location = new Point(258, 165);
            userControlAddTeacher1.Name = "userControlAddTeacher1";
            userControlAddTeacher1.Size = new Size(942, 503);
            userControlAddTeacher1.TabIndex = 8;
            userControlAddTeacher1.Visible = false;
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.BackColor = Color.White;
            userControlDashboard1.Dock = DockStyle.Fill;
            userControlDashboard1.Font = new Font("Century Gothic", 9.75F);
            userControlDashboard1.Location = new Point(258, 165);
            userControlDashboard1.Margin = new Padding(4);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(926, 516);
            userControlDashboard1.TabIndex = 0;
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.Location = new Point(258, 166);
            userControlAddClass1.Margin = new Padding(4, 3, 4, 3);
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.Size = new Size(926, 516);
            userControlAddClass1.TabIndex = 10;
            userControlAddClass1.Visible = false;
            // 
            // userControlAddStudent1
            // 
            userControlAddStudent1.BackColor = Color.White;
            userControlAddStudent1.Location = new Point(258, 166);
            userControlAddStudent1.Margin = new Padding(4, 3, 4, 3);
            userControlAddStudent1.Name = "userControlAddStudent1";
            userControlAddStudent1.Size = new Size(942, 502);
            userControlAddStudent1.TabIndex = 8;
            userControlAddStudent1.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(userControlAddStudent1);
            Controls.Add(userControlAddTeacher1);
            Controls.Add(userControlAddClass1);
            Controls.Add(userControlDashboard1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Management System";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panelBack;
        private Label labelTime;
        private Panel panelTop;
        private Label label4;
        private Label labelRole;
        private Label label7;
        private Label labelUsername;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBox2;
        private Panel panelExpand;
        private Button buttonMinimize;
        private Panel panel3;
        private Button buttonLogOut;
        private Panel panel4;
        private Panel panelSlide;
        private Button buttonAddStudent;
        private Button buttonAddClass;
        private Button buttonAddTeacher;
        private Button buttonDashboard;
        private Button buttonRegister;
        private Button buttonReport;
        private System.Windows.Forms.Timer timerDateAndTime;
        private PAL.User_Control.UserControlDashboard userControlDashboard1;
        private Attendance_Management_System.Forms.UserControlAddClass userControlAddClass1;
        private Attendance_Management_System.Forms.UserControlAddTeacher userControlAddTeacher1;
        private Attendance_Management_System.Forms.UserControlAddStudent userControlAddStudent1;
    }
}
