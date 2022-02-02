using K205Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace K205Agency.Data
{
    public class AgencyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = AgencyDB; Trusted_Connection = True; MultipleActiveResultSets = true");
        }


        public DbSet<Masthead> Mastheads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
