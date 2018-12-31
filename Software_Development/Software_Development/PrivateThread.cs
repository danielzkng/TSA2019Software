using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    class PrivateThread : Thread
    {
        public List<User> Members { get; set; }

        public PrivateThread(string s, string c, Message f) : base(s, c, f)
        {
            //initialize the list of users who can access this thread
            Members = new List<User>();
            //add the initial user to the list who can access this message
            Members.Add(getOP());
        }

        public bool IsInMsg(User u)
        {
            foreach(User m in Members)
            {
                if(u == m)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddUser(User u)
        {
            Members.Add(u);
        }
    }
}
