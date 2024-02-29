using Attendance_Management_System.Classes;
using System.Windows.Forms;
namespace Attendance_Management_System.Forms
{
    public partial class New_Password : Form
    {
        public New_Password()
        {
            InitializeComponent();
        }

        #region handling password icons 
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
        #endregion

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string newPass = textBoxNewPassword.Text.Trim();
            string confirmPass = textBoxConfirmPassword.Text.Trim();
            if (newPass != string.Empty && confirmPass.ToString() != string.Empty)
            {
                if (newPass != confirmPass)
                {
                    labelError.Show();
                    labelError.Text = "your password dosen't match";
                }
                else if (UserValidation.IsComplexPassword(newPass))
                {
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    pictureBoxHide_New_Click(sender, e);
                    pictureBoxHide_Confirm_Click(sender, e);
                    textBoxNewPassword.Focus();
                    labelError.Hide();
                    Close();
                    // UserValidation.UpdatePassword(newPass);
                }
                else
                {
                    labelError.Show();
                    labelError.Text = "The password must be at least 8 characters.\nincluding letters, digits and special characters.";
                }
            }
            else
            {
                labelError.Show();
                labelError.Text = "your password dosen't match";
            }
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
