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
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            if(GlobalData.CurrentUser.Connections == 0)
            {
                Random rng = new Random();
                GlobalData.CurrentUser.Connections = rng.Next(20) + 10;
            }
            textBoxName.Text = GlobalData.CurrentUser.Name;
            textBoxEmail.Text = GlobalData.CurrentUser.Email;
            maskedTextBoxPhone.Text = GlobalData.CurrentUser.Phone;
            labelPostcount.Text = GlobalData.CurrentUser.PostCount.ToString();
            labelPolls.Text = GlobalData.CurrentUser.PollsVoted.ToString();
            labelUpvotes.Text = GlobalData.CurrentUser.UpvotesGiven.ToString();
            labelConnections.Text = GlobalData.CurrentUser.Connections.ToString();
            labelHeader.Text = GlobalData.CurrentUser.Username;
            foreach(string s in comboBoxGrade.Items)
            {
                if(s == GlobalData.CurrentUser.Grade)
                {
                    comboBoxGrade.SelectedIndex = comboBoxGrade.Items.IndexOf(s);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //close this w/o saving
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close this with saving
            GlobalData.CurrentUser.Name = textBoxName.Text;
            GlobalData.CurrentUser.Email = textBoxEmail.Text;
            GlobalData.CurrentUser.Phone = maskedTextBoxPhone.Text;
            GlobalData.CurrentUser.Grade = comboBoxGrade.Text;
            //write to file
            GlobalData.ExportCurrentUser();
            //confirmation dialog box
            MessageBox.Show("Changes saved!");
            //close form
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //create a new dashboard form
            DashboardPage home = new DashboardPage();
            home.ShowDialog();
            this.Close();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            //create a new calendar form
            CalendarPage calendar = new CalendarPage();
            calendar.ShowDialog();
            this.Close();
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            //create a new forum page
            ForumPage forum = new ForumPage();
            forum.ShowDialog();
            this.Close();
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            //create a new message page
            MessagingPage message = new MessagingPage();
            message.ShowDialog();
            this.Close();
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            //open the resources form
            ResourcesPage resources = new ResourcesPage();
            resources.ShowDialog();
            this.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
