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
using Windows.UI.Notifications;
using Windows.Data;

namespace Software_Development
{
    public partial class DashboardPage : Form
    {
        public NotifyIcon notifier;
        private ContextMenu sysTrayMenu;
        private MenuItem exitMenuItem;
        private IContainer menuComponents;

        public DashboardPage()
        {
            InitializeComponent();
            menuComponents = new Container();
            this.sysTrayMenu = new System.Windows.Forms.ContextMenu();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.sysTrayMenu.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { this.exitMenuItem });

            // Initialize menuItem1
            this.exitMenuItem.Index = 0;
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);

            this.notifier = new System.Windows.Forms.NotifyIcon(this.menuComponents);

            notifier.Icon = new Icon("..\\..\\Resources\\robot.ico");
            notifier.ContextMenu = sysTrayMenu;
            notifier.Text = "EduTalk";
            notifier.Visible = true;

            notifier.DoubleClick += new System.EventHandler(this.notifier_DoubleClick);

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

        private void exitMenuItem_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            WindowManager.exitApp();
        }

        private void notifier_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
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

            notifier.Dispose();
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
            WindowManager.CurrentLocation = Location;
        }

        private void DashboardPage_Shown(object sender, EventArgs e)
        {
            Location = WindowManager.CurrentLocation;

            notifier.ShowBalloonTip(30000, "Edutalk • Surprise", "Abort!", ToolTipIcon.Warning);

            /*var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = "Edutalk • New Friend Request"
                            },
                            new AdaptiveText()
                            {
                                Text = "Allan Dao wants to be friends with you!"
                            }
                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
                    {
                        new ToastButton("Accept", "action=acceptFriendRequest&userId=49183")
                        {
                            ActivationType = ToastActivationType.Background
                        },
                        new ToastButton("Decline", "action=declineFriendRequest&userId=49183")
                        {
                            ActivationType = ToastActivationType.Background
                        }
                    }
                },
                Launch = "action=viewFriendRequest&userId=49183"
            };

            // Create the toast notification
            Windows.Data.Xml.Dom.XmlDocument notif = new Windows.Data.Xml.Dom.XmlDocument();
            notif.LoadXml(toastContent.GetContent());
            var toastNotif = new ToastNotification(notif);

            // And send the notification
            //todo debug this with appID apparently
            ToastNotificationManager.CreateToastNotifier("Edutalk.Edutalk").Show(toastNotif);*/
        }
    }
}
