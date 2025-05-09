using Microsoft.EntityFrameworkCore;
using ProductManager.Models;

namespace ProductManager
{
    public class IsiContext : DbContext
    {
        public DbSet<ProdukModel> Produks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DBproduk;Username=postgres;Password=nafariel01");
        }
    }
}
