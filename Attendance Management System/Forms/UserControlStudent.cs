using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlStudent : UserControl
    {
        public UserControlStudent()
        {
            InitializeComponent();
        }

        private void UserControlStudent_Load(object sender, EventArgs e)
        {

            ///////////////////////////////
           var recordList = Record.GetRecords(@"C:\Users\nada elhabshy\source\repos\Attendance_Management_system\Attendance Management System\Data\attendance.xml");


            int studentId = 1; // Example student ID
            Record record = Record.getStudentByID(studentId, recordList);


            if (record != null)
            {
                // Bind student data to the DataGridView
               
                    dataGridViewStudent.Rows.Add(record.id, record.name, record.status, record.date);
               
            }
            else
            {
               
                // Clear existing rows
                dataGridViewStudent.Visible = false;

                // Show a message or perform any other actions as needed
                dataGridViewStudent.Visible = true;

            }

        }

        private void tabPageMarkAttendence_Click(object sender, EventArgs e)
        {

        }

      
    }
}
