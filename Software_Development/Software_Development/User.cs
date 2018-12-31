using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    class User
    {
        //class for a user, currently a placeholder with just a name
        public string Name { get; set; }
        public List<Calendar> Subscribed { get; set; }

		//blank constructor
		public User()
        {
            Name = "";
        }

		//constructor with name
		public User(string n)
        {
            Name = n;
        }
//>>>>>> TODO ADD VARIABLES TO THIS
    }
}
