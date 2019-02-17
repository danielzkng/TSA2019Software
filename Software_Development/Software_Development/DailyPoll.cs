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

        private void buttonDone_Click(object sender, EventArgs e)
        {
            //create a new dashboard form
            DashboardPage home = new DashboardPage();
            home.ShowDialog();
            this.Close();
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
