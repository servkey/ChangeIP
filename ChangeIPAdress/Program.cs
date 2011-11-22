using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace ChangeIPAdress
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            ResourceManager LocRM = new ResourceManager("ChangeIPAdress.Resources.ChangeIPWin", typeof(Win.FrmMain).Assembly);
            // Assign the string for the "strMessage" key to a message box.
            //MessageBox.Show(LocRM.GetString("strMessage"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Win.FrmMain());


        }
    }
}
