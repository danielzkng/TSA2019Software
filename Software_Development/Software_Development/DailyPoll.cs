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
    public partial class DailyPoll : Form
    {
        public static bool hasVoted = false;

        public DailyPoll()
        {
            InitializeComponent();
            Graphicize();
            radioButtonChicken.Checked = false;
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            if(radioButtonChicken.Checked)
            {
                labelNuggetsRes.Text += " - ✔️";
                hasVoted = true;
            }
            else if (radioButtonBurger.Checked)
            {
                labelBurgersRes.Text += " - ✔️";
                hasVoted = true;
            }
            else if (radioButtonNacho.Checked)
            {
                labelNachoRes.Text += " - ✔️";
                hasVoted = true;
            }
            else if (radioButtonPizza.Checked)
            {
                labelPizzaRes.Text += " - ✔️";
                hasVoted = true;
            }
            else
            {
                MessageBox.Show("You need to choose an option before you can vote!");
            }
            Graphicize();
            GlobalData.CurrentUser.PollsVoted++;
        }

        public void Graphicize()
        {
            panelResults.Visible = hasVoted;
            panelPoll.Visible = !hasVoted;
            radioButtonInvis.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //create a new calendar form
            DashboardPage dashboard = new DashboardPage();
            dashboard.ShowDialog();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //create a new calendar form
            DashboardPage dashboard = new DashboardPage();
            dashboard.ShowDialog();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            //create a new calendar form
            CalendarPage calendar = new CalendarPage();
            calendar.ShowDialog();
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
    }
}
