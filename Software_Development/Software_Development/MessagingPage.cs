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
    public partial class MessagingPage : Form
    {
        public MessagingPage()
        {
            InitializeComponent();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            ProfilePage p = new ProfilePage();
            p.ShowDialog();
            this.Close();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            ProfilePage p = new ProfilePage();
            p.ShowDialog();
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

        private void buttonResources_Click(object sender, EventArgs e)
        {
            //open the resources form
            ResourcesPage resources = new ResourcesPage();
            resources.ShowDialog();
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessagingPage_Load(object sender, EventArgs e)
        {
            //populate the students list box
            foreach(int i in GlobalData.CurrentUser.StudentFriends)
            {
                listBoxUsers.Items.Add(GlobalData.GetUser(i).Username);
            }

            //populate the teachers list box
            foreach(int i in GlobalData.CurrentUser.TeacherFriends)
            {
                listBoxTeachers.Items.Add(GlobalData.GetUser(i).Username);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make sure nothing's selected in the other list box
            if(listBoxUsers.SelectedIndex != -1) listBoxTeachers.SelectedIndex = -1;
            ActivateMessages();
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make sure nothing's selected in the other list box
            if(listBoxTeachers.SelectedIndex != -1) listBoxUsers.SelectedIndex = -1;
            ActivateMessages();
        }

        private void ActivateMessages()
        {
            textBoxMessage.Enabled = true;
            textBoxMessage.Clear();
            listBoxChat.Items.Clear();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            listBoxChat.Items.Add(GlobalData.CurrentUser.Username + ": " + textBoxMessage.Text);
            textBoxMessage.Text = "";
            buttonSend.Enabled = false;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            //validate whether or not a message can be sent
            if (textBoxMessage.Text != "")
            {
                buttonSend.Enabled = true;
            }
            else buttonSend.Enabled = false;
        }
    }
}
