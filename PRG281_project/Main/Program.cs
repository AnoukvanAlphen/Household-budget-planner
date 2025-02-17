using Goals_PRG281_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goals_PRG281_project
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        interface INavigator
        {
            void GotoMainMenu();
            void GotoCurrentGoals();

            void GotoGoalSettings();


        }

        [STAThread]
        static void Main()
        {
            //Application.Run(new frmLoadingScreen());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoadingScreen());
        }
    }
}
