﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    /// <summary>
    /// This class includes data about a forum message, including message data, poster, and 
    /// </summary>
    class Message
    {
        //fields about the message
        public string Content { get; set; }
        public int NumEdits => edits;
        private int edits;
        public DateTime LastEdit => lastEdit;
        private DateTime lastEdit;
        public User Poster { get; }
        //timestamp
        public DateTime Timestamp { get; }

        //field for whether the post has been reported or not
        bool Reported { get; set; }

        //constructors
        public Message(User u)
        {
            //as close to a blank constructor as I can get it but we require user initially
            Poster = u;
            //set timestamp
            Timestamp = DateTime.Now;
            lastEdit = DateTime.Now;
            edits = 0;
            Reported = false;
        }

        //constructor with everything on it
        public Message(string c, User u)
        {
            //set the various variables equal to their contents
            Content = c;
            Poster = u;
            Timestamp = DateTime.Now;
            lastEdit = DateTime.Now;
            edits = 0;
            Reported = false;
        }

        //method to edit the content of the post
        public void EditPost(string c)
        {
            //change the content
            Content = c;
            //increment number of edits
            edits++;
            //change last edit timestamp to now
            lastEdit = DateTime.Now;
        }

        //method to report the post
        public void Report()
        {
            Reported = true;
        }

        //string to get a timestamp
        public string getTimeStamp()
        {
            //convert time of this post to a string and return it
            //if edited, then add the edit to the timestamp

            //TODO dynamic timestamsp i.e. "1 week ago"

            if(edits == 0)
            {
                //no edits, just return time
                return Timestamp.ToShortDateString() + " " + Timestamp.ToShortTimeString();
            }
            else
            {
                //there is an edit, so we need to return number of edits and time of last edit as well
                return Timestamp.ToShortDateString() + " at " + Timestamp.ToShortTimeString() + "\nThis post has been edited " + edits + "times, last edit on " + lastEdit.ToShortDateString() + " at " + lastEdit.ToShortTimeString();
            }
        }
    }
}
