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
        public string Username { get; set; }
        public List<int> SubscribedCals { get; set; }
        public int ID { get; set; }
        public int PostCount { get; set; }

        //blank constructor
        public User()
        {
            Name = "";
            SubscribedCals = new List<int>();
            ID = -1;
            PostCount = 0;
        }

		//constructor with name
        /// <param name="n">Name</param>
        /// <param name="u">Username</param>
        /// <param name="i">ID</param>
        /// <param name="p">Post count</param>
		public User(string n, string u, int i, int p)
        {
            ID = i;
            Username = u;
            PostCount = p;
            Name = n;
            SubscribedCals = new List<int>();
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
