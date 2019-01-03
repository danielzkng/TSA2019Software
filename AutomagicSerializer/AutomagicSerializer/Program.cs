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
            FileStream activeFile = new FileStream("messages.db", FileMode.Create);

            //MODIFY user to your chosen data type
            List<Message> toAdd = new List<Message>();

            //ADD everything to the array here
            
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
