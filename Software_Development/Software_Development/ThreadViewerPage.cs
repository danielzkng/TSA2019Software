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
    public partial class ThreadViewerPage : Form
    {

        public Thread displayed { get; set; }

        public ThreadViewerPage()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            ProfilePage p = new ProfilePage();
            p.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            ProfilePage p = new ProfilePage();
            p.ShowDialog();
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

        private void buttonCreatePost_Click(object sender, EventArgs e)
        {
            //add the post to the list box
            if(richTextBoxNewmsg.Text != "")
            {
                listBoxMessages.Items.Add(GlobalData.CurrentUser.Username + ": " + richTextBoxNewmsg.Text);
                listBoxMessages.Items.Add("");
                richTextBoxNewmsg.Clear();
            }
        }

        private void ThreadViewerPage_Load(object sender, EventArgs e)
        {
            //upon load, fill in the OP's info
            //import the thread 1 data
            labelTitleT1.Text = displayed.Subject.Substring(0, Math.Min(56, displayed.Subject.Length));
            if (Math.Min(56, displayed.Subject.Length) == 56) labelTitleT1.Text += "...";
            labelPreviewT1.Text = GlobalData.GetMessage(displayed.FirstPost).Content.Substring(0, Math.Min(120, GlobalData.GetMessage(displayed.FirstPost).Content.Length));
            if (Math.Min(120, GlobalData.GetMessage(displayed.FirstPost).Content.Length) == 120) {
                labelPreviewT1.Text += "...";
                labelFullPost.Visible = true;
            }
            labelTimestampT1.Text = GlobalData.GetMessage(displayed.FirstPost).getTimeStamp();
            labelUpvotesT1.Text = displayed.Upvotes.ToString() + " Upvotes";
            labelViewsT1.Text = displayed.Views.ToString() + " Views";
            labelRepliesT1.Text = displayed.Replies.Count().ToString() + " Replies";
            labelUsernameT1.Text = displayed.getOP().Username;

            //initialize all replies
            listBoxMessages.ItemHeight = 50;
            listBoxMessages.Items.Clear();

            //loop over all replies and add them to said box
            foreach(int i in displayed.Replies)
            {
                //get the message
                Message toAdd = GlobalData.GetMessage(i);
                User poster = GlobalData.GetUser(toAdd.PosterID);
                listBoxMessages.Items.Add(poster.Username + ": " + toAdd.Content);
                listBoxMessages.Items.Add("");
            }
        }

        private void panelThread1_Click(object sender, EventArgs e)
        {
            //show the full info in a dialog box
            MessageBox.Show(displayed.ToString(), "Full Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBoxNewmsg_Click(object sender, EventArgs e)
        {
            //clear the text box
            richTextBoxNewmsg.Clear();
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxMessages.SelectedIndex != -1)
            {
                richTextBoxFullMsg.Text = listBoxMessages.Items[listBoxMessages.SelectedIndex].ToString();
            }
            else
            {
                richTextBoxFullMsg.Text = "";
            }
        }
    }
}
