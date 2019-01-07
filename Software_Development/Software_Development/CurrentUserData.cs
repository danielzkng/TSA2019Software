using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    [Serializable]
    public class CurrentUserData
    {
        public int ID { get; set; }
        public bool hasVotedToday { get; set; }
        public int PostCount { get; set; }
        public int PollsVoted { get; set; }
        public int UpvotesGiven { get; set; }
        public int Connections { get; set; }

        //personal information
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Grade { get; set; }

        public string Username { get; }

        public List<string> TasksToDo { get; set; }

        //blank constructor
        public CurrentUserData()
        {
            ID = 0;
            hasVotedToday = false;
            PostCount = 0;
            PollsVoted = 0;
            UpvotesGiven = 0;
            Connections = 0;
            Name = "";
            Email = "";
            Phone = "";
            Grade = "";
            Username = "";
            TasksToDo = new List<string>();
        }

        public CurrentUserData(string n, string e, string p, string g, string u)
        {
            Name = n;
            Email = e;
            Phone = p;
            Grade = g;
            Username = u;
            ID = 0;
            hasVotedToday = false;
            PostCount = 0;
            PollsVoted = 0;
            UpvotesGiven = 0;
            Connections = 0;
            TasksToDo = new List<string>();
        }
    }
}
