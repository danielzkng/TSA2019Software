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
<<<<<<< HEAD
<<<<<<< HEAD

        private void buttonAddAss_Click(object sender, EventArgs e)
        {
            panelAddNew.Visible = true;
            panelViewList.Visible = false;
            textBoxNewName.Text = "";
        }

        private void buttonAddFinish_Click(object sender, EventArgs e)
        {
            if(textBoxNewName.Text == "")
            {
                //message box them because they goofed
                MessageBox.Show("You have to put in a title for the assignment first!");
            }
            else
            {
                GlobalData.CurrentUser.TasksToDo.Add(textBoxNewName.Text);
                checkedListBoxAssignments.Items.Add(textBoxNewName.Text);
                panelAddNew.Visible = false;
                panelViewList.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelAddNew.Visible = false;
            panelViewList.Visible = true;
        }

        private void CalendarPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> newtasks = new List<string>();
            //get rid of the checked items on the master to do list
            for(int i = 0; i < checkedListBoxAssignments.Items.Count; i++)
            {
                if(checkedListBoxAssignments.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    //user is not done with this task, add it to the new list of tasks
                    newtasks.Add((string)checkedListBoxAssignments.Items[i]);
                }
            }
            GlobalData.CurrentUser.TasksToDo = newtasks;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abort");
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            //create a new calendar form
            DashboardPage dashboard = new DashboardPage();
            dashboard.ShowDialog();
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            //create a new forum page
            ForumPage forum = new ForumPage();
            forum.ShowDialog();
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abort");
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            //open the resources form
            ResourcesPage resources = new ResourcesPage();
            resources.ShowDialog();
        }
=======
>>>>>>> parent of 14ed124... make the todo list functional
=======
>>>>>>> parent of 14ed124... make the todo list functional
    }
}
