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
    public partial class ucMain : UserControl
    {
        sendMessageFrame sendMessageFrame = new sendMessageFrame();
        public ucMain()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sendMessageFrame userControl = new sendMessageFrame();
            sendMessageFrame.Show();
        }
    }
}
