using Attendance_Management_System.Forms;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class Attendance
    {
        public Attendance()
        {

        }
        public string name { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public string Class { get; set; }
        public int record { get; set; }

        public Attendance(string name, string date, string status, string Class)
        {
            this.name = name;
            this.date = date;
            this.status = status;
            this.Class = Class;
        }


        public static bool IsMarkAttendance(string date, string className)
        {
            return true;
        }
        public static void displayAndSearchAllData(DataGridView dgv)
        {

        }





        public static List<string> LoadClassesForTeacher(string teacherId, string filePath)
        {

            List<string> classNames = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode teacherNode = doc.SelectSingleNode($"//Teacher[ID='{teacherId}']");
            if (teacherNode != null)
            {
                XmlNodeList classNodes = teacherNode.SelectNodes("Class");
                foreach (XmlNode classNode in classNodes)
                {
                    classNames.Add(classNode.InnerText);
                }
            }
            return classNames;
        }

        public static string GetClassIdFromName(string className, string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList classNodes = doc.SelectNodes($"//Class[Name='{className}']");

            if (classNodes.Count > 0)
            {
                XmlNode classNode = classNodes[0];
                return classNode.SelectSingleNode("ID").InnerText;
            }
            else
            {
                return null;
            }
        }

        public static List<Attendance> LoadStudentsForClass(string classId, string filePath)
        {
            List<Attendance> students = new List<Attendance>();
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList classNodes = doc.SelectNodes($"//class[@id='{classId}']/record");

            foreach (XmlNode recordNode in classNodes)
            {
                string name = recordNode.SelectSingleNode("name").InnerText;
                string date = recordNode.SelectSingleNode("date").InnerText;
                string status = recordNode.SelectSingleNode("status").InnerText;

                students.Add(new Attendance(name, date, status, classId.ToString()));
            }
            return students;
        }
    }
}
