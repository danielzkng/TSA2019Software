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
    }
}
