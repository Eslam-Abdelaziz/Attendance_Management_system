using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public class Attendance
    {
        public Attendance()
        {

        }
        public string name { get;  set; }
        public int id { get;  set; }
      //  public string date { get;  set; }
     //   public string status { get;  set; }
        public int Class { get;  set; }
      //  public int record { get;  set; }




        public static bool  IsMarkAttendance(string date, string className)
        {
            return true;
        }
        public static void displayAndSearchAllData(DataGridView dgv)
        {

        }


    }
}
