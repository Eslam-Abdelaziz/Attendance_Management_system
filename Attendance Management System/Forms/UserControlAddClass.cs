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

namespace Attendance_Management_System.Forms
{
    public partial class UserControlAddClass : UserControl
    {
        private XDocument classesDocument;
        private string classesFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\classes.xml";
        private string usersFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml";
        private string schemaFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\classes_schema.xsd";
        public UserControlAddClass()
        {
            InitializeComponent();
            LoadClassesData();
        }

        private void PopulateTeacherComboBox()
        {
            // Load the users.xml file
            XmlDocument doc = new XmlDocument();
            doc.Load(usersFilePath);

            // Get all "Class" nodes
            XmlNodeList teacherNodes = doc.SelectNodes("//Teacher/Name");

            // Extract teacher names and filter out duplicates
            HashSet<string> teacherNames = new HashSet<string>();
            foreach (XmlNode node in teacherNodes)
            {
                teacherNames.Add(node.InnerText);
            }

            // Add unique class names to the combo box
            comboBoxTeacher.Items.AddRange(teacherNames.ToArray());
            comboBoxUpTeacher.Items.AddRange(teacherNames.ToArray());
            comboBoxTeacher.SelectedIndex = 0;
            comboBoxUpTeacher.SelectedIndex = 0;
        }

        private void AddClass()
        {
            // Get student data from form controls
            string name = textBoxName.Text;
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }

            string teacherName = comboBoxTeacher.SelectedItem.ToString();

            if (!IsIdUnique(id))
            {
                MessageBox.Show("ID already exists. Please enter a unique ID.");
                return;
            }


            // Validate student data against XML schema
            if (!ValidateClassData(name, id, teacherName))
            {
                MessageBox.Show("Class data is not valid.");
                return;
            }

            // Write student data to users.xml file
            WriteClassToXml(name, id, teacherName);

            MessageBox.Show("Class added successfully!");
            textBoxID.Clear();
            textBoxName.Clear();

        }

        private bool IsIdUnique(int id)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(classesFilePath);

            XmlNodeList studentNodes = doc.SelectNodes("//Class");

            foreach (XmlNode node in studentNodes)
            {
                int existingId = int.Parse(node.SelectSingleNode("ID").InnerText);

                if (existingId == id)
                {
                    return false; // ID already exists
                }
            }

            return true; // ID is unique
        }

        private bool ValidateClassData(string name, int id, string teacherName)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, schemaFilePath);
                settings.ValidationType = ValidationType.Schema;

                using (XmlReader reader = XmlReader.Create(new StringReader("<Class><ID>" + id + "</ID><Name>" + name + "</Name><Teacher>" + teacherName + "</Teacher></Class>"), settings))
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

        private void WriteClassToXml(string name, int id, string teacherName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(classesFilePath);

            XmlElement root = doc.DocumentElement;

            // Create a new class node
            XmlElement classNode = doc.CreateElement("Class");

            XmlElement idNode = doc.CreateElement("ID");
            idNode.InnerText = id.ToString();
            classNode.AppendChild(idNode);

            XmlElement nameNode = doc.CreateElement("Name");
            nameNode.InnerText = name;
            classNode.AppendChild(nameNode);


            XmlElement teacherNode = doc.CreateElement("Teacher");
            teacherNode.InnerText = teacherName;
            classNode.AppendChild(teacherNode);

            // Append the student node to the root
            root.AppendChild(classNode);

            // Save the XML document
            doc.Save(classesFilePath);
        }

        private void LoadClassesData()
        {
            if (File.Exists(classesFilePath))
            {
                classesDocument = XDocument.Load(classesFilePath);
            }
            else
            {
                classesDocument = new XDocument(new XElement("Classes"));
                classesDocument.Save(classesFilePath);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddClass();
        }

        private void UserControlAddClass_Load(object sender, EventArgs e)
        {
            PopulateTeacherComboBox();
        }

        private void tabControlAddClass_Selected(object sender, TabControlEventArgs e)
        {
            LoadClassesData();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            var classNode = classesDocument.Descendants("Class")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (classNode != null)
            {
                textBoxUpName.Text = classNode.Element("Name").Value;
                comboBoxUpTeacher.SelectedItem = classNode.Element("Teacher").Value;
            }
            else
            {
                MessageBox.Show("Class with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
