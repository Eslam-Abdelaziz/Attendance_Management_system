namespace Attendance_Management_System.Forms
{
    public class Student : Person
    {
        // Properties
        public string Class { get; set; }

        // Constructor
        public Student(string name, int id, string email, string password, string _class)
            : base(name, id, email, password)
        {
            Class = _class;
        }
    }
}