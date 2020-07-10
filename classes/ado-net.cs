using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Eindproject2
{
    class ado_net
    {
        private string email;
        private string password;
        private int numberOfAccount;

        public string connectionString = "Data Source=LAPTOP-24SL026S;Initial Catalog=netflix;Integrated Security=True";
        public string querie;
        public string thousantQuerys;
        public string hunderdThousandQuerys;
        public string milionQuerys;
        private int i;
        private int j;
        private int k;

        public ado_net(string userEmail, string userPassword, int userNumberOfAccounts)
        {
            this.email = userEmail;
            this.password = userPassword;
            this.numberOfAccount = userNumberOfAccounts;
        }


        public void RunQueries()
        {
           run1Query(email, password, numberOfAccount);
           run1000Querys(email, password, numberOfAccount);
           run100000Querys(email, password, numberOfAccount);
           run1000000Querys(email, password, numberOfAccount);
        }

        public void run1Query(string email, string password, int numberOfAccount)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                String insertQuery = "insert into account (email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values ('" + email + "', '" + password + "', 6, 6, " + numberOfAccount + ", null, null, 1);";
                String readQuery = "SELECT * FROM account where email='" + email + "';";
                String updateQuery = "UPDATE account SET number_of_account = 8 where email='" + email + "';";
                String deleteQuery = "DELETE FROM account where email='" + email + "';";

                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(readQuery, connection);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(updateQuery, connection);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand(deleteQuery, connection);
                cmd4.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("1 query");
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.querie = elapsedTime;
        }



        public void run1000Querys(string email, string password, int numberOfAccount)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                connection.Open();
                Console.WriteLine("test connection");

                for (int i;  this.i <= 1000; this.i++)
                {
                    String insertQuery = "insert into account (email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values ('" + email + "', '" + password + "', 6, 6, " + numberOfAccount + ", null, null, 1);";
                    String readQuery = "SELECT * FROM account where email='" + email + "';";
                    String updateQuery = "UPDATE account SET number_of_account = 8 where email='" + email + "';";
                    String deleteQuery = "DELETE FROM account where email='" + email + "';";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("test insert number:"+this.i);
                    SqlCommand cmd2 = new SqlCommand(readQuery, connection);
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("test read number:"+this.i);
                    SqlCommand cmd3 = new SqlCommand(updateQuery, connection);
                    cmd3.ExecuteNonQuery();
                    Console.WriteLine("test update number:"+this.i);
                    SqlCommand cmd4 = new SqlCommand(deleteQuery, connection);
                    cmd4.ExecuteNonQuery();
                    Console.WriteLine("test deletenumber:"+this.i);                }
                connection.Close();
                MessageBox.Show("1000 queries");
            }
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.thousantQuerys = elapsedTime;
        }

        public void run100000Querys(string email, string password, int numberOfAccount)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("test connection");

                for (int j; this.j <= 100000; this.j++)
                {
                    String insertQuery = "insert into account (email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values ('" + email + "', '" + password + "', 6, 6, " + numberOfAccount + ", null, null, 1);";
                    String readQuery = "SELECT * FROM account where email='" + email + "';";
                    String updateQuery = "UPDATE account SET number_of_account = 8 where email='" + email + "';";
                    String deleteQuery = "DELETE FROM account where email='" + email + "';";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("test insert number:" + this.j);
                    SqlCommand cmd2 = new SqlCommand(readQuery, connection);
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("test read number:" + this.j);
                    SqlCommand cmd3 = new SqlCommand(updateQuery, connection);
                    cmd3.ExecuteNonQuery();
                    Console.WriteLine("test update number:" + this.j);
                    SqlCommand cmd4 = new SqlCommand(deleteQuery, connection);
                    cmd4.ExecuteNonQuery();
                    Console.WriteLine("test deletenumber:" + this.j);
                }
                connection.Close();
                
            }

            stopWatch.Stop();
            MessageBox.Show("100000 queries");
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.hunderdThousandQuerys = elapsedTime;
        }

        public void run1000000Querys(string email, string password, int numberOfAccount)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("test connection");

                for (int k; this.k <= 1000000; this.k++)
                {
                    String insertQuery = "insert into account (email, user_password, logonAttempt, wrongLogon, number_of_account, activated, blocked_from, blocked) values ('" + email + "', '" + password + "', 6, 6, " + numberOfAccount + ", null, null, 1);";
                    String readQuery = "SELECT * FROM account where email='" + email + "';";
                    String updateQuery = "UPDATE account SET number_of_account = 8 where email='" + email + "';";
                    String deleteQuery = "DELETE FROM account where email='" + email + "';";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("test insert number:" + this.k);
                    SqlCommand cmd2 = new SqlCommand(readQuery, connection);
                    cmd2.ExecuteNonQuery();
                    //Console.WriteLine("test read number:" + this.k);
                    SqlCommand cmd3 = new SqlCommand(updateQuery, connection);
                    cmd3.ExecuteNonQuery();
                    Console.WriteLine("test update number:" + this.k);
                    SqlCommand cmd4 = new SqlCommand(deleteQuery, connection);
                    cmd4.ExecuteNonQuery();
                    Console.WriteLine("test deletenumber:" + this.k);
                }
                connection.Close();
                MessageBox.Show("1000000 queries");
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.milionQuerys = elapsedTime;
        }
    }
}
