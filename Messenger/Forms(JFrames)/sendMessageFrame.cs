using MaterialSkin;
using MaterialSkin.Controls;
using Messenger.Classes;
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
    public partial class sendMessageFrame : MaterialForm
    {
        Server server = new Server();
        public sendMessageFrame()
        {
           
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void sendMessageFrame_Load(object sender, EventArgs e)
        {

        }

        private void displayedText_TextChanged(object sender, EventArgs e)
        {
            server.getTextFromUser = displayedText.Text;
        }
    }
}
