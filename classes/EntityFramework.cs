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

    //serie table
    public class Serie
    {
        [Key]
        public int id { get; set;}

    }

    //subtitle table
    public class Subtiltle
    {
        [Key]
        public int id { get; set; }
    }

    public class NetflixContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Age_Advice> Age_Advices { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}
