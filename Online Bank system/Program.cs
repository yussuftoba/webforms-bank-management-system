using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Bank_system
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms.Login log = new Forms.Login();
            Application.Run(log);

            if(log.UserSuccessfullyAuthenticated)
            {
                MainApp ma = new MainApp(log.username);
                Application.Run(ma);
            }
        }
    }
}
