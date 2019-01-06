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
            FileStream activeFile = new FileStream("threads.db", FileMode.Create);

            //MODIFY user to your chosen data type
            List<Thread> toAdd = new List<Thread>();

            //ADD all messages to the array here
            toAdd.Add(new Thread("Tonight's Algebra II Homework?", "General Discussion", 3, 0));
            toAdd.Add(new Thread("BASKETBALL GAME TONIGHT!", "General Discussion", 0, 1));
            toAdd.Add(new Thread("Volunteer Opportunity at the Library", "General Discussion", 9, 2));
            toAdd.Add(new Thread("Orchestra is performing tomorrow night from 6-7 pm. Come to the theatre to support us!", "General Discussion", 12, 3));
            toAdd.Add(new Thread("Food drive runs for the next 3 weeks! Bring canned goods to support our local food banks!", "General Discussion", 14, 4));

            toAdd[0].addReply(4);
            toAdd[0].addReply(5);
            toAdd[0].addReply(7);
            toAdd[1].addReply(1);
            toAdd[1].addReply(2);
            toAdd[1].addReply(6);
            toAdd[1].addReply(8);
            toAdd[2].addReply(10);
            toAdd[2].addReply(11);
            toAdd[3].addReply(13);
            toAdd[3].addReply(17);
            toAdd[4].addReply(15);
            toAdd[4].addReply(16);

            toAdd[0].Upvotes = 17;
            toAdd[0].Views = 25;
            toAdd[1].Upvotes = 152;
            toAdd[1].Views = 301;
            toAdd[2].Upvotes = 80;
            toAdd[2].Views = 155;
            toAdd[3].Upvotes = 4;
            toAdd[3].Views = 10;
            toAdd[4].Upvotes = 27;
            toAdd[4].Views = 97;

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
