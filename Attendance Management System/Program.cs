using Attendance_Management_system;
using Attendance_Management_System.PAL.forms;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Person currentUser = new Person("tempName", -1, "tempName", "tempName");
            //  Application.Run(new Login(currentUser));
            Application.Run(new attendanceTEST());
        }
    }
}