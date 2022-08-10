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
        UsernameAndPassword userNameAndPassword = new UsernameAndPassword();
        //RegisterFrame registerFrame = new RegisterFrame();
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
            
          
            if(userNameAndPassword.checkUsername() == true && userNameAndPassword.checkPassword() == true)
            {
                userNameAndPassword.checkingUserName();
                userNameAndPassword.checkingPassword();
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Incorrect Login Details");
            };
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
           userNameAndPassword.Username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {
            userNameAndPassword.Password = passwordTextBox.Text;    
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            
            frmMain.Instance.Content.Controls.Add(new RegisterFrame { Dock = DockStyle.Fill });
            frmMain.Instance.Content.Controls[0].SendToBack();
            
            

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
