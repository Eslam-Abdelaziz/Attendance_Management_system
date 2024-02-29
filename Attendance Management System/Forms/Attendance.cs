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
        public string id { get;  set; }
      //  public string date { get;  set; }
     //   public string status { get;  set; }
        public string Class { get;  set; }
        //  public int record { get;  set; }

        public Attendance(string name, string id, string Class)
        {
            this .name = name;
            this .id = id;
            this.Class = Class;
        }


        public static bool  IsMarkAttendance(string date, string className)
        {
            return true;
        }
        public static void displayAndSearchAllData(DataGridView dgv)
        {

        }


    }
}
