using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development
{
    public partial class ResourcesPage : Form
    {
        public ResourcesPage()
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

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.example.org/");
            Process.Start(sInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
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
            //When mouse is not being held down on form
            mouseDown = false;
        }
    }
}
