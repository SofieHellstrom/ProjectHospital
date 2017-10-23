using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    static class Program
    {
        public static Employee emp; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DatabaseHandler db = new DatabaseHandler();
            //Employee user = db.LoadEmployee("LÄK11001");
            Application.Run(new LoginForm());
        }

    }
}
