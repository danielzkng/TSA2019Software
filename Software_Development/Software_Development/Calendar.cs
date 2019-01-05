using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Software_Development
{
    /// <summary>
    /// This class contains a collection of events and its metadata.
    /// </summary>
    [Serializable]
    public class Calendar
    {
        public string Name { get; set; }
        public List<int> EventIDs { get; set; }
        public int CreatorID { get; set; }
        public int ID { get; set; }

        //blank constructor
        public Calendar()
        {
            EventIDs = new List<int>();
            CreatorID = 0;
            Name = "";
        }

        public Calendar(string n, int c, int i)
        {
            CreatorID = c;
            Name = n;
            EventIDs = new List<int>();
            ID = i;
        }

        public void AddEvent(CalEvent c)
        {
            EventIDs.Add(c.ID);
        }

        public void AddEvent(int c)
        {
            EventIDs.Add(c);
        }

        //TODO figure this out for debugging purposes
        public override string ToString()
        {
            string evids = "";
            foreach(int i in EventIDs)
            {
                evids += i + ", ";
            }
            return "Name: " + Name + Environment.NewLine + "Event IDs: " + evids + Environment.NewLine + "CreatorID: " + CreatorID + Environment.NewLine + "CalID: " + ID;
        }

    }
}
