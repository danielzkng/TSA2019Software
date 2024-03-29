﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    [Serializable]
    public class CalEvent
    {
        //instance variables for a calendar event
        public DateTime Date { get; set; }
        public int CreatorID { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public int ID { get; set; }

        //blank constructor for new event
        public CalEvent()
        {
            //default values
            Date = DateTime.Now;
            //initialize creator to null
            CreatorID = 0;
            //blank out description and title
            Description = "";
            Title = "";
            ID = -1;
        }

        //constructor with necessary info filled in
        public CalEvent(DateTime s, int c, string t, string d, int i)
        {
            //set everything equal to the correct values
            Date = s;
            CreatorID = c;
            Description = d;
            Title = t;
            ID = i;
        }

        //search method
        //returns true if the selected string was found in the title and false otherwise
        public bool searchEvent(string s)
        {
            if (Title.Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
