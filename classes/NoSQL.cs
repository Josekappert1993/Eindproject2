using MongoDB.Driver;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Eindproject2
{
    class NoSQL
    {
        /*private MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false");
        private int i;
        public string milionQuerieNosql;

        public MongoClient DbClient { get => dbClient; set => dbClient = value; }

        public NoSQL()
        {

        }
        public void run1Query(string email)
        {
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            using ()
            {
                var name = email;
                

                stopWatch2.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch2.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("100000 query RunTime " + elapsedTime);
                milionQuerieNosql = elapsedTime;
                MessageBox.Show("1000000 queries");
            }
        }

        public void run1000Querys(string email)
        {
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            using ()
            {
                var name = email;
                for (this.i = 0; this.i <= 1000; this.i++)
                {

                }

                stopWatch2.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch2.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("100000 query RunTime " + elapsedTime);
                milionQuerieNosql = elapsedTime;
                MessageBox.Show("1000000 queries");
            }
        }

        public void run100000Querys()
        {
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            using ()
            {
                var name = email;
                for (this.i = 0; this.i <= 100000; this.i++)
                {

                }

                stopWatch2.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch2.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("100000 query RunTime " + elapsedTime);
                milionQuerieNosql = elapsedTime;
                MessageBox.Show("1000000 queries");
            }

        }

        public void run1000000Querys()
        {

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            using ()
            {
                var name = email;
                for (this.i = 0; this.i <= 1000000; this.i++)
                {

                }

                stopWatch2.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch2.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("100000 query RunTime " + elapsedTime);
                milionQuerieNosql = elapsedTime;
                MessageBox.Show("1000000 queries");
            }
        }*/
    }
}
