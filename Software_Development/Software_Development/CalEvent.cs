﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    class CalEvent
    {
        //instance variables for a calendar event
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public User Creator { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        //blank constructor for new event
        public CalEvent()
        {
            //default values
            Start = DateTime.Now;
            End = DateTime.Now;
            //initialize creator to null
            Creator = null;
            //blank out description and title
            Description = "";
            Title = "";
        }

        //constructor with necessary info filled in
        public CalEvent(DateTime s, DateTime e, User c, string d, string t) 
        {
            //set everything equal to the correct values
            Start = s;
            End = e;
            Creator = c;
            Description = d;
            Title = t;
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