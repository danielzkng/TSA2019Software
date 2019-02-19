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
    public partial class ForumPage : Form
    {
        //instance variables
        private int t1, t2, t3;
        private int currentPage = 0;
        private int numThreads;
        private int totalPages;

        public ForumPage()
        {
            InitializeComponent();
        }

        private void panelThread1_Click(object sender, EventArgs e)
        {
            ThreadViewerPage t = new ThreadViewerPage();
            t.displayed = GlobalData.GetThread(t1);
            t.Show();
            this.Hide();
        }

        private void panelThread2_Click(object sender, EventArgs e)
        {
            ThreadViewerPage t = new ThreadViewerPage();
            t.displayed = GlobalData.GetThread(t2);
            t.Show();
            this.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ThreadViewerPage t = new ThreadViewerPage();
            t.displayed = GlobalData.GetThread(t3);
            t.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            displayPage(currentPage);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            displayPage(currentPage);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                int newPage = int.Parse(textBoxPage.Text);
                currentPage = newPage - 1;
                displayPage(currentPage);
            }
            catch
            {
                MessageBox.Show("Invalid page number entered, try again.");
            }
        }

        private void buttonCreatePost_Click(object sender, EventArgs e)
        {
            //TODO create thread

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowManager.profileInUse.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowManager.profileInUse.Show();
            this.Hide();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            WindowManager.dashboardInUse.Show();
            this.Hide();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            WindowManager.calInUse.Show();
            this.Hide();
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            WindowManager.messagingInUse.Show();
            this.Hide();
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            WindowManager.resourcesInUse.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            WindowManager.logout();
        }

        //Set up variables to check if mouse is down and to retain previous mouse location
        private bool mouseDown;
        private Point lastLocation;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            //When mouse is being held down, retain the mouse's original location
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            //Only when the mouse is being held down and the form is being moved
            //Retain mouses position on form but move form's location to create a fluid dragging motion
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            // When mouse is not being held down on form
            mouseDown = false;
            WindowManager.CurrentLocation = Location;
        }

        private void ForumPage_Shown(object sender, EventArgs e)
        {
            //find the number of pages of threads
            numThreads = GlobalData.ThreadsDB.Count();
            totalPages = numThreads / 3;
            if (numThreads % 3 != 0)
            {
                totalPages++;
            }
            labelnumpages.Text = "of " + totalPages.ToString();
            displayPage(currentPage);

            Location = WindowManager.CurrentLocation;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            WindowManager.dashboardInUse.Show();
            this.Hide();
        }

        /// <summary>
        /// Displays the 3 threads on a particular page.
        /// </summary>
        /// <param name="n">The number of the page to be displayed</param>
        public void displayPage(int n)
        {
            currentPage = n;
            if(n >= totalPages || n < 0)
            {
                MessageBox.Show("Please enter a valid page number!");
            }
            else
            {
                //actually display threads
                t1 = GlobalData.ThreadsDB[numThreads - 1 - (3 * n)].ID;
                if (numThreads - 2 - (3 * n) >= 0) t2 = GlobalData.ThreadsDB[numThreads - 2 - (3 * n)].ID;
                else t2 = -1;
                if (numThreads - 3 - (3 * n) >= 0) t3 = GlobalData.ThreadsDB[numThreads - 3 - (3 * n)].ID;
                else t3 = -1;
                Thread first = GlobalData.GetThread(t1);
                Thread second = null;
                Thread third = null;
                if(t2 >= 0) second = GlobalData.GetThread(t2);
                if(t3 >= 0) third = GlobalData.GetThread(t3);

                //import the thread 1 data
                labelTitleT1.Text = first.Subject.Substring(0, Math.Min(56, first.Subject.Length));
                if (Math.Min(56, first.Subject.Length) == 56) labelTitleT1.Text += "...";
                labelPreviewT1.Text = GlobalData.GetMessage(first.FirstPost).Content.Substring(0, Math.Min(97, GlobalData.GetMessage(first.FirstPost).Content.Length));
                if (Math.Min(97, GlobalData.GetMessage(first.FirstPost).Content.Length) == 97) labelPreviewT1.Text += "...";
                labelTimestampT1.Text = GlobalData.GetMessage(first.FirstPost).getTimeStamp();
                labelUpvotesT1.Text = first.Upvotes.ToString() + " Upvotes";
                labelViewsT1.Text = first.Views.ToString() + " Views";
                labelRepliesT1.Text = first.Replies.Count().ToString() + " Replies";
                labelUsernameT1.Text = first.getOP().Username;

                //import thread 2 data
                if(second != null)
                {
                    panelThread2.Visible = true;
                    labelTitleT2.Text = second.Subject.Substring(0, Math.Min(56, second.Subject.Length));
                    if (Math.Min(56, second.Subject.Length) == 56) labelTitleT2.Text += "...";
                    labelPreviewT2.Text = GlobalData.GetMessage(second.FirstPost).Content.Substring(0, Math.Min(97, GlobalData.GetMessage(second.FirstPost).Content.Length));
                    if (Math.Min(97, GlobalData.GetMessage(second.FirstPost).Content.Length) == 97) labelPreviewT2.Text += "...";
                    labelTimestampT2.Text = GlobalData.GetMessage(second.FirstPost).getTimeStamp();
                    labelUpvotesT2.Text = second.Upvotes.ToString() + " Upvotes";
                    labelViewsT2.Text = second.Views.ToString() + " Views";
                    labelRepliesT2.Text = second.Replies.Count().ToString() + " Replies";
                    labelUsernameT2.Text = second.getOP().Username;
                    if(third != null)
                    {
                        panel6.Visible = true;
                        labelTitleT3.Text = third.Subject.Substring(0, Math.Min(56, third.Subject.Length));
                        if (Math.Min(56, third.Subject.Length) == 56) labelTitleT3.Text += "...";
                        labelPreviewT3.Text = GlobalData.GetMessage(third.FirstPost).Content.Substring(0, Math.Min(97, GlobalData.GetMessage(third.FirstPost).Content.Length));
                        if (Math.Min(97, GlobalData.GetMessage(third.FirstPost).Content.Length) == 97) labelPreviewT3.Text += "...";
                        labelTimestampT3.Text = GlobalData.GetMessage(third.FirstPost).getTimeStamp();
                        labelUpvotesT3.Text = third.Upvotes.ToString() + " Upvotes";
                        labelViewsT3.Text = third.Views.ToString() + " Views";
                        labelRepliesT3.Text = third.Replies.Count().ToString() + " Replies";
                        labelUsernameT3.Text = third.getOP().Username;
                    }
                    else
                    {
                        panel6.Visible = false;
                    }
                }
                else
                {
                    panelThread2.Visible = false;
                    panel6.Visible = false;
                }

                //update right hand panel
                textBoxPage.Text = (n + 1).ToString();
                //arcane magic
                buttonNext.Enabled = (n < totalPages - 1);
                buttonPrevious.Enabled = (n > 0);
                buttonGo.Focus();
            }
        }

    }
}
