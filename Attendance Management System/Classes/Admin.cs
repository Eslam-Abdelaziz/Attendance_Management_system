using Attendance_Management_System;
using System.Xml;

public sealed class Admin : Person
{
    // Singleton instance field
    private static readonly Admin instance;

    // Public static property to access the single instance
    public static Admin Instance
    {
        get { return instance; }
    }

    // Private constructor to prevent external instantiation
    private Admin(string name, int id, string email, string password) : base(name, id, email, password){}

    // Static constructor to initialize the singleton instance with dummy data
    static Admin()
    {
        // Initialize the singleton instance with dummy data
        instance = new Admin("Admin", 1, "admin@example.com", "adminpassword");
    }

    // Convert relative path to absolute path
    // string absoluteXmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../Data/users.xml");
    
    // Method to save admin data to XML file
    public void SaveToXml(string xmlFilePath)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        XmlElement adminElement = xmlDoc.CreateElement("Admin");
        adminElement.SetAttribute("Id", Id.ToString());
        adminElement.SetAttribute("Name", Name);
        adminElement.SetAttribute("Email", Email);
        adminElement.SetAttribute("Password", Password);

        xmlDoc.AppendChild(adminElement);
        xmlDoc.Save(xmlFilePath);
    }

    // Method to update admin data
    public void UpdateData(string name, int id, string email, string password)
    {
        // Update admin properties with new data
        Name = name;
        Id = id;
        Email = email;
        Password = password;
    }
}

