using Meeting_Scheduling_System.ControllerTrusted;
using Meeting_Scheduling_System.Veiw_UnTrusted;
using System;
using System.Windows.Forms;
namespace Meeting_Scheduling_System.VeiwUnTrusted
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
            AccountController.fill();
            RoomController.fill();


            Application.Run(new Welcome());
           
            
        }
    }
}