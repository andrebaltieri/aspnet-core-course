using Microsoft.Data.Entity;
using AspNetMac.Models;

namespace AspNetMac.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}