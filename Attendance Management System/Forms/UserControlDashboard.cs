using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_system.PAL.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private string usersFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/users.xml");
        private string classesFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/classes.xml");
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            XmlDocument users = new XmlDocument();
            users.Load(usersFilePath);
            XmlDocument classes = new XmlDocument();
            classes.Load(classesFilePath);

            XmlNodeList studentNodes = users.SelectNodes("//Student");
            XmlNodeList classesNodes = classes.SelectNodes("//Class");

            labelTotalRole.Text = "3";
            labelTotalStudent.Text=studentNodes.Count.ToString();
            labelTotalClasses.Text = classesNodes.Count.ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
