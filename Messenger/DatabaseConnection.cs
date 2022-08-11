using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Messenger
{
    public class DatabaseConnection
    {
        private SqlConnection databaseConnectionString;

        public SqlConnection getConnection
        {
            get { return databaseConnectionString; }
            set { databaseConnectionString = value; }

        }
        public void connection()
        {
            string connectionString;

            SqlConnection cnn;
            try
            {
                connectionString = "Data Source = DESKTOP-ALULP91\\SQLEXPRESS;Initial Catalog = ChatroomDB;Integrated Security = True;TrustServerCertificate=True;";
               
                cnn = new SqlConnection(connectionString);
                getConnection = cnn;
                cnn.Open();

                MessageBox.Show("Connected to Database");


            }
            catch (SqlException  e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Could not connect to Database");
            }

        }


        
        
    }
}
