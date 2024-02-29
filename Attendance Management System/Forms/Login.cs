using Attendance_Management_system;
using Attendance_Management_System.Classes;
namespace Attendance_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login(Person person)
        {
            InitializeComponent();
        }

        private void pictureBoxClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            if (username != string.Empty && pass != string.Empty && UserValidation.IsValidNamePass(username,pass) != null)
            {
                FormMain mainForm = new FormMain(username);
                textBoxName.Clear();
                textBoxPassword.Clear();
                pictureBoxHide_click(sender, e);
                textBoxName.Focus();
                pictureBoxError.Hide();
                labelError.Hide();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                pictureBoxError.Show();
                labelError.Show();
            }

        }

        #region handling Enter key
        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void labeFP_Click(object sender, EventArgs e)
        {
            Person currentUser = new Person("tempName", -1, "tempName", "tempName");
            Forgot_Password forgot_Password = new Forgot_Password(currentUser);
            forgot_Password.ShowDialog();
            textBoxName.Clear();
            textBoxPassword.Clear();
            pictureBoxHide_click(sender, e);
            textBoxName.Focus();
            pictureBoxError.Hide();
            labelError.Hide();
        }
    }
}
