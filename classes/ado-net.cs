using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eindproject2
{
    class ado_net
    {
        private string email;
        private string password;
        private int numberOfAccount;
        public string connectionString = "server=127.0.0.1;user id=root;database=netflix";
        public ado_net(string userEmail, string userPassword, int userNumberOfAccounts)
        {
            this.email = userEmail;
            this.password = userPassword;
            this.numberOfAccount = userNumberOfAccounts;
        }

        /* public void closeDBConnection()
         {
             SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
             builder.DataSource = "<server>.database.windows.net";
             builder.UserID = "<username>";
             builder.Password = "<password>";
             builder.InitialCatalog = "<database>";
             using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
             {
                 connection.Close();
             }
         }*/

        public void RunQueries()
        {
            Console.WriteLine("test connection");
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String insertQuery = "insert into netflix.account (id, email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values (3000, '" + this.email + "', '" + this.password + "', 6, 6, " + this.numberOfAccount + ", false, null, true);";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("connection is succesfully made..");
                con.Close();
            }
            else
            {
                MessageBox.Show("connection is not made");
            }



            run1Query(email, password, numberOfAccount);
            run1000Querys(email, password, numberOfAccount);
            run100000Querys(email, password, numberOfAccount);
            // closeDBConnection();
        }

        private void run1Query(string email, string password, int numberOfAccount)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "<server>.database.windows.net";
            builder.UserID = "<username>";
            builder.Password = "<password>";
            builder.InitialCatalog = "<database>";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                String insertQuery = "insert into netflix.account (id, email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values (3000, '" + this.email + "', '" + this.password + "', 6, 6, " + this.numberOfAccount + ", false, null, true);";
                String readQuery = "SELECT * FROM netflix.account where id=3000;";
                String updateQuery = "UPDATE netflix.account SET number_of_account = 8 where id=3000;";
                String deleteQuery = "DELETE FROM netflix.account where id=3000;";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                connection.Close();
            }


        }



        public void run1000Querys(string email, string password, int numberOfAccount)
        {

        }

        public void run100000Querys(string email, string password, int numberOfAccount)
        {

        }

        public void run1000000Querys(string email, string password, int numberOfAccount)
        {

        }
    }
}
