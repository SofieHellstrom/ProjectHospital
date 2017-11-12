using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    static class Program
    {
        static LoginForm login;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DatabaseHandler db = new DatabaseHandler();
            //Employee user = db.LoadEmployee("LÄK11001");
            login = new LoginForm();
            Application.Run(login);
        }

        public static void ShutEverythingDown()
        {
            login.Close();
        }

    }
}
