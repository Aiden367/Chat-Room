using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String text = "Eat Deez nuts";
            //MessageBox.Show(text);
            frmMain.Instance.Content.Controls.Add(new ucMain { Dock = DockStyle.Fill });
            frmMain.Instance.Content.Controls[0].SendToBack();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
