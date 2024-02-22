using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlAddTeacher : UserControl
    {
        private XDocument teachersDocument;
        private string teachersFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users.xml";
        private string schemaFilePath = @"C:\Iti\C#XML\Attendance_Management_system\Attendance Management System\Data\users_schema.xsd";


        public UserControlAddTeacher()
        {
            InitializeComponent();
            LoadTeachersData();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {

        }



        //private void PopulateClassComboBox()
        //{
        //    // Load the users.xml file
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(teachersFilePath);

        //    // Get all "Class" nodes
        //    XmlNodeList classNodes = doc.SelectNodes("//Class");

        //    // Extract class names and filter out duplicates
        //    HashSet<string> classNames = new HashSet<string>();
        //    foreach (XmlNode node in classNodes)
        //    {
        //        classNames.Add(node.InnerText);
        //    }

        //    // Add unique class names to the combo box
        //    comboBoxClass.Items.AddRange(classNames.ToArray());
        //    comboBoxUpClass.Items.AddRange(classNames.ToArray());
        //    comboBoxClass.SelectedIndex = 0;
        //    comboBoxUpClass.SelectedIndex = 0;
        //}

        private void AddTeacher()
        {
            // Get teacher data from form controls
            string name = textBoxName.Text;
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            //string className = comboBoxClass.SelectedItem.ToString(); // Assuming you have values populated in the combobox

            if (!IsIdUnique(id))
            {
                MessageBox.Show("ID already exists. Please enter a unique ID.");
                return;
            }

            // Check if the email is unique
            if (!IsEmailUnique(email))
            {
                MessageBox.Show("Email already exists. Please enter a unique email.");
                return;
            }

            // Validate teacher data against XML schema
            if (!ValidateTeacherData(name, id, email, password))
            {
                MessageBox.Show("Teacher data is not valid.");
                return;
            }

            // Write teacher data to users.xml file
            WriteTeacherToXml(name, id, email, password);

            MessageBox.Show("Teacher added successfully!");
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPass.Clear();

        }

        private bool IsIdUnique(int id)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(teachersFilePath);

            XmlNodeList teacherNodes = doc.SelectNodes("//Teacher");

            foreach (XmlNode node in teacherNodes)
            {
                int existingId = int.Parse(node.SelectSingleNode("ID").InnerText);

                if (existingId == id)
                {
                    return false; // ID already exists
                }
            }

            return true; // ID is unique
        }
        private bool IsEmailUnique(string email)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(teachersFilePath);

            XmlNodeList teacherNodes = doc.SelectNodes("//Teacher");

            foreach (XmlNode node in teacherNodes)
            {
                string existingEmail = node.SelectSingleNode("Email").InnerText;

                if (existingEmail == email)
                {
                    return false; // Email already exists
                }
            }

            return true; // Email is unique
        }
        private bool IsEmailUnique(string email, string id)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(teachersFilePath);

            XmlNodeList teacherNodes = doc.SelectNodes("//Teacher");

            foreach (XmlNode node in teacherNodes)
            {
                string existingEmail = node.SelectSingleNode("Email").InnerText;
                string existingID = node.SelectSingleNode("ID").InnerText;


                if (existingEmail == email && existingID != id)
                {
                    return false; // Email already exists
                }
            }

            return true; // Email is unique
        }

        // Method to validate teacher data against XML schema
        private bool ValidateTeacherData(string name, int id, string email, string password)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, schemaFilePath);
                settings.ValidationType = ValidationType.Schema;

                using (XmlReader reader = XmlReader.Create(new StringReader("<Teacher><Name>" + name + "</Name><ID>" + id + "</ID><Email>" + email + "</Email><Password>" + password + "</Password></Teacher>"), settings))
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

        private void LoadTeachersData()
        {
            if (File.Exists(teachersFilePath))
            {
                teachersDocument = XDocument.Load(teachersFilePath);
            }
            else
            {
                teachersDocument = new XDocument(new XElement("Teachers"));
                teachersDocument.Save(teachersFilePath);
            }
        }

        private void buttonFInd_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            var teacher = teachersDocument.Descendants("Teacher")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (teacher != null)
            {
                textBoxUpName.Text = teacher.Element("Name").Value;
                textBoxUpEmail.Text = teacher.Element("Email").Value;
                textBoxUpPass.Text = teacher.Element("Password").Value;
                //comboBoxUpClass.SelectedItem = teacher.Element("Class").Value;
            }
            else
            {
                MessageBox.Show("Teacher with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = textBoxUpID.Text.Trim();
            string email = textBoxUpEmail.Text.Trim();
            var teacher = teachersDocument.Descendants("Teacher")
                .FirstOrDefault(s => s.Element("ID").Value == id);

            if (teacher != null)
            {

                if (!IsEmailUnique(email, id))
                {
                    MessageBox.Show("Email already exists. Please enter a unique email.");
                    return;
                }
                // Create a temporary XDocument with the updated teacher data
                var updatedTeacherDocument = new XDocument(

                        new XElement("Teacher",
                            new XElement("Name", textBoxUpName.Text.Trim()),
                            new XElement("ID", textBoxUpID.Text.Trim()),
                            new XElement("Email", textBoxUpEmail.Text.Trim()),
                            new XElement("Password", textBoxUpPass.Text.Trim())
                            //new XElement("Class", comboBoxUpClass.SelectedItem.ToString())
                        )

                );

                // Validate the temporary document against the schema
                if (ValidateTeacherData(updatedTeacherDocument))
                {
                    // Update teacher information
                    teacher.Element("Name").Value = textBoxUpName.Text.Trim();
                    teacher.Element("Email").Value = textBoxUpEmail.Text.Trim();
                    teacher.Element("Password").Value = textBoxUpPass.Text.Trim();
                    //teacher.Element("Class").Value = comboBoxUpClass.SelectedItem.ToString();

                    // Save changes to XML file
                    teachersDocument.Save(teachersFilePath);

                    MessageBox.Show("Teacher information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxUpID.Clear();
                    textBoxUpName.Clear();
                    textBoxUpEmail.Clear();
                    textBoxUpPass.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid teacher data. Please check the entered values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Teacher with the provided ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateTeacherData(XDocument teacherDocument)
        {
            try
            {
                // Load XML schema
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add("", schemaFilePath);

                // Validate the document against the schema
                teacherDocument.Validate(schemaSet, (o, e) =>
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

        // Method to write teacher data to users.xml file
        private void WriteTeacherToXml(string name, int id, string email, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(teachersFilePath);

            XmlElement root = doc.DocumentElement;

            // Create a new teacher node
            XmlElement teacherNode = doc.CreateElement("Teacher");

            // Add child elements for teacher data
            XmlElement nameNode = doc.CreateElement("Name");
            nameNode.InnerText = name;
            teacherNode.AppendChild(nameNode);

            XmlElement idNode = doc.CreateElement("ID");
            idNode.InnerText = id.ToString();
            teacherNode.AppendChild(idNode);

            XmlElement emailNode = doc.CreateElement("Email");
            emailNode.InnerText = email;
            teacherNode.AppendChild(emailNode);

            XmlElement passNode = doc.CreateElement("Password");
            passNode.InnerText = password;
            teacherNode.AppendChild(passNode);

            //XmlElement classNode = doc.CreateElement("Class");
            //classNode.InnerText = className;
            //teacherNode.AppendChild(classNode);

            // Append the teacher node to the root
            root.AppendChild(teacherNode);

            // Save the XML document
            doc.Save(teachersFilePath);
        }

        private void DeleteTeacher()
        {
            // Get the ID of the teacher to delete
            int idToDelete;
            if (!int.TryParse(textBoxUpID.Text, out idToDelete))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }

            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(teachersFilePath);

            // Find the teacher node with the matching ID
            XmlNode teacherNodeToDelete = doc.SelectSingleNode($"//Teacher[ID={idToDelete}]");

            if (teacherNodeToDelete != null)
            {
                // Remove the teacher node from the XML document
                teacherNodeToDelete.ParentNode.RemoveChild(teacherNodeToDelete);

                // Save the changes to the XML file
                doc.Save(teachersFilePath);

                MessageBox.Show("Teacher deleted successfully!");
                textBoxUpID.Clear();
                textBoxUpName.Clear();
                textBoxUpEmail.Clear();
                textBoxUpPass.Clear();
            }
            else
            {
                MessageBox.Show("Teacher not found with the given ID.");
            }
        }

        // Event handler for the Add button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        // Event handler for form load
        //private void UserControlAddTeacher_Load(object sender, EventArgs e)
        //{
        //    PopulateClassComboBox();
        //}

        private void tabControlAddTeacher_Selected(object sender, TabControlEventArgs e)
        {
            LoadTeachersData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }

        
    }



}

