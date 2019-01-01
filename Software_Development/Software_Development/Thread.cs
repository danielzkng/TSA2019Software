using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    /// <summary>
    /// This class contains all the attributes for a forum thread, including the opening post, a list of messages, and voting data about the post.
    /// </summary>
    public class Thread
    {
        public int Upvotes {
            get
            {
                return upvotes;
            }
        }

        public int Downvotes
        {
            get
            {
                return downvotes;
            }
        }

        //instance versions of these two variables
        private int upvotes = 0;
        private int downvotes = 0;
        public string Subject { get; set; }
        public string Containing { get; set; }
        public List<string> Keywords { get; }
        public List<Message> Replies { get; set; }
        public Message FirstPost { get; }
        public int ID { get; set; }

        //list of keywords
        private List<string> keywords;

        //constructor with all info filled in
        public Thread(string s, string c, Message f, int i)
        {
            //set the various variables equal to their corresponding information
            ID = i;
            Subject = s;
            Containing = c;
            Keywords = new List<string>();
            //split up subject by spaces and set the keywords equal to these words (except for common ones)
            string[] keywords = s.Split(separator: ' ');

            foreach(string k in keywords)
            {
                //add each keyword to the list of keywords unless it's already either in use or is 5 characters or less (these are usually not important)
                if(!Keywords.Contains(k) && k.Length > 5)
                {
                    Keywords.Add(k);
                }
            }

            Replies = new List<Message>();
            FirstPost = f;
        }

        //method to upvote the post ONCE (should never be called more than once)
        public void upvotePost()
        {
            upvotes++;
        }

        //method to downvote the post ONCE
        public void downvotePost()
        {
            downvotes++;
        }

        //method to calculate percentage of votes upvoted
        public decimal pctUp()
        {
            return (upvotes) / (decimal)(upvotes + downvotes);
        }

        //add a message to the replies on the thread
        public void addReply(Message m)
        {
            //add the message to the list of replies
            Replies.Add(m);
        }

        //boolean method to check if a particular keyword is used
        public bool keywordUsed(string s)
        {
            foreach(string k in keywords)
            {
                //keyword is correct, return true
                if(k == s) return true;
            }
            //keyword not found, return false
            return false;
        }

        //void method to add a new keyword to the list if it isn't already added
        public void addKeyword(string s)
        {
            if (!Keywords.Contains(s))
            {
                Keywords.Add(s);
            }
        }

        public User getOP()
        {
            return FirstPost.Poster;
        }
    }
}
