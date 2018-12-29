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
    public partial class dashboard : Form
    {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
