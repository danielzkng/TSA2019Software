using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Software_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be sure to update the 6 object classes as necessary as they change functionality within the main project!

            //Attention ALL who wander upon this code: DO NOT TOUCH ANYTHING THAT DOES NOT EXPLICITLY STATE THAT YOU CAN MODIFY IT.
            //Do I make myself clear?
            //Modifying literally anything in this program that isn't labeled "MODIFY" or "ADD" has potential to make something SERIOUSLY stop working.

            //MODIFY the file name as is necessary, don't touch anything else
            FileStream activeFile = new FileStream("calendars.db", FileMode.Create);

            //MODIFY user to your chosen data type
            List<Calendar> toAdd = new List<Calendar>();

            //ADD everything to the array here
            Calendar sports = new Calendar("Sports", 8, 0);
            sports.AddEvent(3);
            sports.AddEvent(5);
            sports.AddEvent(6);
            toAdd.Add(sports);
            Calendar tests = new Calendar("Tests", 8, 1);
            tests.AddEvent(2);
            tests.AddEvent(4);
            tests.AddEvent(8);
            toAdd.Add(tests);
            Calendar clubs = new Calendar("Clubs", 8, 2);
            clubs.AddEvent(0);
            clubs.AddEvent(1);
            clubs.AddEvent(7);
            clubs.AddEvent(9);
            toAdd.Add(clubs);

            //...and so on...

            //DO NOT TOUCH ANYTHING PAST THIS LINE!!!
            //In fact, unless you REALLY know what you're doing, don't touch anything outside of this file, either.
            BinaryFormatter serializer = new BinaryFormatter();
            foreach (object o in toAdd)
            {
                serializer.Serialize(activeFile, o);
            }

            activeFile.Close();
        }
    }
}
