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

namespace Attendance_Management_System.Forms
{
    public partial class UserControlMarkAttendance : UserControl
    {

        private DataTable studentsTable;
        private string xmlFilePath = "C:\\Users\\nada elhabshy\\source\\repos\\Attendance_Management_system\\Attendance Management System\\Data\\attendance.xml";

        public UserControlMarkAttendance()
        {
            InitializeComponent();

        }
        private void UserControlMarkAttendance_Load(object sender, EventArgs e)
        {


            // Load student data from XML file

            LoadStudentsFromXml();



        }



        private void LoadStudentsFromXml()
        {
            // Load student data from XML file
            studentsTable = new DataTable();

            studentsTable.Columns.Add("ID");
            studentsTable.Columns.Add("Name");
            studentsTable.Columns.Add("Class");
            studentsTable.Columns.Add("Present", typeof(bool));

            if (File.Exists(xmlFilePath))
            {
                XDocument doc = XDocument.Load(xmlFilePath);
                foreach (XElement classElement in doc.Root.Elements("class"))
                {
                    foreach (XElement recordElement in classElement.Elements("record"))
                    {
                        DataRow row = studentsTable.NewRow();
                        row["Present"] = recordElement.Element("status").Value.ToLower() == "present";
                        row["ID"] = recordElement.Element("id").Value;
                        row["Name"] = recordElement.Element("name").Value;
                        row["Class"] = classElement.Attribute("id").Value;
                        studentsTable.Rows.Add(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("XML file not found.");
            }

            // Bind data to DataGridView
            dataGridViewMarkAttendance.DataSource = studentsTable;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Get selected date from DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Save attendance to XML file
            XDocument doc = new XDocument(
                new XElement("attendance",
                    new XElement("class", new XAttribute("id", "101"), // Assuming a constant class ID for simplicity
                        from row in studentsTable.AsEnumerable()
                        select new XElement("record",
                            new XElement("id", row["ID"]),
                            new XElement("name", row["Name"]),
                            new XElement("date", selectedDate.ToString("yyyy-MM-dd")),
                            new XElement("status", (bool)row["Present"] ? "present" : "absent")
                        )
                    )
                )
            );
            doc.Save(xmlFilePath);
            MessageBox.Show("Attendance saved successfully.");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



   

       

      
       
    

