﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_Development.Program;
using Windows.UI.Notifications;
using Windows.Data;

namespace Software_Development
{
    public partial class DashboardPage : Form
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //Highlight the button when clicked
            //buttonCalendar.BackColor = Color.FromArgb(52, 73, 94);
            //buttonHome.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.CurrentLocation = Location;
            WindowManager.calInUse.Show();
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.forumInUse.Show();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            WindowManager.exitApp();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            WindowManager.logout();
        }

        private void buttonResources_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.resourcesInUse.Show();
        }

        private void buttonPoll_Click(object sender, EventArgs e)
        {
            //create and show a new daily poll form
            DailyPoll poll = new DailyPoll();
            Hide();
            ShowInTaskbar = false;
            poll.Show();
            ShowInTaskbar = true;
        }

        //todo FIO

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //IGNORE this code for now - will be used later to implement logout functionality once more of the program is built
            //write user data to file
            GlobalData.ExportCurrentUser();
            GlobalData.ExportAllInfo();
            //clear current user's data
            GlobalData.CurrentUser = null;
            GlobalData.firstLoad = false;
            WindowManager.CurrentLocation = this.Location;

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //bring up the profile screen
            //ProfilePage p = new ProfilePage();
            //p.ShowDialog();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.profileInUse.Show();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.profileInUse.Show();
        }

        private void buttonHome_MouseHover(object sender, EventArgs e)
        {
            //Disable highlight
            buttonHome.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void buttonMessaging_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.messagingInUse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowManager.messagingInUse.Show();
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
            // Only when the mouse is being held down and the form is being moved
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
            WindowManager.CurrentLocation = this.Location;
        }

        private void DashboardPage_Shown(object sender, EventArgs e)
        {
            if (GlobalData.firstLoad == true)
            {
                this.CenterToScreen();
                GlobalData.firstLoad = false;
            }
            else
            {
                this.Location = WindowManager.CurrentLocation;
            }
            WindowManager.notifier.ShowBalloonTip(30000, "Edutalk • Daily Poll", "A new daily poll has been posted. Check it out!", ToolTipIcon.Info);
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            //this.CenterToScreen();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
