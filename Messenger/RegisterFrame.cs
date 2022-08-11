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
    public partial class RegisterFrame : UserControl
    {
       
       
        UserControl1 userControl1 = new UserControl1();

        UsernameAndPassword UsernameAndPassword = new UsernameAndPassword();
        public RegisterFrame()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsernameAndPassword.checkingRegisteredUserName();
            UsernameAndPassword.registerCheckingPassword();
            UsernameAndPassword.usernameAndPasswordToDatabase();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userControl1.Show();

            
        }

        private void RegisterFrame_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUsername_TextChanged(object sender, EventArgs e)
        {
            //UsernameAndPassword.checkingRegisteredUserName();
            UsernameAndPassword.getRegisteredUsername = registerUsername.Text;

        }

        private void registerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameAndPassword.getRegisteredPassword = registerPasswordTextBox.Text;
        }
    }
}
