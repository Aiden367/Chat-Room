using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Data.SqlClient;

namespace Messenger.Classes
{

    public class UsernameAndPassword
    {
        private string userName;

        private string passWord;

        private string registerUsername;

        private string registerPassword;

       private String returnValidUsername;

       private String returnValidPassword;

        ucMain ucMain = new ucMain();
        DatabaseConnection DatabaseConnection = new DatabaseConnection();
        //TO DO * add a database to this project 
        //      *add a register GUI
        //      *add a check to see if the username is correctly formatted

        //Method for getting registeredUsername
        public string getRegisteredUsername
        {
            get { return registerUsername; }
            set { registerUsername = value; }
        }

        //Method for getting the registered password
        public string getRegisteredPassword
        {
            get { return registerPassword; }
            set { registerPassword = value; }
        }
        public string Username
        {

            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }

        //Method for checking registered username
        public bool registerCheckUsername()
        {
            string characterChecker = "[A-Z]";

            string numberChecker = "[0-9]"
                ;
            string specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);

            //Username must contain 1 capital letter, 1 number and one special character
            if (re1.IsMatch(registerUsername) && re2.IsMatch(registerUsername) && re3.IsMatch(registerUsername) && registerUsername.Length <= 10)
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
        public bool registerCheckPassword()
        {
            string characterChecker = "[A-Z]";

            string numberChecker = "[0-9]"
                ;
            string specialCharacterChecker = "[^a-zA-z0-9]";

            Regex re1 = new Regex(characterChecker);

            Regex re2 = new Regex(numberChecker);

            Regex re3 = new Regex(specialCharacterChecker);


            if (re1.IsMatch(registerPassword) && re2.IsMatch(registerPassword) && re3.IsMatch(registerPassword) && registerPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for checking registered password
        public string registerCheckingPassword()
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



       

        public void usernameAndPasswordToDatabase()
        {
            if (registerCheckPassword() == true && registerCheckUsername() == true)
            {


                try
                {
                    SqlConnection conn = new SqlConnection("Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;TrustServerCertificate=True;");
                    //con = DatabaseConnection.getConnection;
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO UsernameAndPassword VALUES('" + "2131" + "','" + registerUsername + "','" + registerPassword + "')", conn);

                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data added to database");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                    MessageBox.Show("Could not add data");
                }
            }

        }

        //Method for validating username and password entered into login so that the user can login to their account
        public void validateUsernameAndPassword()
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;TrustServerCertificate=True;");
            String query = "SELECT * FROM UsernameAndPassword Where Username = '" + userName + "' and Password = '" + passWord + "'";
        
            try
            {
                conn.Open();
                SqlDataAdapter cmd = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();

                //Data from query fills table
                cmd.Fill(dataTable);

                //If the data has been populated in the table then it should show only one row therefore showing that the username and password are connected to a registered account
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Correct Login Details");
                    frmMain.Instance.Content.Controls.Add(new ucMain { Dock = DockStyle.Fill });
                    frmMain.Instance.Content.Controls[0].SendToBack();

                }
                else
                {
                    MessageBox.Show("Incorrect Login Details");
                }
                
                
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Could not load data from database");
            }
            
        }

    }
}
