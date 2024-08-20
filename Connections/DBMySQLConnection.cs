using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;
using System.Data;
using System.Data.Common;

namespace PortfolioAPI.Connections
{
    public class DBMySQLConnection : DbContext
    {
        public DBMySQLConnection(DbContextOptions<DBMySQLConnection> options) : base(options)
        {
        }

        public DbSet<Proyects> Proyects { get; set; }
        public DbSet<Experience> Experience { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proyects>().ToTable("Proyects");
            modelBuilder.Entity<Experience>().ToTable("Experience");
        }

    }
}
