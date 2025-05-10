using Microsoft.EntityFrameworkCore;
using  RUSUNAWAAA.Models;

namespace RusunawaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Penghuni> Penghunis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=rusunawa;Username=postgres;Password=KFM9M$JF");
        }
    }
}
