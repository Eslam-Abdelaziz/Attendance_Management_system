using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_Management_System.Forms
{
    public partial class New_Password : Form
    {
        public New_Password()
        {
            InitializeComponent();
        }

        private void pictureBoxShow_Confirm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow_Confirm, "Show Password");
        }
        private void pictureBoxHide_Confirm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow_Confirm, "Hide Password");
        }
        private void pictureBoxShow_New_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow_Confirm, "Show Password");
        }
        private void pictureBoxHide_New_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow_Confirm, "Hide Password");
        }

        private void pictureBoxShow_Confirm_Click(object sender, EventArgs e)
        {
            textBoxConfirmPassword.UseSystemPasswordChar = false;
            pictureBoxShow_Confirm.Hide();
            pictureBoxHide_Confirm.Show();
        }
        private void pictureBoxHide_Confirm_Click(object sender, EventArgs e)
        {
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            pictureBoxShow_Confirm.Show();
            pictureBoxHide_Confirm.Hide();
        }
        private void pictureBoxShow_New_Click(object sender, EventArgs e)
        {
            textBoxNewPassword.UseSystemPasswordChar = false;
            pictureBoxShow_New.Hide();
            pictureBoxHide_New.Show();
        }
        private void pictureBoxHide_New_Click(object sender, EventArgs e)
        {
            textBoxNewPassword.UseSystemPasswordChar = true;
            pictureBoxShow_New.Show();
            pictureBoxHide_New.Hide();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {

        }
    }
}
