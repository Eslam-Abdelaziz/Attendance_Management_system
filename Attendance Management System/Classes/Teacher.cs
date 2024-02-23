namespace Attendance_Management_System.Forms
{
    public class Teacher : Person
    {
        // Properties
        public string Class { get; set; }
        public decimal Salary { get; set; }

        // Constructor
        public Teacher(string name, int id, string email, string password, string _class, decimal salary)
            : base(name, id, email, password)
        {
            Class = _class;
            Salary = salary;
        }
    }
}