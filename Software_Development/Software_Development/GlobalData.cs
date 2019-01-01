using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    /// <summary>
    /// This class handles global variables and information to be displayed to the user.
    /// The data is largely stored in database lists.
    /// This class is also the one that will deal with the various files directly, and to access file data, all other classes will use this one.
    /// </summary>
    public class GlobalData
    {
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

        //end these get by id methods

        public static void ReadAllInfo()
        {
            //ultimately ends up being a collection of all 6 types of imports
            ReadAllInfo(Objty.Calendar);
            ReadAllInfo(Objty.Event);
            ReadAllInfo(Objty.Message);
            ReadAllInfo(Objty.Private);
            ReadAllInfo(Objty.Thread);
            ReadAllInfo(Objty.User);
        }

        public static void ReadAllInfo(Objty o)
        {
            //import all the data of one type to its corresponding list from its file
        }

        public static void ExportAllInfo()
        {
            ExportAllInfo(Objty.Calendar);
            ExportAllInfo(Objty.Event);
            ExportAllInfo(Objty.Message);
            ExportAllInfo(Objty.Private);
            ExportAllInfo(Objty.Thread);
            ExportAllInfo(Objty.User);
        }

        public static void ExportAllInfo(Objty o)
        {
            //exports only one of the six lists to its corresponding data file
        }

        //HEY DANIEL DON'T BOTHER LOOKING PAST HERE, THESE METHODS ALL WORK AND ARE REAL BASIC

        //methods to read each data type
        //methods to find each piece of data by ID
        public static Message GetMessage(int i)
        {
            foreach (Message m in PostDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        public static User GetUser(int i)
        {
            foreach (User m in UsersDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        public static CalEvent GetEvent(int i)
        {
            foreach (CalEvent m in EventsDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        public static Calendar GetCal(int i)
        {
            foreach (Calendar m in CalendarsDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        public static Thread GetThread(int i)
        {
            foreach (Thread m in ThreadsDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        public static PrivateThread GetPM(int i)
        {
            foreach (PrivateThread m in PrivateDB)
            {
                if (m.ID == i)
                {
                    return m;
                }
            }
            return null;
        }

        //enum for data types (Objty = OBJect TYpe)
        public enum Objty
        {
            Message,
            Thread,
            Private,
            User,
            Calendar,
            Event
        }
    }
}
