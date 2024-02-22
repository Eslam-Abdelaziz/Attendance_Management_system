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
            AddClassToTeacher(teacherName, name);

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

        private void AddClassToTeacher(string teacherName,string className) {
            XmlDocument doc = new XmlDocument();
            doc.Load(usersFilePath);

            XmlNode teacherNode = doc.SelectSingleNode($"//Teacher[Name='{teacherName}']");
            if (teacherNode != null)
            {
                XmlNode newClassNode = doc.CreateElement("Class");
                newClassNode.InnerText = className;
                teacherNode.AppendChild(newClassNode);
            }

            doc.Save(usersFilePath);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            string name = textBoxUpName.Text.Trim();
            string teacher = comboBoxUpTeacher.SelectedItem.ToString();
            var classNode = classesDocument.Descendants("Class")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (classNode != null)
            {

                if (!IsNameUnique(name, id))
                {
                    MessageBox.Show("Name already exists. Please enter a unique name.");
                    return;
                }
                // Create a temporary XDocument with the updated student data
                var updatedClassDocument = new XDocument(

                        new XElement("Class",
                             new XElement("ID", textBoxUpID.Text.Trim()),
                            new XElement("Name", textBoxUpName.Text.Trim()),
                            new XElement("Teacher", comboBoxUpTeacher.SelectedItem.ToString())
                        )

                );

                // Validate the temporary document against the schema
                if (ValidateClassData(updatedClassDocument))
                {

                    TransferClassToNewTeacher(classNode.Element("Name").Value, classNode.Element("Teacher").Value, teacher);
                    UpdateClassNames(classNode.Element("Name").Value, name);

                    // Update class information
                    classNode.Element("Name").Value = textBoxUpName.Text.Trim();
                    classNode.Element("Teacher").Value = comboBoxUpTeacher.SelectedItem.ToString();

                    // Save changes to XML file
                    classesDocument.Save(classesFilePath);


                    MessageBox.Show("Class information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Class data. Please check the entered values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Class with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateClassData(XDocument classsDocument)
        {
            try
            {
                // Load XML schema
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add("", schemaFilePath);

                // Validate the document against the schema
                classsDocument.Validate(schemaSet, (o, e) =>
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
        private bool IsNameUnique(string name, string id)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(classesFilePath);

            XmlNodeList classNodes = doc.SelectNodes("//Class");

            foreach (XmlNode node in classNodes)
            {
                string existingName = node.SelectSingleNode("Name").InnerText;
                string existingID = node.SelectSingleNode("ID").InnerText;


                if (existingName == name && existingID != id)
                {
                    return false; // Name already exists
                }
            }

            return true; //  Name is unique
        }
        private void UpdateClassNames(string oldName, string updatedName)
        {
            // Load the XML file
            XmlDocument doc = new XmlDocument();
            doc.Load(usersFilePath);

            // Select all <Class> nodes with the old class name
            XmlNodeList classNodes = doc.SelectNodes($"//Class[text()='{oldName}']");

            // Update each <Class> node with the new class name
            foreach (XmlNode node in classNodes)
            {
                node.InnerText = updatedName;
            }

            // Save the changes back to the XML file
            doc.Save(usersFilePath);
        }

        private void TransferClassToNewTeacher(string className, string oldTeacherName, string newTeacherName)
        {
            // Load the XML file
            XmlDocument doc = new XmlDocument();
            doc.Load(usersFilePath); 

            // Find the <Teacher> node with the old teacher's name
            XmlNode oldTeacherNode = doc.SelectSingleNode($"//Teacher[Name='{oldTeacherName}']");
            if (oldTeacherNode == null)
            {
                // Old teacher not found
                return;
            }

            // Find the <Class> node with the specified class name under the old teacher
            XmlNode classNode = oldTeacherNode.SelectSingleNode($"Class[text()='{className}']");
            if (classNode == null)
            {
                // Class not found under the old teacher
                return;
            }

            // Remove the <Class> node from the old teacher's node
            oldTeacherNode.RemoveChild(classNode);

            // Find or create the <Teacher> node with the new teacher's name
            XmlNode newTeacherNode = doc.SelectSingleNode($"//Teacher[Name='{newTeacherName}']");
            if (newTeacherNode != null)
            {
                // New teacher not found, create a new <Teacher> node
                XmlNode newClassNode = doc.CreateElement("Class");
                newClassNode.InnerText = className;
                newTeacherNode.AppendChild(newClassNode);
            }


            // Save the changes back to the XML file
            doc.Save(usersFilePath);
        }

        private void DeleteClass()
        {
            // Get the ID of the student to delete
            int idToDelete;
            string name = textBoxUpName.Text;
            if (!int.TryParse(textBoxUpID.Text, out idToDelete))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }

            // Load the XML document
            XmlDocument doc = new XmlDocument();
            XmlDocument users = new XmlDocument();
            doc.Load(classesFilePath);
            users.Load(usersFilePath);

            // Check if any student has the same class name

            XmlNodeList studentNodes = users.SelectNodes($"//Student[Class='{name}']");
            if (studentNodes.Count > 0)
            {
                MessageBox.Show($"Cannot delete class '{name}' because there are students associated with it.");
                return;
            }

            // Find the student node with the matching ID
            XmlNode classNodeToDelete = doc.SelectSingleNode($"//Class[ID={idToDelete}]");

            if (classNodeToDelete != null)
            {
                // Remove the student node from the XML document
                classNodeToDelete.ParentNode.RemoveChild(classNodeToDelete);

                // Save the changes to the XML file
                doc.Save(classesFilePath);
                RemoveClassFromTeacher(name);

                MessageBox.Show("Class deleted successfully!");
            }
            else
            {
                MessageBox.Show("Class not found with the given ID.");
            }
        }

        private void RemoveClassFromTeacher(string className)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(usersFilePath);

            XmlNode classNodeToDelete = doc.SelectSingleNode($"//Teacher//Class[text()='{className}']");
            if (classNodeToDelete != null)
            {
                classNodeToDelete.ParentNode.RemoveChild(classNodeToDelete);
            }

            doc.Save(usersFilePath);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }
    }
}
