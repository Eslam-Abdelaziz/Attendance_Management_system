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

namespace Attendance_Management_System.Forms
{
    public partial class UserControlAddStudent : UserControl
    {
        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {

        }

        private void PopulateClassComboBox()
        {
            // Load the users.xml file
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml");

            // Get all "Class" nodes
            XmlNodeList classNodes = doc.SelectNodes("//Class");

            // Extract class names and filter out duplicates
            HashSet<string> classNames = new HashSet<string>();
            foreach (XmlNode node in classNodes)
            {
                classNames.Add(node.InnerText);
            }

            // Add unique class names to the combo box
            comboBoxClass.Items.AddRange(classNames.ToArray());
            comboBoxUpClass.Items.AddRange(classNames.ToArray());
        }

        private void AddStudent()
        {
            // Get student data from form controls
            string name = textBoxName.Text;
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            string className = comboBoxClass.SelectedItem.ToString(); // Assuming you have values populated in the combobox

            // Validate student data against XML schema
            if (!ValidateStudentData(name, id, email, password, className))
            {
                MessageBox.Show("Student data is not valid.");
                return;
            }

            // Write student data to users.xml file
            WriteStudentToXml(name, id, email, password, className);

            MessageBox.Show("Student added successfully!");
        }

        // Method to validate student data against XML schema
        private bool ValidateStudentData(string name, int id, string email, string password, string className)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users_schema.xsd"); // Replace "your_schema.xsd" with the path to your XML schema file
                settings.ValidationType = ValidationType.Schema;

                using (XmlReader reader = XmlReader.Create(new StringReader("<Student><Name>" + name + "</Name><ID>" + id + "</ID><Email>" + email + "</Email><Password>" + password + "</Password><Class>" + className + "</Class></Student>"), settings))
                {
                    while (reader.Read()) { }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML validation error: " + ex.Message);
                return false;
            }
        }

        // Method to write student data to users.xml file
        private void WriteStudentToXml(string name, int id, string email, string password, string className)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml");

            XmlElement root = doc.DocumentElement;

            // Create a new student node
            XmlElement studentNode = doc.CreateElement("Student");

            // Add child elements for student data
            XmlElement nameNode = doc.CreateElement("Name");
            nameNode.InnerText = name;
            studentNode.AppendChild(nameNode);

            XmlElement idNode = doc.CreateElement("ID");
            idNode.InnerText = id.ToString();
            studentNode.AppendChild(idNode);

            XmlElement emailNode = doc.CreateElement("Email");
            emailNode.InnerText = email;
            studentNode.AppendChild(emailNode);

            XmlElement passNode = doc.CreateElement("Password");
            passNode.InnerText = password;
            studentNode.AppendChild(passNode);

            XmlElement classNode = doc.CreateElement("Class");
            classNode.InnerText = className;
            studentNode.AppendChild(classNode);

            // Append the student node to the root
            root.AppendChild(studentNode);

            // Save the XML document
            doc.Save(@"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml");
        }

        // Event handler for the Add button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        // Event handler for form load
        private void UserControlAddStudent_Load(object sender, EventArgs e)
        {
            PopulateClassComboBox();
        }

    }
}