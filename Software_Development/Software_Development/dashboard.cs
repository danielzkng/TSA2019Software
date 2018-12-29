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
    public partial class dashboard : Form
    {
        //instance variables
        bool logout = false; //boolean variable for declaring whether or not a form-close is a logout or not

        public dashboard()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonCalendar.BackColor = Color.FromArgb(52, 73, 94);
            buttonHome.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(52, 73, 94);
            buttonCalendar.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //IGNORE this code for now - will be used later to implement logout functionality once more of the program is built

            if (!logout)
            {
                //this is a standard issue exit
                //the login screen also needs to be closed for a full exit
                FormsInProgram.loginInUse.Close();
            }
            else
            {
                //this is a logout, we need to show the login screen again
                FormsInProgram.loginInUse.Show();
            }
        }
    }
}
