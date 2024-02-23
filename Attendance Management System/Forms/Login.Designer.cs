namespace Attendance_Management_System.Forms
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            labelFP = new Label();
            labelError = new Label();
            pictureBoxError = new PictureBox();
            label2 = new Label();
            buttonLogin = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBoxName = new TextBox();
            panel3 = new Panel();
            pictureBoxShow = new PictureBox();
            pictureBoxHide = new PictureBox();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.close;
            pictureBoxClose.Location = new Point(1867, 11);
            pictureBoxClose.Margin = new Padding(4);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(40, 40);
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = Properties.Resources.minimize;
            pictureBoxMinimize.Location = new Point(1820, 11);
            pictureBoxMinimize.Margin = new Padding(4);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(40, 40);
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel3);
            groupBox1.Font = new Font("Century Gothic", 12F);
            groupBox1.Location = new Point(305, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelFP.ForeColor = Color.FromArgb(86, 36, 208);
            labelFP.Location = new Point(201, 298);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(135, 18);
            labelFP.TabIndex = 7;
            labelFP.Text = "Forget password?";
            labelFP.Click += label3_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 11F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(172, 259);
            labelError.Name = "labelError";
            labelError.Size = new Size(230, 20);
            labelError.TabIndex = 6;
            labelError.Text = "Invalid Username or Password";
            labelError.Visible = false;
            labelError.Click += labelError_Click;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = Properties.Resources.important;
            pictureBoxError.Location = new Point(135, 252);
            pictureBoxError.Margin = new Padding(4);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(30, 30);
            pictureBoxError.TabIndex = 5;
            pictureBoxError.TabStop = false;
            pictureBoxError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label2.Location = new Point(110, 163);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(86, 36, 208);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Image = Properties.Resources.login;
            buttonLogin.Location = new Point(110, 346);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(330, 50);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = " Log in ";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label1.Location = new Point(110, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(111, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 45);
            panel2.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(5, 11);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(317, 20);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyPress += textBoxName_KeyPress;
            textBoxName.KeyUp += textBoxName_KeyUp;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBoxShow);
            panel3.Controls.Add(pictureBoxHide);
            panel3.Controls.Add(textBoxPassword);
            panel3.Location = new Point(110, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 45);
            panel3.TabIndex = 9;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = Properties.Resources.show;
            pictureBoxShow.Location = new Point(284, -1);
            pictureBoxShow.Margin = new Padding(4);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Padding = new Padding(5, 5, 0, 0);
            pictureBoxShow.Size = new Size(45, 45);
            pictureBoxShow.TabIndex = 4;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = Properties.Resources.hide;
            pictureBoxHide.ImageLocation = "";
            pictureBoxHide.Location = new Point(284, -1);
            pictureBoxHide.Margin = new Padding(4);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Padding = new Padding(5, 5, 0, 0);
            pictureBoxHide.Size = new Size(45, 45);
            pictureBoxHide.TabIndex = 3;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(6, 11);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(271, 20);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(966, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(1099, 191);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 500);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 17F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(86, 36, 208);
            label3.Location = new Point(1210, 637);
            label3.Name = "label3";
            label3.Size = new Size(311, 27);
            label3.TabIndex = 10;
            label3.Text = "Attendance Management ";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 17F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(86, 36, 208);
            label4.Location = new Point(1310, 667);
            label4.Name = "label4";
            label4.Size = new Size(91, 27);
            label4.TabIndex = 11;
            label4.Text = "System";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12.5F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(43, 1021);
            label5.Name = "label5";
            label5.Size = new Size(313, 19);
            label5.TabIndex = 12;
            label5.Text = "Copyright © 2024. All Right Reserved.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 170, 109);
            label6.Location = new Point(1247, 707);
            label6.Name = "label6";
            label6.Size = new Size(252, 22);
            label6.TabIndex = 10;
            label6.Text = "Designed BY Dev_Dynamos";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(4, 170, 109);
            label7.Location = new Point(352, 1021);
            label7.Name = "label7";
            label7.Size = new Size(142, 23);
            label7.TabIndex = 13;
            label7.Text = "Dev_Dynamos";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1061);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label2;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private Label labelError;
        private PictureBox pictureBoxError;
        private Label labelFP;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxName;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ToolTip toolTip;
    }
}