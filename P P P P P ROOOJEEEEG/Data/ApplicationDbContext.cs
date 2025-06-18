using Microsoft.EntityFrameworkCore;
using  RUSUNAWAAA.Models;

namespace RusunawaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Penyewa> Penyewas { get; set; }
        public DbSet<Pengajuan> Pengajuans { get; set; }
        public DbSet<PerpanjanganSewa> Perpanjangans { get; set; }
        public DbSet<Laporan> Laporans { get; set; }
        public DbSet<Ulasan> Ulasans { get; set; }
        public DbSet<MediaVirtual> MediaVirtuals { get; set; }
        public DbSet<TataTertib> TataTertibs { get; set; }
        public DbSet<Kontak> Kontaks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RusunawaNew;Username=postgres;Password=KFM9M$JF");
        }

    }
}
