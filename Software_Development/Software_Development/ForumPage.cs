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
    public partial class ForumPage : Form
    {
        public ForumPage()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelThread1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked thread 1!");
        }
    }
}
