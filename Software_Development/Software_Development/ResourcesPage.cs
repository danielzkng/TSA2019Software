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
using static Software_Development.Program;

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
            WindowManager.dashboardInUse.Show();
            this.Hide();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            WindowManager.calInUse.Show();
            this.Hide();
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            WindowManager.forumInUse.Show();
            this.Hide();
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            WindowManager.messagingInUse.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowManager.profileInUse.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowManager.profileInUse.Show();
            this.Hide();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            WindowManager.exitApp();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            WindowManager.logout();
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
            WindowManager.CurrentLocation = Location;
        }

        private void ResourcesPage_Shown(object sender, EventArgs e)
        {
            this.Location = WindowManager.CurrentLocation;
        }

        private void listBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxResources.SelectedIndex == 0)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://classroom.google.com/");
                Process.Start(sInfo);
            }
            else if(listBoxResources.SelectedIndex == 1)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://drive.google.com/");
                Process.Start(sInfo);
            }
            else if(listBoxResources.SelectedIndex == 2)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://edmodo.com/");
                Process.Start(sInfo);
            }
            else if (listBoxResources.SelectedIndex == 3)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.remind.com/");
                Process.Start(sInfo);
            }
            else if (listBoxResources.SelectedIndex == 4)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://grades.nsd.org/");
                Process.Start(sInfo);
            }
            else if (listBoxResources.SelectedIndex == 5)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://quizlet.com/");
                Process.Start(sInfo);
            }
        }

        private void ResourcesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Location = WindowManager.CurrentLocation;
        }
    }
}
