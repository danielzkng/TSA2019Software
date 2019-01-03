using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    [Serializable]
    public class User
    {
        //class for a user, currently a placeholder with just a name
        public string Name { get; set; }
        public List<int> SubscribedCals { get; set; }
        public int ID { get; set; }

        //blank constructor
        public User()
        {
            Name = "";
            ID = -1;
        }

		//constructor with name
		public User(string n, int i)
        {
            ID = i;
            Name = n;
        }
//>>>>>> TODO ADD VARIABLES TO THIS
        public void SubscribeToCal(Calendar i)
        {
            SubscribedCals.Add(i.ID);
        }


        public void SubscribeToCal(int i)
        {
            SubscribedCals.Add(i);
        }
    }
}
