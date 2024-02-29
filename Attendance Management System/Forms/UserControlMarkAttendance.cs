using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlMarkAttendance : UserControl
    {
        private string xmlFilePathAttendance = "C:\\Users\\nada elhabshy\\source\\repos\\Attendance_Management_system\\Attendance Management System\\Data\\attendance.xml";
        private string xmlFilePathUsers = "C:\\Users\\nada elhabshy\\source\\repos\\Attendance_Management_system\\Attendance Management System\\Data\\users.xml";
        private string xmlFilePathClasses = "C:\\Users\\nada elhabshy\\source\\repos\\Attendance_Management_system\\Attendance Management System\\Data\\classes.xml";
        private string currentSelectedClassName; // To store the currently selected class name

        public UserControlMarkAttendance()
        {
            InitializeComponent();
        }

        private void UserControlMarkAttendance_Load(object sender, EventArgs e)
        {
            string teacherID = "456"; // Replace this with the actual teacher ID
            LoadClassesForTeacher(teacherID);
        }

        private void LoadClassesForTeacher(string teacherId)
        {
            comboBoxClass.Items.Clear();
            List<string> classNames = LoadClassesForTeacherFromXml(teacherId, xmlFilePathUsers);
            comboBoxClass.Items.AddRange(classNames.ToArray());
        }

        private List<string> LoadClassesForTeacherFromXml(string teacherId, string filename)
        {
            List<string> classNames = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode teacherNode = doc.SelectSingleNode($"//Teacher[ID='{teacherId}']");
            if (teacherNode != null)
            {
                XmlNodeList classNodes = teacherNode.SelectNodes("Class");
                foreach (XmlNode classNode in classNodes)
                {
                    classNames.Add(classNode.InnerText);
                }
            }
            return classNames;
        }

        private List<Attendance> LoadStudentsForClassFromXml(string className, string filename)
        {
            List<Attendance> students = new List<Attendance>();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList studentNodes = doc.SelectNodes($"//Student[Class='{className}']");

            foreach (XmlNode studentNode in studentNodes)
            {
                string name = studentNode.SelectSingleNode("Name").InnerText;
                string id = studentNode.SelectSingleNode("ID").InnerText;
                students.Add(new Attendance(name, id, className));
            }
            return students;
        }

        // Method to get class name from teacher name in users XML file
        private string GetClassNameFromTeacherName(string teacherName, string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            // Select the Teacher node based on the teacher name
            XmlNode teacherNode = doc.SelectSingleNode($"//Teacher[Name='{teacherName}']");
            if (teacherNode != null)
            {
                // Get the Class nodes within the Teacher node
                XmlNodeList classNodes = teacherNode.SelectNodes("Class");
                if (classNodes.Count > 0)
                {
                    // Assuming the teacher is assigned to the first class found
                    return classNodes[0].InnerText;
                }
            }
            return null; // Return null if class name is not found
        }

        private void SaveAttendanceToXml(string filename, string classId)
        {
            // Load the attendance XML file
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            // If the class ID is found, proceed to save attendance
            if (!string.IsNullOrEmpty(classId))
            {
                XmlNode root = doc.DocumentElement;
                XmlNode classNode = doc.SelectSingleNode($"//class[@id='{classId}']");

                // If the class node doesn't exist, create it
                if (classNode == null)
                {
                    classNode = doc.CreateElement("class");
                    XmlAttribute classIdAttribute = doc.CreateAttribute("id");
                    classIdAttribute.Value = classId;
                    classNode.Attributes.Append(classIdAttribute);
                    root.AppendChild(classNode);
                }

                // Create a new record node for each student
                foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        string id = row.Cells[1].Value.ToString();
                        string name = row.Cells[0].Value.ToString();
                        string status = row.Cells[2].Value != null && (bool)row.Cells[2].Value ? "present" : "absent";

                        // Create a new record node
                        XmlNode recordNode = doc.CreateElement("record");

                        // Create child elements for the record
                        XmlNode idNode = doc.CreateElement("id");
                        idNode.InnerText = id;
                        recordNode.AppendChild(idNode);

                        XmlNode nameNode = doc.CreateElement("name");
                        nameNode.InnerText = name;
                        recordNode.AppendChild(nameNode);

                        XmlNode dateNode = doc.CreateElement("date");
                        dateNode.InnerText = DateTime.Now.ToString("yyyy-MM-dd"); // Assuming today's date
                        recordNode.AppendChild(dateNode);

                        XmlNode statusNode = doc.CreateElement("status");
                        statusNode.InnerText = status;
                        recordNode.AppendChild(statusNode);

                        // Append the record node to the class node
                        classNode.AppendChild(recordNode);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Class ID not provided.");
            }

            // Save the modified XML document
            doc.Save(filename);
        }

        private string GetClassIdFromClassXml(string className, string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode classNode = doc.SelectSingleNode($"//Class[Name='{className}']");
            if (classNode != null)
            {
                XmlNode idNode = classNode.SelectSingleNode("ID");
                if (idNode != null)
                {
                    return idNode.InnerText;
                }
            }
            return null;
        }

        private void comboBoxClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedClass = comboBoxClass.SelectedItem.ToString();
            currentSelectedClassName = selectedClass; // Store the currently selected class name
            dataGridViewMarkAttendance.Rows.Clear();
            List<Attendance> students = LoadStudentsForClassFromXml(selectedClass, xmlFilePathUsers);
            foreach (var student in students)
            {
                dataGridViewMarkAttendance.Rows.Add(student.name, student.id, false);
            }
        }

        private void dataGridViewMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentSelectedClassName))
            {
                string classId = GetClassIdFromClassXml(currentSelectedClassName, xmlFilePathClasses);
                if (!string.IsNullOrEmpty(classId))
                {
                    SaveAttendanceToXml(xmlFilePathAttendance, classId);
                    MessageBox.Show("Attendance saved successfully!");
                }
                else
                {
                    MessageBox.Show($"Class ID not found for class name: {currentSelectedClassName}");
                }
            }
            else
            {
                MessageBox.Show("Please select a class first!");
            }
        }
    }
}
