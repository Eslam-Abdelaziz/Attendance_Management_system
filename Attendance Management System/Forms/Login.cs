using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }


        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Hide();
            pictureBoxShow.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
            pictureBoxShow.Show();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text.Trim();
            string pass = textBoxPassword.Text.Trim();
            if (username != string.Empty && pass != string.Empty)
            {
                ////string role = isValidNamePass(username, pass);
                //if (role != string.Empty)
                //{
                //    //MainForm mainForm = new MainForm();
                //    textBoxName.Clear();
                //    textBoxPassword.Clear();
                //    pictureBoxHide_click(sender, e);
                //    textBoxName.Focus();
                //    pictureBoxError.Hide();
                //    labelError.Hide();
                //    //mainForm.ShowDialog();
                //}
                //else
                //{
                //    pictureBoxError.Show();
                //    labelError.Show();
                //}
            }

        }

        #region handling Enter key
        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl,true,true,true,true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;

        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }

        }
        #endregion
    }
}
