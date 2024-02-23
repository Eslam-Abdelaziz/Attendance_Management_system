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

        public bool IsMarkAttendance(string date, string className)
        {
            return true;
        }




     /*   public static List<Student> GetStudents(string path)
        {
            var students = new List<Student>();

            // Load the XML file
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Get all student nodes
            XmlNodeList studentList = doc.SelectNodes("//students/student");

            // Iterate through each student
            foreach (XmlNode studentNode in studentList)
            {
                Student s1 = new Student()
                {
                    ID = int.Parse(studentNode.SelectSingleNode("id").InnerText),
                    Name = studentNode.SelectSingleNode("name").InnerText,
                    BirthDate = DateTime.ParseExact(studentNode.SelectSingleNode("birthDate").InnerText, "yyyy-MM-dd", null), // Parsing using specific format
                    Email = studentNode.SelectSingleNode("email").InnerText,
                    MobileNumber = studentNode.SelectSingleNode("mobileNo").InnerText,
                    TrackName = studentNode.SelectSingleNode("trackName").InnerText


                };

                s1.AttendaceHistory = new List<AttendanceItem>();
                // Get attendance information
                XmlNodeList attendanceList = studentNode.SelectNodes("attendance/item");
                foreach (XmlNode attendanceNode in attendanceList)
                {
                    AttendanceItem attendance = new AttendanceItem()
                    {
                        TeacherID = int.Parse(attendanceNode.SelectSingleNode("teacherID").InnerText),
                        Date = DateOnly.Parse(attendanceNode.SelectSingleNode("date").InnerText),
                        State = (AttendanceState)Enum.Parse(typeof(AttendanceState), attendanceNode.SelectSingleNode("state").InnerText, ignoreCase: true)


                    };
                    s1.AttendaceHistory.Add(attendance);
                }//end of second foreach
                students.Add(s1);

            }

            return students;
        }
        public static Student getStudentByID(int id, List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                if (student.ID == id)
                { return student; }
            }
            return null;

        }*/
    }
}
