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

    private Admin(string name, int id, string email, string password) : base(name, id, email, password){}

    static Admin()
    {
        instance = new Admin("Admin", 1, "admin@example.com", "adminpassword");
    }

    
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
        Name = name;
        Id = id;
        Email = email;
        Password = password;
    }
}

