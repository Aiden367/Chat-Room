using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Messenger
{

    public class UsernameAndPassword
    {
        private String userName;

        private String passWord;

        private String registerUsername;

        private String registerPassword;

        DatabaseConnection DatabaseConnection = new DatabaseConnection();   
        //TO DO * add a database to this project 
        //      *add a register GUI
        //      *add a check to see if the username is correctly formatted

        //Method for getting registeredUsername
        public String getRegisteredUsername
        {
            get { return registerUsername; }
            set { registerUsername = value; }
        }

        //Method for getting the registered password
        public String getRegisteredPassword
        {
            get { return registerPassword; }
            set { registerPassword = value; }
        }
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

        //Method for checking registered username
        public Boolean registerCheckUsername()
        {
            String characterChecker = "[A-Z]";

            String numberChecker = "[0-9]"
                ;
            String specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);

            //Username must contain 1 capital letter, 1 number and one special character
            if (re1.IsMatch(registerUsername) && re2.IsMatch(registerUsername) && re3.IsMatch(registerUsername) && registerUsername.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for checking registered Username
        public string checkingRegisteredUserName()
        {
            if (registerCheckUsername() == true)
            {
                MessageBox.Show("Correct Username");

                //Code used to get instances of frames into other classes 
                //frmMain.Instance.Content.Controls.Add(new ucMain { Dock = DockStyle.Fill });

                //frmMain.Instance.Content.Controls[0].SendToBack();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details");

            }

            return registerUsername;
        }

        //method for checking registered password
        public Boolean registerCheckPassword()
        {
            String characterChecker = "[A-Z]";

            String numberChecker = "[0-9]"
                ;
            String specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);


            if (re1.IsMatch(registerPassword) && re2.IsMatch(registerPassword) && re3.IsMatch(registerPassword) && registerPassword.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for checking registered password
        public String registerCheckingPassword()
        {
            if (registerCheckPassword() == true)
            {
                MessageBox.Show("Password correct");
            }
            else
            {
                MessageBox.Show("Password  incorrect");
            }

            return registerPassword;
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
            if (re1.IsMatch(userName) && re2.IsMatch(userName) && re3.IsMatch(userName) && userName.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for checking registered Username
        public string checkingUserName()
        {
            if (registerCheckUsername() == true)
            {
                MessageBox.Show("Correct Username");

                //Code used to get instances of frames into other classes 
                //frmMain.Instance.Content.Controls.Add(new ucMain { Dock = DockStyle.Fill });

                //frmMain.Instance.Content.Controls[0].SendToBack();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details");

            }

            return userName;
        }

        //method for checking registered password
        public Boolean checkPassword()
        {
            String characterChecker = "[A-Z]";

            String numberChecker = "[0-9]"
                ;
            String specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);


            if (re1.IsMatch(passWord) && re2.IsMatch(passWord) && re3.IsMatch(passWord) && passWord.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for checking registered password
        public String checkingPassword()
        {
            if (registerCheckPassword() == true)
            {
                MessageBox.Show("Password correct");
            }
            else
            {
                MessageBox.Show("Password  incorrect");
            }

            return passWord;
        }

        public void usernameAndPasswordToDatabase()
        {
            //SqlConnection conn = new SqlConnection("Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;TrustServerCertificate=True;");
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;TrustServerCertificate=True;");
                //con = DatabaseConnection.getConnection;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UsernameAndPassword VALUES('" + "2131" +"','" + registerUsername + "','" + registerPassword + "')", conn);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added to database");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);    
                MessageBox.Show("Could not add data");
            }

        }
    }
}
