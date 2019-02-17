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
    public partial class BasicData : Form
    {
        public BasicData()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //check if everything's there
            if(textBoxName.Text == "" || textBoxEmail.Text == "" || maskedTextBoxPhone.Text == "" || comboBoxGrade.SelectedIndex == -1)
            {
                MessageBox.Show("You have left a required field empty!");
            }
            else
            {
                GlobalData.CurrentUser = new CurrentUserData(textBoxName.Text, textBoxEmail.Text, maskedTextBoxPhone.Text, comboBoxGrade.Text);
                LoginPage login = new LoginPage();
                login.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Set up variables to check if mouse is down and to retain previous mouse location
        private bool mouseDown;
        private Point lastLocation;

        private void BasicData_MouseDown(object sender, MouseEventArgs e)
        {
            //When mouse is being held down, retain the mouse's original location
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void BasicData_MouseMove(object sender, MouseEventArgs e)
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

        private void BasicData_MouseUp(object sender, MouseEventArgs e)
        {
            //When mouse is not being held down on form
            mouseDown = false;
        }
    }
}
