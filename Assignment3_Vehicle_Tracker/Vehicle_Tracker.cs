using System;
using System.Windows.Forms;

namespace Assignment3_Vehicle_Tracker
{
    static class Vehicle_Tracker
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_Veh_Tracker());
        }
    }
}
