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
    public partial class UserControlMarkAttendance : UserControl
    {
        private string sql;
        private bool okay;
        public UserControlMarkAttendance()
        {
            InitializeComponent();
            dataGridViewMarkAttendence.Columns["column1"].Visible = false;
            dataGridViewMarkAttendence.Columns["column5"].Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // if(Attendence.Attendence.isMarkAttendence(dateTimePicker1.Text,comboBoxClass.SelectedItem.ToString(),sql))
           // {
           //     Attendence.Attendence.displayAndSearchAllData("");
           // }
        }
    }
}
