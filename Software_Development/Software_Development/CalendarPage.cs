using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development
{
    public partial class CalendarPage : Form
    {
        //list of ints for IDs of displayed events
        private List<int> displayedEvents = new List<int>();
        public CalendarPage()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalendarPage_Load(object sender, EventArgs e)
        {
            labelEventDescription.Text = "";
            //this is where the fun begins
            //load the list of calendars into the combo box
            comboBoxFilters.SelectedIndex = 0;
            PopulateEventsBox();

            foreach(Calendar c in GlobalData.CalendarsDB)
            {
                comboBoxFilters.Items.Add(c.Name);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            PopulateEventsBox();
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEventsBox();
        }

        private void PopulateEventsBox()
        {
            labelEventsFor.Text = "Events For " + monthCalendar1.SelectionStart.ToShortDateString();
            listBoxEvents.SelectionMode = SelectionMode.None;
            listBoxEvents.Items.Clear();
            displayedEvents.Clear();
            if (comboBoxFilters.SelectedIndex == 0)
            {
                foreach (CalEvent k in GlobalData.EventsDB)
                {
                    if (k.Date.DayOfYear == monthCalendar1.SelectionStart.DayOfYear && k.Date.Year == monthCalendar1.SelectionStart.Year)
                    {
                        listBoxEvents.Items.Add(k.Title);
                        displayedEvents.Add(k.ID);
                        listBoxEvents.SelectionMode = SelectionMode.One;
                    }
                }
            }
            else
            {
                foreach (int i in GlobalData.CalendarsDB[comboBoxFilters.SelectedIndex - 1].EventIDs)
                {
                    CalEvent k = GlobalData.GetEvent(i);
                    if (k.Date.DayOfYear == monthCalendar1.SelectionStart.DayOfYear && k.Date.Year == monthCalendar1.SelectionStart.Year)
                    {
                        listBoxEvents.Items.Add(k.Title);
                        displayedEvents.Add(k.ID);
                        listBoxEvents.SelectionMode = SelectionMode.One;
                    }
                }
            }

            if (listBoxEvents.Items.Count == 0)
            {
                listBoxEvents.Items.Add("None found!");
                labelDescriptionHeader.Text = "No event selected.";
                labelEventDescription.Text = "";
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if we select something
            if(listBoxEvents.SelectedIndex != -1)
            {
                //currently displayed event
                CalEvent displaying = GlobalData.GetEvent(displayedEvents[listBoxEvents.SelectedIndex]);
                labelDescriptionHeader.Text = displaying.Title;
                labelEventDescription.Text = displaying.Description;
            }
            //nothing is selected
            else
            {
                labelDescriptionHeader.Text = "No event selected.";
                labelEventDescription.Text = "";
            }
        }
    }
}
