namespace Attendance_Management_System.Forms
{
    partial class Forgot_Password
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
            panel1 = new Panel();
            buttonCancel1 = new Button();
            pictureBoxError = new PictureBox();
            labelError = new Label();
            buttonNext = new Button();
            label4 = new Label();
            panel5 = new Panel();
            textBoxId = new TextBox();
            Email = new Label();
            panel2 = new Panel();
            textBoxEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonCancel1);
            panel1.Controls.Add(pictureBoxError);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 585);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonCancel1
            // 
            buttonCancel1.BackColor = Color.FromArgb(86, 36, 208);
            buttonCancel1.FlatAppearance.BorderSize = 0;
            buttonCancel1.FlatStyle = FlatStyle.Flat;
            buttonCancel1.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            buttonCancel1.ForeColor = Color.White;
            buttonCancel1.Location = new Point(294, 485);
            buttonCancel1.Name = "buttonCancel1";
            buttonCancel1.Size = new Size(330, 50);
            buttonCancel1.TabIndex = 23;
            buttonCancel1.Text = "Cancel";
            buttonCancel1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel1.UseVisualStyleBackColor = false;
            buttonCancel1.Click += buttonCancel1_Click;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = Properties.Resources.important;
            pictureBoxError.Location = new Point(326, 369);
            pictureBoxError.Margin = new Padding(4);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(30, 30);
            pictureBoxError.TabIndex = 22;
            pictureBoxError.TabStop = false;
            pictureBoxError.Visible = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 11F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(365, 374);
            labelError.Name = "labelError";
            labelError.Size = new Size(203, 20);
            labelError.TabIndex = 21;
            labelError.Text = "Invalid Email or National Id";
            labelError.Visible = false;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(86, 36, 208);
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            buttonNext.ForeColor = Color.White;
            buttonNext.Location = new Point(295, 426);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(330, 50);
            buttonNext.TabIndex = 5;
            buttonNext.Text = "Next";
            buttonNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += Next_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label4.Location = new Point(294, 291);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 17;
            label4.Text = "National Id";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBoxId);
            panel5.Location = new Point(295, 319);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 36);
            panel5.TabIndex = 18;
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Location = new Point(5, 7);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(317, 20);
            textBoxId.TabIndex = 2;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            Email.Location = new Point(295, 201);
            Email.Name = "Email";
            Email.Size = new Size(52, 18);
            Email.TabIndex = 11;
            Email.Text = "Email:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxEmail);
            panel2.Location = new Point(296, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 36);
            panel2.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Location = new Point(5, 7);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(317, 20);
            textBoxEmail.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.forge_password;
            pictureBox1.Location = new Point(377, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 585);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Forgot_Password";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log In | Forgot Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Email;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label4;
        private Panel panel5;
        private TextBox textBoxId;
        private Button buttonNext;
        private Label labelError;
        private PictureBox pictureBoxError;
        private Button buttonCancel1;
    }
}