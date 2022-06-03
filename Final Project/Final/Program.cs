using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogIn log = new LogIn();
            /*BookManage manage=new BookManage();*/
            //MenuSelect log = new MenuSelect("NTD");
            Application.Run(log);

        }
    }
}
