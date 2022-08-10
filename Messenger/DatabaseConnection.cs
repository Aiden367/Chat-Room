using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class DatabaseConnection
    {
        public void connection()
        {
            string connectionString;

            SqlConnection cnn;
            try
            {
                connectionString = "Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;";

                cnn = new SqlConnection(connectionString);

                cnn.Open();

                MessageBox.Show("Connected to Database");
                cnn.Close();
               
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Could not connect to Database");
            }

        }

    }
}
