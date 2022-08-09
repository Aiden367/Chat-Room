using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Messenger
{
  
    public class UsernameAndPassword
    {
        private String userName;
        private String passWord;
        //TO DO * add a database to this project 
        //      *add a register GUI
        //      *add a check to see if the username is correctly formatted

       

        public String Username
        {

            get { return userName; }
            set { userName = value; }
        }

        public String Password
        {
            get { return passWord; }
            set { passWord = value; }
        }

        
        public Boolean checkUsername()
        {
            String characterChecker = "[A-Z]";

            String numberChecker = "[0-9]"
                ;
            String specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker); 

            //Username must contain 1 capital letter, 1 number and one special character
            if(re1.IsMatch(userName) && re2.IsMatch(userName) && re3.IsMatch(userName) && userName.Length >=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string checkingUserName()
        {
            if (checkUsername() == true)
            {
                MessageBox.Show("Correct Username");

                //Code used to get instances of frames into other classes 
                frmMain.Instance.Content.Controls.Add(new ucMain { Dock = DockStyle.Fill });

                frmMain.Instance.Content.Controls[0].SendToBack();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details");
               
            }

            return userName;    
        }

        public Boolean checkPassword()
        {
            String characterChecker = "[A-Z]";

            String numberChecker = "[0-9]"
                ;
            String specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);


            if (re1.IsMatch(passWord) && re2.IsMatch(passWord) && re3.IsMatch(passWord) && passWord.Length >=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String checkingPassword()
        {
            if(checkPassword() == true)
            {
                MessageBox.Show("Password correct");
            }
            else
            {
                MessageBox.Show("Password  incorrect");
            }

            return passWord;
        }
    }
}
