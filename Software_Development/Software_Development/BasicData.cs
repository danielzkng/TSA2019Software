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
    }
}
