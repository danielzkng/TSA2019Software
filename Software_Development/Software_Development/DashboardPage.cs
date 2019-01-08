using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_Development.Program;

namespace Software_Development
{
    public partial class DashboardPage : Form
    {
        //instance variables
        bool logout = false; //boolean variable for declaring whether or not a form-close is a logout or not

        public DashboardPage()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //Highlight the button when clicked
            buttonCalendar.BackColor = Color.FromArgb(52, 73, 94);
            buttonHome.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            //Highlight the button when clicked
            buttonHome.BackColor = Color.FromArgb(52, 73, 94);
            buttonCalendar.BackColor = Color.FromArgb(44, 62, 80);
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            //open the resources form
            ResourcesPage resources = new ResourcesPage();
            resources.ShowDialog();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            GlobalData.ReadAllInfo();
        }

        private void buttonPoll_Click(object sender, EventArgs e)
        {
            //create and show a new daily poll form
            DailyPoll poll = new DailyPoll();
            poll.ShowDialog();
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //IGNORE this code for now - will be used later to implement logout functionality once more of the program is built
            //write user data to file
            GlobalData.ExportCurrentUser();
            if (!logout)
            {
                
                //this is a standard issue exit
                //the login screen also needs to be closed for a full exit
                FormsInProgram.loginInUse.Close();
            }
            else
            {
                //clear current user's data
                GlobalData.CurrentUser = null;
                //this is a logout, we need to show the login screen again
                FormsInProgram.loginInUse.Show();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            ProfilePage p = new ProfilePage();
            p.ShowDialog();
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abort");
        }
    }
}
