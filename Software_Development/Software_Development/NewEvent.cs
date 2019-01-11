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
    public partial class NewEvent : Form
    {
        public NewEvent()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //needs no explanation
            this.Close();
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {
            monthCalendarDate.MinDate = DateTime.Now;
            comboBox1.Items.Add("None");
            foreach(Calendar c in GlobalData.CalendarsDB)
            {
                comboBox1.Items.Add(c.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "")
            {
                MessageBox.Show("You must enter a name!");
            }
            else if(textBoxDescription.Text == "")
            {
                MessageBox.Show("You must enter a description!");
            }
            else
            {
                GlobalData.EventsDB.Add(new CalEvent(monthCalendarDate.SelectionStart, GlobalData.CurrentUser.ID, textBoxName.Text, textBoxDescription.Text, GlobalData.EventsDB.Count()));
                this.Close();
            }
        }
    }
}
