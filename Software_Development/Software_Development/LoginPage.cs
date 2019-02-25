using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static Software_Development.Program;

namespace Software_Development
{
    public partial class LoginPage : Form
    {
        //create a list of strings for usernames and for passwords
        private List<string> usernames = new List<string>();
        private List<string> passwords = new List<string>();

        public static string newUsername = "";
        public static string newPassword = "";

        //new formatter
        BinaryFormatter serializer = new BinaryFormatter();

        //int for number of logins
        int accounts;

        public LoginPage()
        {

            InitializeComponent();
            //define instance variables for reading input from the logins database
            FileStream logins = new FileStream("logins.db", FileMode.Open);

            accounts = (int)serializer.Deserialize(logins);

            //initialize our usernames and passwords using the StreamReader
            for(int i = 0; i < accounts; i++)
            {
                //get the next username and password
                usernames.Add((string)serializer.Deserialize(logins));
                passwords.Add((string)serializer.Deserialize(logins));
            }
            logins.Close();
            WindowManager.CurrentLocation = new Point(277, 119);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //close the form using window manager methods
            WindowManager.exitApp();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                //user did not enter a username or a password, display a message box
                MessageBox.Show("No username or password entered.", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //boolean for whether or not login worked
                bool success = false;
                //loop over each username/password pair and check if they are equal to the input, if so then output as a success
                for(int i = 0; i < usernames.Count(); i++)
                {
                    //check if username and password are both equal to the correct number
                    if(textBoxUsername.Text == usernames[i] && textBoxPassword.Text == passwords[i])
                    {
                        success = true;

                        WindowManager.initializeForms();

                        //generate the user ID by adding 1000000 to i
                        int UID = 1000000 + i;

                        if (File.Exists("Profiles\\profile" + UID + ".bin"))
                        {
                            //create current user object with blank constructor
                            GlobalData.CurrentUser = new CurrentUserData();
                            //open the file
                            FileStream f = new FileStream("Profiles\\profile" + UID + ".bin", FileMode.Open);
                            //read the current user data
                            GlobalData.CurrentUser = (CurrentUserData)serializer.Deserialize(f);
                            f.Close();
                            GlobalData.ExportCurrentUser();
                        }
                        else
                        {
                            //get basic user data
                            BasicData basic = new BasicData();
                            basic.ShowDialog();
                            GlobalData.CurrentUser.Username = textBoxUsername.Text;
                            GlobalData.CurrentUser.ID = UID;
                            //export user data
                            GlobalData.ExportCurrentUser();
                        }
                        GlobalData.ReadAllInfo();

                        //if this form is returned to after the client is shown, clear the text boxes
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        labelPassword.Visible = true;
                        labelUsername.Visible = true;
                        textBoxUsername.Focus();

                        //hide this form and show the main client window
                        this.Hide();
                        WindowManager.dashboardInUse.Show();
                    }
                }
                //if login unsuccessful then display a messagebox saying that it wasn't
                if (!success)
                {
                    MessageBox.Show("Username/password is incorrect. Please try again.", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //focus on the username text box
                textBoxUsername.Focus();
            }
        }

        /// <summary>
        /// These next few methods deal with the behavior of the username and password text boxes.
        /// </summary>

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //set the username label visible if the text is empty and set it invisible otherwise
            labelUsername.Visible = textBoxUsername.Text == "";
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            //highlight all text when we focus this text box
            textBoxUsername.SelectAll();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //set the username label visible if the text is empty and set it invisible otherwise
            labelPassword.Visible = textBoxPassword.Text == "";
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            //highlight all text when we focus this text box
            textBoxUsername.SelectAll();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Focus();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //file stream for write out
            FileStream loginsOut = new FileStream("logins.db", FileMode.Create);
            serializer.Serialize(loginsOut, accounts);
            for(int i = 0; i < usernames.Count; i++)
            {
                serializer.Serialize(loginsOut, usernames[i]);
                serializer.Serialize(loginsOut, passwords[i]);
            }
            Location = WindowManager.CurrentLocation;
            loginsOut.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //create new registration form
            Registration registerForm = new Registration();
            registerForm.usernames = usernames;
            registerForm.passwords = passwords;
            registerForm.ShowDialog();
            if(newUsername != "" && newPassword != "")
            {
                //add the new user to list
                usernames.Add(newUsername);
                passwords.Add(newPassword);
                accounts++;
                //file stream for write out
                FileStream loginsOut = new FileStream("logins.db", FileMode.Create);
                serializer.Serialize(loginsOut, accounts);
                for (int i = 0; i < usernames.Count; i++)
                {
                    serializer.Serialize(loginsOut, usernames[i]);
                    serializer.Serialize(loginsOut, passwords[i]);
                }
                loginsOut.Close();
            }

            //reset username and password
            newUsername = "";
            newPassword = "";
        }

        //Set up variables to check if mouse is down and to retain previous mouse location
        private bool mouseDown;
        private Point lastLocation;

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            //When mouse is being held down, retain the mouse's original location
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
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

        private void LoginPage_MouseUp(object sender, MouseEventArgs e)
        {
            //When mouse is not being held down on form
            mouseDown = false;
            WindowManager.CurrentLocation = Location;
        }

        private void LoginPage_Shown(object sender, EventArgs e)
        {
            Location = WindowManager.CurrentLocation;
            this.CenterToScreen();
        }
    }
}
