using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Software_Development
{
    static class Program
    {
        ///<summary>
        ///this class offers a way for every form to show or close the login screen, which all the other forms are based off of
        ///this allows the program to be closed from certain forms, such as the main screen,
        ///as well as a return to the login screen from other forms, such as the new account screen
        ///</summary>
        public class FormsInProgram
        {
            //property of FormsInProgram to access the form itself (which is private)
            public static LoginPage loginInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (login == null)
                    {
                        login = new LoginPage();
                    }
                    return login;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static LoginPage login;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormsInProgram.loginInUse);
        }
    }
}
