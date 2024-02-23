namespace Attendance_Management_System
{
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Constructor
        public Person(string name, int id, string email, string password)
        {
            Name = name;
            Id = id;
            Email = email;
            Password = password;
        }
    }
}