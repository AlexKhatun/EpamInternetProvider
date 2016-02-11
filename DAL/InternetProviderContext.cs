using System.Data.Entity;
using BOL.Models;

namespace DAL
{
    public class InternetProviderContext : DbContext
    {
        public InternetProviderContext() : base("InternetProviderContext") { }

        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Purse> Purse { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; } 
    }
}
