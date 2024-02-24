using Attendance_Management_System.Classes;
namespace Attendance_Management_System.Forms
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password(Person person)
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            int id = int.Parse(textBoxId.Text.Trim());
            if (email != string.Empty && id.ToString() != string.Empty && UserValidation.GetUserByEmailAndId(email, id) != null)
            {
                textBoxEmail.Clear();
                textBoxId.Clear();
                textBoxEmail.Focus();
                pictureBoxError.Hide();
                labelError.Hide();
                New_Password new_Password = new New_Password();
                new_Password.ShowDialog();
                Close();
            }
            else
            {
                pictureBoxError.Show();
                labelError.Show();
            }
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region handling Enter key
        private void textBoxEmail_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxEmail_keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonNext.PerformClick();
                e.Handled = true;
            }
        }

        private void textBoxId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        #endregion
    }
}
