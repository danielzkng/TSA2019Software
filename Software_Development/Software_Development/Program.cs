using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Software_Development
{
    static class Program
    {
        [DllImport("shell32.dll", SetLastError = true)]
        static extern void SetCurrentProcessExplicitAppUserModelID(
        [MarshalAs(UnmanagedType.LPWStr)] string AppID);

        private static string AppID = "Edutalk.Edutalk";

        ///<summary>
        ///this class offers a way for every form to show or close the login screen, which all the other forms are based off of
        ///this allows the program to be closed from certain forms, such as the main screen,
        ///as well as a return to the login screen from other forms, such as the new account screen
        ///</summary>
        public class WindowManager
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

            //property of FormsInProgram to access the form itself (which is private)
            public static ProfilePage profileInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (profile == null)
                    {
                        profile = new ProfilePage();
                    }
                    return profile;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static ProfilePage profile;

            public static NotifyIcon notifier;
            private static ContextMenu sysTrayMenu;
            private static MenuItem exitMenuItem;
            private static IContainer menuComponents;

            public static void logout()
            {
                GlobalData.ExportCurrentUser();

                loginInUse.Show();

                dashboardInUse.Hide();
                calInUse.Close();
                forumInUse.Close();
                messagingInUse.Close();
                resourcesInUse.Close();
                GlobalData.CurrentUser = null;
                GlobalData.firstLoad = true;
                
                notifier.Dispose();
            }

            public static void exitApp()
            {
                dashboardInUse.Close();
                calInUse.Close();
                forumInUse.Close();
                messagingInUse.Close();
                resourcesInUse.Close();
                loginInUse.Close();
                if(notifier != null) notifier.Dispose();
            }

            public static void initializeForms()
            {
                dashboardInUse.Hide();
                calInUse.Hide();
                forumInUse.Hide();
                messagingInUse.Hide();
                resourcesInUse.Hide();
                profileInUse.Hide();
                initializeNotifier();
            }

            public static void initializeNotifier()
            {
                menuComponents = new Container();
                sysTrayMenu = new System.Windows.Forms.ContextMenu();
                exitMenuItem = new System.Windows.Forms.MenuItem();

                // Initialize contextMenu
                sysTrayMenu.MenuItems.AddRange(
                            new System.Windows.Forms.MenuItem[] { exitMenuItem });

                // Initialize menuItem1
                exitMenuItem.Index = 0;
                exitMenuItem.Text = "E&xit";
                exitMenuItem.Click += new System.EventHandler(exitMenuItem_Click);

                notifier = new System.Windows.Forms.NotifyIcon(menuComponents);

                notifier.Icon = new Icon("..\\..\\Resources\\robot.ico");
                notifier.ContextMenu = sysTrayMenu;
                notifier.Text = "EduTalk";
                notifier.Visible = true;

                notifier.DoubleClick += new System.EventHandler(notifier_DoubleClick);
                notifier.BalloonTipClicked += new System.EventHandler(notifier_BalloonClick);
            }

            private static void exitMenuItem_Click(object Sender, EventArgs e)
            {
                // Close the form, which closes the application.
                exitApp();
            }

            private static void notifier_BalloonClick(object Sender, EventArgs e)
            {
                calInUse.Hide();
                forumInUse.Hide();
                messagingInUse.Hide();
                resourcesInUse.Hide();
                profileInUse.Hide();
                loginInUse.Hide();

                //create and show a new daily poll form
                DailyPoll poll = new DailyPoll();
                dashboardInUse.Hide();
                dashboardInUse.ShowInTaskbar = false;
                poll.Show();
                dashboardInUse.ShowInTaskbar = true;
            }

            private static void notifier_DoubleClick(object Sender, EventArgs e)
            {
                // Show the form when the user double clicks on the notify icon.

                // Set the WindowState to normal if the form is minimized.
                if (dashboardInUse.WindowState == FormWindowState.Minimized)
                    dashboardInUse.WindowState = FormWindowState.Normal;

                // Activate the form.
                dashboardInUse.Activate();
            }

            private static Point location;

            public static Point CurrentLocation
            {
                get
                {
                    return location;
                }
                set
                {
                    location = value;
                    dashboardInUse.Location = value;
                    calInUse.Location = value;
                    forumInUse.Location = value;
                    messagingInUse.Location = value;
                    resourcesInUse.Location = value;
                    profileInUse.Location = value;
                    loginInUse.Location = value;
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetCurrentProcessExplicitAppUserModelID(AppID);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //initialize a splash screen for use
            SplashScreen splash = new SplashScreen();
            //show the splash screen while the rest of the program loads
            splash.ShowDialog();
            //finally, run a login screen that is called from the class defined earlier
            Application.Run(WindowManager.loginInUse);
        }
    }
}
