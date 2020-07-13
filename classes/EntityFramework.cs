using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eindproject2
{
    class EntityFramework
    {
        public string oneQuerieEntity;
        public string thousandQuerieEntity;
        public string hunderdThousandQuerieEntity;
        public string milionQuerieEntity;

        public void run1QueryEntity(string email, string password, int numberOfAccount)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var account = new Account
            {
                id = 1,
                email = email,
                user_password = password,
                logonAttempt = 0,
                wrongLogon = 0,
                number_of_account = numberOfAccount,
                activated = true,
                blocked = false
            };
            using (var entity = new NetflixContext())
            {
                entity.Accounts.Add(account);
                var account_find = entity.Accounts.Find(1);
                account_find.email = "test@test.com";
                entity.Accounts.Remove(account_find);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.oneQuerieEntity = elapsedTime;
            Console.Write("test");
        }
        public void run1000QueryEntity(string email, string password, int numberOfAccount)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for(int i = 2; i <= 1000; i++)
            {
                var account = new Account
                {
                    id = i,
                    email = email,
                    user_password = password,
                    logonAttempt = 0,
                    wrongLogon = 0,
                    number_of_account = numberOfAccount,
                    activated = true,
                    blocked = false
                };
                using (var entity = new NetflixContext())
                {
                    entity.Accounts.Add(account);
                    var account_find = entity.Accounts.Find(i);
                    account_find.email = "test"+ i + "@test.com";
                    entity.Accounts.Remove(account_find);
                }
            }
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.thousandQuerieEntity = elapsedTime;
            Console.Write("test");
        }

        
        public void run100000Querys(string email, string password, int numberOfAccounts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 2; i <= 100000; i++)
            {
                var account = new Account
                {
                    id = i,
                    email = email,
                    user_password = password,
                    logonAttempt = 0,
                    wrongLogon = 0,
                    number_of_account = numberOfAccounts,
                    activated = true,
                    blocked = false
                };
                using (var entity = new NetflixContext())
                {
                    entity.Accounts.Add(account);
                    var account_find = entity.Accounts.Find(i);
                    account_find.email = "test" + i + "@test.com";
                    entity.Accounts.Remove(account_find);
                }
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.hunderdThousandQuerieEntity = elapsedTime;
            Console.Write("test");
        }

        public void run1000000Querys(string email, string password, int numberOfAccounts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 2; i <= 100000; i++)
            {
                var account = new Account
                {
                    id = i,
                    email = email,
                    user_password = password,
                    logonAttempt = 0,
                    wrongLogon = 0,
                    number_of_account = numberOfAccounts,
                    activated = true,
                    blocked = false
                };
                using (var entity = new NetflixContext())
                {
                    entity.Accounts.Add(account);
                    var account_find = entity.Accounts.Find(i);
                    account_find.email = "test" + i + "@test.com";
                    entity.Accounts.Remove(account_find);
                }
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            this.milionQuerieEntity = elapsedTime;
            Console.Write("test");
        }

    }
    //account table
    public class Account
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string user_password { get; set; }
        public int logonAttempt { get; set; }
        public int wrongLogon { get; set; }
        public int number_of_account { get; set; }
        public Boolean activated { get; set; }
        public DateTime blocked_from { get; set; }
        public Boolean blocked { get; set; }
    }
    //age advise table
    public class Age_Advice
    {
        [Key]
        public int id { get; set; }
        public int age { get; set; }
        public string age_advise { get; set; }
    }

    //film table
    public class Film
    {
        [Key]
        public int id { get; set; }
        public string film_name { get; set; }
        public Genre genre { get; set; }
        public string file { get; set; }
    }

    //genre table
    public class Genre
    {
        [Key]
        public int id { get; set; }
        public string genre_name { get; set; }
        public Age_Advice age { get; set; }
    }

    //media table
    public class Media
    {
        [Key]
        public int id { get; set; }
        public Serie serie_id { get; set; }
        public Film film_id { get; set; }
        public Genre genre_id { set; get; }
        public Age_Advice age_advice { set; get; }
        public Subtiltle subtitle_id { set; get; }
    }

    //package table
    public class Package
    {
        [Key]
        public int id { get; set; }
        public float price { get; set; }
        public int length { get; set; }
    }

    //preference table
    public class Preference
    {
        [Key]
        public int user_id { get; set; }
        public Genre genre_id { get; set; }
        public Age_Advice age_Advice { get; set; }
        public Profile profile_id { get; set; }
        public Account profile_account_id { get; set; }
        public Watchlist profile_watchlist_id { get; set; }
    }

    //Profile table
    public class Profile
    {
        [Key]
        public int id { get; set; }
        public Account account_id { get; set; }
        public string name { get; set; }
        public string profile_picture { get; set; }
        public int age { get; set; }
        public string user_language { get; set; }
        public int times_pasword_reset { get; set; }
    }

    //seasons table
    public class Season
    {
        [Key]
        public int id { get; set; }
        public string season_name { get; set; }
        public Serie serie_id { get; set; }
        public string episode_name { get; set; }
        public int episode_length { get; set; }
        public string file { get; set; }
    }

    //serie table
    public class Serie
    {
        [Key]
        public int id { get; set;}
        public string name { get; set; }
    }

    //subscription table
    public class Subscription
    {
        [Key]
        public int id { get; set; }
        public Package package_id { get; set; }
        public string subscription_name { get; set; }
        public DateTime start_date { get; set; }
        public Account account_id { get; set; }
    }

    //subscription_has_account table
    /*public class Subscription_has_account
    {
        [Key]
        public Subscription subscription_id { get; set; }
        public Account account_id { get; set; }
        public Profile profile_id { get; set; }
    }*/

    //subtitle table
    public class Subtiltle
    {
        [Key]
        public int id { get; set; }
        public string subtitle_language { get; set; }
        public string subtitle_fila { get; set; }
    }

    //to_watchlist table
    public class To_watchlist
    {
        [Key]
        public int id { get; set; }
        public Media media_id { get; set; }
        public Profile profile_id { get; set; }
    }

    //watchlist table
    public class Watchlist
    {
        [Key]
        public int id { get; set; }
        public int paused_time { get; set; }
        public Media media { get; set; }
        public Profile profile { get; set; }
        public Boolean finished { get; set; }
    }
    //Database setup
    public class NetflixContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Age_Advice> Age_Advices { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        //public DbSet<Subscription_has_account> subscription_Has_Accounts { get; set; }
        public DbSet<Subtiltle> Subtiltles { get; set; }
        public DbSet<To_watchlist> To_Watchlists { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
    }
}
