﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

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

        private static BinaryFormatter serializer = new BinaryFormatter();

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
            ReadInfo(Objty.Calendar);
            ReadInfo(Objty.Event);
            ReadInfo(Objty.Message);
            ReadInfo(Objty.Private);
            ReadInfo(Objty.Thread);
            ReadInfo(Objty.User);
        }

        //this code is so bad and i never want to look at it again
        public static void ReadInfo(Objty o)
        {
            //TODO import all the data of one type to its corresponding list from its file
            switch (o)
            {
                case Objty.User:
                    //since we are reading all users, flush the users database
                    UsersDB = new List<User>();
                    //create new file stream
                    FileStream f = new FileStream("users.db", FileMode.Open);
                    while(f.Position != f.Length)
                    {
                        //get the next user
                        User toAdd = (User)serializer.Deserialize(f);
                        UsersDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    f.Close();
                    break;
                case Objty.Calendar:
                    CalendarsDB = new List<Calendar>();
                    //create new file stream
                    FileStream c = new FileStream("calendars.db", FileMode.Open);
                    while (c.Position != c.Length)
                    {
                        //get the next user
                        Calendar toAdd = (Calendar)serializer.Deserialize(c);
                        CalendarsDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    c.Close();
                    break;
                case Objty.Event:
                    EventsDB = new List<CalEvent>();
                    //create new file stream
                    FileStream e = new FileStream("events.db", FileMode.Open);
                    while (e.Position != e.Length)
                    {
                        //get the next user
                        CalEvent toAdd = (CalEvent)serializer.Deserialize(e);
                        EventsDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    e.Close();
                    break;
                case Objty.Message:
                    PostDB = new List<Message>();
                    //create new file stream
                    FileStream m = new FileStream("messages.db", FileMode.Open);
                    while (m.Position != m.Length)
                    {
                        //get the next user
                        Message toAdd = (Message)serializer.Deserialize(m);
                        PostDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    m.Close();
                    break;
                case Objty.Thread:
                    ThreadsDB = new List<Thread>();
                    //create new file stream
                    FileStream t = new FileStream("threads.db", FileMode.Open);
                    while (t.Position != t.Length)
                    {
                        //get the next user
                        Thread toAdd = (Thread)serializer.Deserialize(t);
                        ThreadsDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    t.Close();
                    break;
                case Objty.Private:
                    PrivateDB = new List<PrivateThread>();
                    //create new file stream
                    FileStream p = new FileStream("privatemsgs.db", FileMode.Open);
                    while (p.Position != p.Length)
                    {
                        //get the next user
                        PrivateThread toAdd = (PrivateThread)serializer.Deserialize(p);
                        PrivateDB.Add(toAdd);
                        MessageBox.Show(toAdd.ToString());
                    }
                    p.Close();
                    break;
                default:
                    break;
            }
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
            //TODO exports only one of the six lists to its corresponding data file
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
