using System.Text.RegularExpressions;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class UserValidation
    {

        public static bool IsComplexPassword(string password)
        {
            Regex charRegex = new Regex("[a-zA-Z]");
            Regex digitRegex = new Regex("\\d");
            Regex specialCharRegex = new Regex("[!@#$%^&*(),.?\":{}|<>]");

            bool hasChar = charRegex.IsMatch(password);
            bool hasDigit = digitRegex.IsMatch(password);
            bool hasSpecialChar = specialCharRegex.IsMatch(password);
            bool isLongEnough = password.Length > 8;

            return hasChar && hasDigit && hasSpecialChar && isLongEnough;
        }


        public static string IsValidNamePass(string username, string password)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string XmlFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../Data/users.xml"));
            Console.WriteLine(XmlFilePath);
            xmlDoc.Load(XmlFilePath); 
            XmlNodeList userList = xmlDoc.SelectNodes("//Users/*");

            foreach (XmlNode userNode in userList)
            {
                string email = userNode.SelectSingleNode("Email").InnerText;
                string storedPassword = userNode.SelectSingleNode("Password").InnerText;
                string role = userNode.Name;

                if (username.Equals(email, StringComparison.OrdinalIgnoreCase) && password.Equals(storedPassword))
                {
                    return role;
                }
            }

            return null;
        }


        public static void UpdatePassword(int userId, string newPassword)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string XmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/users.xml");
            xmlDoc.Load(XmlFilePath);

            XmlNodeList userList = xmlDoc.SelectNodes("//Users/*");

            foreach (XmlNode userNode in userList)
            {
                XmlNode idNode = userNode.SelectSingleNode("ID");
                if (idNode != null && idNode.InnerText == userId.ToString())
                {
                    XmlNode passwordNode = userNode.SelectSingleNode("Password");
                    if (passwordNode != null)
                    {
                        passwordNode.InnerText = newPassword;
                        break;
                    }
                }
            }

            xmlDoc.Save("users.xml");
        }

        public static XmlNode GetUserByEmailAndId(string email, int id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string XmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/users.xml");
            xmlDoc.Load(XmlFilePath);
            XmlNodeList userList = xmlDoc.SelectNodes("//Users/*");

            foreach (XmlNode userNode in userList)
            {
                XmlNode emailNode = userNode.SelectSingleNode("Email");
                XmlNode idNode = userNode.SelectSingleNode("ID");
                if (emailNode != null && idNode != null && emailNode.InnerText == email && idNode.InnerText == id.ToString())
                {
                    return userNode;
                }
            }
            return null; 
        }
    }
}
