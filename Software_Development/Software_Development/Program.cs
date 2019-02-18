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

            //property of FormsInProgram to access the form itself (which is private)
            public static DashboardPage dashboardInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (dash == null)
                    {
                        dash = new DashboardPage();
                    }
                    return dash;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static DashboardPage dash;

            //property of FormsInProgram to access the form itself (which is private)
            public static CalendarPage calInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (calendar == null)
                    {
                        calendar = new CalendarPage();
                    }
                    return calendar;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static CalendarPage calendar;

            //property of FormsInProgram to access the form itself (which is private)
            public static ForumPage forumInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (forum == null)
                    {
                        forum = new ForumPage();
                    }
                    return forum;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static ForumPage forum;

            //property of FormsInProgram to access the form itself (which is private)
            public static MessagingPage messagingInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (msg == null)
                    {
                        msg = new MessagingPage();
                    }
                    return msg;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static MessagingPage msg;

            //property of FormsInProgram to access the form itself (which is private)
            public static ResourcesPage resourcesInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (resources == null)
                    {
                        resources = new ResourcesPage();
                    }
                    return resources;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static ResourcesPage resources;

            public static void logout()
            {
                dashboardInUse.Close();
                calInUse.Close();
                forumInUse.Close();
                messagingInUse.Close();
                resourcesInUse.Close();

                loginInUse.Show();
            }

            public static void exitApp()
            {
                dashboardInUse.Close();
                calInUse.Close();
                forumInUse.Close();
                messagingInUse.Close();
                resourcesInUse.Close();
                loginInUse.Close();
            }

            public static void showDash()
            {

            }

            public static void showCal()
            {

            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //initialize a splash screen for use
            SplashScreen splash = new SplashScreen();
            //show the splash screen while the rest of the program loads
            splash.ShowDialog();
            //finally, run a login screen that is called from the class defined earlier
            Application.Run(FormsInProgram.loginInUse);
        }
    }
}
