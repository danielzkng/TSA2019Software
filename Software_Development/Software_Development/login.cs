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

namespace Software_Development
{
    public partial class login : Form
    {
        //define instance variables for reading input from the logins file
        private StreamReader logins = new StreamReader("logins.db");
        //create a list of strings for usernames and for passwords
        private List<string> usernames = new List<string>();
        private List<string> passwords = new List<string>();

        public login()
        {
            InitializeComponent();
            //initialize our usernames and passwords using the StreamReader
            while (logins.Peek() != -1)
            {
                //get the next username and password
                usernames.Add(logins.ReadLine());
                passwords.Add(logins.ReadLine());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //close the form using this.Close();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                //user did not enter a username or a password, display a message box
                MessageBox.Show("No username or password entered.", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsername.Focus();
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
                        //display a messagebox indicating a successful login

                        //TODO make this link to main client once that is built
                        MessageBox.Show("Login successful!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        success = true;
                        break;
                    }
                }
                //if login unsuccessful then display a messagebox saying that it wasn't
                if (!success)
                {
                    MessageBox.Show("Username/password is incorrect. Please try again.", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                }
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
    }
}
