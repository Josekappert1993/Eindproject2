using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Eindproject2
{
    class EntityFramework
    {
        private string account;

        public EntityFramework()
        {

        }
        public void run1Query()
        {
            
        }

        public void run1000Querys()
        {

        }

        public void run100000Querys()
        {

        }

        public void run1000000Querys()
        {

        }
    }
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountEmail { get; set; }
    }

    public class Package
    {
        [Key]
        public int PackageId { get; set; }
        public string PackagePrice { get; set; }
        public string PackageLength { get; set; }
    }

    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
    }

    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
