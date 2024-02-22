using Attendance_Management_System.Forms;
using System;
using System.Windows.Forms;


namespace Attendance_Management_system
{
    public partial class FormMain : Form
    {

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*  panelExpand.Hide();*/
            panelExpand.Visible = false;
            /*            labelUsername.Text = Username;
                        labelRole.Text = Role;

                        if (labelRole == "Student")
                        {
                            buttonDashboard.Hide();
                            buttonAddClass.Hide();
                            buttonAddStudent.Hide();
                            buttonRegister.Hide();
                        }*/
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }



        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
            userControlAddTeacher1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddTeacher);
            userControlDashboard1.Visible = false;
            userControlAddTeacher1.Visible = true;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlDashboard1.Visible = false;
            userControlAddTeacher1.Visible = false;
            userControlAddClass1.Visible = true;
            userControlAddStudent1.Visible = false;


        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlDashboard1.Visible = false;
            userControlAddTeacher1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = true;

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashboard1.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlDashboard1.Visible = false;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            {
                panelExpand.Visible = true;
            }
        }

        
    }
}
