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
            public static login loginInUse
            {
                get
                {
                    //if no such form created yet, create the form (this only executes once, when loginInUse is called from Program.cs)
                    if (login == null)
                    {
                        login = new login();
                    }
                    return login;
                }
            }
            //private form -- this is the form itself, not just a public way to access it
            private static login login;
        }

        //public global variables
        public class GlobalData {
            public static List<Message> PostDB { get; set; }
            public static List<User> UsersDB { get; set; }
            public static List<CalEvent> EventsDB { get; set; }
            public static List<Calendar> CalendarsDB { get; set; }
            public static List<Thread> ThreadsDB { get; set; }
            public static List<PrivateThread> PrivateDB { get; set; }

            //method to read all posts
            //a THREAD will just be a glorified list of posts by ID stored in a separate db (each thread has some basic data about it + list of posts)
            //a PRIVATE THREAD also has access restrictions so that not everyone can access it

            //method to read all users

            //method to read all events
            //a CALENDAR will just be a glorified list of events by ID stored in a separate db (each calendar has some basic data about it + list of events)

            //methods to find each piece of data by ID

            public static void ReadAllInfo()
            {
                
            }

            //FYI: Objty = Object type, I'm just really lazy
            public enum Objty
            {
                Message,
                User,
                CalEvent,
                Calendar,
                Thread,
                PrivateThread,
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
            Application.Run(FormsInProgram.loginInUse);
        }
    }
}
