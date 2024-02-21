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
using System.Xml.Linq;
using System.Xml.Schema;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlAddStudent : UserControl
    {
        private XDocument studentsDocument;
        private string studentsFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml";
        private string schemaFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users_schema.xsd";
        public UserControlAddStudent()
        {
            InitializeComponent();
            LoadStudentsData();

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

        private void LoadStudentsData()
        {
            if (File.Exists(studentsFilePath))
            {
                studentsDocument = XDocument.Load(studentsFilePath);
            }
            else
            {
                studentsDocument = new XDocument(new XElement("Students"));
                studentsDocument.Save(studentsFilePath);
            }
        }

        private void buttonFInd_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            var student = studentsDocument.Descendants("Student")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (student != null)
            {
                textBoxUpName.Text = student.Element("Name").Value;
                textBoxUpEmail.Text = student.Element("Email").Value;
                textBoxUpPass.Text = student.Element("Password").Value;
                comboBoxUpClass.SelectedItem = student.Element("Class").Value;
            }
            else
            {
                MessageBox.Show("Student with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            var student = studentsDocument.Descendants("Student")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (student != null)
            {
                // Create a temporary XDocument with the updated student data
                var updatedStudentDocument = new XDocument(

                        new XElement("Student",
                            new XElement("Name", textBoxUpName.Text.Trim()),
                            new XElement("ID", textBoxUpID.Text.Trim()),
                            new XElement("Email", textBoxUpEmail.Text.Trim()),
                            new XElement("Password", textBoxUpPass.Text.Trim()),
                            new XElement("Class", comboBoxUpClass.SelectedItem.ToString())
                        )

                );

                // Validate the temporary document against the schema
                if (ValidateStudentData(updatedStudentDocument))
                {
                    // Update student information
                    student.Element("Name").Value = textBoxUpName.Text.Trim();
                    student.Element("Email").Value = textBoxUpEmail.Text.Trim();
                    student.Element("Password").Value = textBoxUpPass.Text.Trim();
                    student.Element("Class").Value = comboBoxUpClass.SelectedItem.ToString();

                    // Save changes to XML file
                    studentsDocument.Save(studentsFilePath);

                    MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid student data. Please check the entered values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Student with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateStudentData(XDocument studentDocument)
        {
            try
            {
                // Load XML schema
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add("", schemaFilePath);

                // Validate the document against the schema
                studentDocument.Validate(schemaSet, (o, e) =>
                {

                    throw new Exception(e.Message);
                });

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

        private void tabControlAddStudent_Selected(object sender, TabControlEventArgs e)
        {
            LoadStudentsData();
        }
    }
}