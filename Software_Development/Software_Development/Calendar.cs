using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Software_Development
{
    /// <summary>
    /// This class contains a collection of events and its metadata.
    /// </summary>
    class Calendar
    {
        public string Name { get; set; }
        public List<CalEvent> Events { get; set; }
        public List<int> EventIDs { get; set; }
        public User Creator { get; set; }
        public int ID { get; set; }

        //blank constructor
        public Calendar()
        {
            Events = new List<CalEvent>();
            Creator = null;
            Name = "";
        }

        public Calendar(string n, User c, int i)
        {
            Creator = c;
            Name = n;
            Events = new List<CalEvent>();
            ID = i;
        }

        public void AddEvent(CalEvent c)
        {
            Events.Add(c);
        }

        //TODO figure out some sort of serialization to write everything to file

        //TODO figure this out for debugging purposes
        public override string ToString()
        {
            return "";
        }
    }
}
