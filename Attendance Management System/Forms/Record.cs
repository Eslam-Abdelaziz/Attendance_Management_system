using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    internal class Record 
    {

        public string name { get; set; }
        public int id { get; set; }
        public DateOnly Date { get; set; }
        public string Status { get; set; }

     
     
        public static List<Record> GetRecords(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList recordList = doc.SelectNodes("//class/record");
            var records = new List<Record>();
            foreach (XmlNode recordNode in recordList)
            {
                Record record1 = new Record()
                {
                    id = int.Parse(recordNode.SelectSingleNode("id").InnerText),
                    name = recordNode.SelectSingleNode("name").InnerText,
                    Date = DateOnly.Parse(recordNode.SelectSingleNode("date").InnerText),
                    Status = recordNode.SelectSingleNode("status").InnerText,
                };
                records.Add(record1);
            }
            return records;
        }

        public static Record getStudentByID(int id, List<Record> studentList)
        {
            foreach (Record student in studentList)
            {
                if (student.id == id)
                { return student; }
            }
            return null;

        }
    }
}
