using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AutoSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReserialize_Click(object sender, EventArgs e)
        {
            if (radioButtonUsers.Checked)
            {
                SerializeData("users.db", Objty.User);
            }

            else if (radioButtonCalendars.Checked)
            {
                SerializeData("calendars.db", Objty.Calendar);
            }

            else if (radioButtonEvents.Checked)
            {
                SerializeData("events.db", Objty.Event);
            }

            else if (radioButtonMessages.Checked)
            {
                SerializeData("messages.db", Objty.Message);
            }

            else if (radioButtonThreads.Checked)
            {
                SerializeData("threads.db", Objty.Thread);
            }

            else if (radioButtonPrivateMessages.Checked)
            {
                SerializeData("privatemsgs.db", Objty.Private);
            }

            else
            {
                MessageBox.Show("select a file to serialize you nimrod");
            }
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {

            if (radioButtonUsers.Checked)
            {
                DeserializeData("users.db", Objty.User);
            }

            else if (radioButtonCalendars.Checked)
            {
                DeserializeData("calendars.db", Objty.Calendar);
            }

            else if (radioButtonEvents.Checked)
            {
                DeserializeData("events.db", Objty.Event);
            }

            else if (radioButtonMessages.Checked)
            {
                DeserializeData("messages.db", Objty.Message);
            }

            else if (radioButtonThreads.Checked)
            {
                DeserializeData("threads.db", Objty.Thread);
            }

            else if (radioButtonPrivateMessages.Checked)
            {
                DeserializeData("privatemsgs.db", Objty.Private);
            }

            else
            {
                MessageBox.Show("select a file to deserialize you nimrod");
            }
        }

        void SerializeData(string Filename, Objty type)
        {
            //TODO read all data from the file and then serialize it
        }

        void DeserializeData(string Filename, Objty type)
        {
            //TODO read all data from the file and then deserialize it
        }

        //enum for data types (Objty = OBJect TYpe)
        enum Objty
        {
            Message,
            Thread,
            Private,
            User,
            Calendar,
            Event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("drag file to be serialized into the \\bin\\debug\\ directory of this project then select its name in the RH sidebar and click a button to do stuff to the file\n" +
                "NOTE: the program will choke if asked to serialize a serialized file or deserialize a deserialized file\nif you need more help contact either daniel or someone with actual brain cells");
        }
    }
}
