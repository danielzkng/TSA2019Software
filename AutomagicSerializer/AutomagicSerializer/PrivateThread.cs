using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    [Serializable]
    public class PrivateThread : Thread
    {
        public List<int> Members { get; set; }

        /// <param name="s">Subject</param>
        /// <param name="f">ID of first post</param>
        /// <param name="i">ID of user</param>
        public PrivateThread(string s, int f, int i) : base(s, "Private Messages", f, i)
        {
            //initialize the list of users who can access this thread
            Members = new List<int>();
            //add the initial user to the list who can access this message
            Members.Add(getOP().ID);
        }

        public bool IsInMsg(User u)
        {
            foreach(int m in Members)
            {
                if(u.ID == m)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddUser(User u)
        {
            Members.Add(u.ID);
        }

        public void AddUser(int u)
        {
            Members.Add(u);
        }
    }
}
