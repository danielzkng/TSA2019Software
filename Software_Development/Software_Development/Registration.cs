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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public List<string> usernames
        {
            get; set;
        }

        public List<string> passwords
        {
            get; set;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach(string s in usernames)
            {
                if(textBoxUsername.Text == s)
                {
                    ok = false;
                }
            }

            if (ok)
            {
                if(textBoxPassword.Text == textBoxRepeatPassword.Text)
                {
                    //check for blanks
                    if(textBoxPassword.Text == "" || textBoxUsername.Text == "")
                    {
                        MessageBox.Show("One or more required fields is empty! Please fill them all out.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //we're done here
                        LoginPage.newUsername = textBoxUsername.Text;
                        LoginPage.newPassword = textBoxPassword.Text;
                        //close this form
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Passwords do not match! Please check them and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("That username is already taken! Please try another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //close this form, do nothing
            this.Close();
        }

        private void Registration_Shown(object sender, EventArgs e)
        {
            Location = WindowManager.CurrentLocation;
        }
    }
}
