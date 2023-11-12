

using Microsoft.EntityFrameworkCore;
using PasswordManager.Core.Models;

namespace PasswordManager.Core.Data
{
    public class PasswordManagerDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Vault> Vault { get; set; }

        public PasswordManagerDbContext() : base() { }

        public PasswordManagerDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .HasKey(user => user.Id); // User entitás kulcs beállítása

            modelBuilder.Entity<Vault>()
                .HasKey(vault => vault.Id); // Vault entitás kulcs beállítása

            modelBuilder.Entity<Vault>()
                .HasOne(vault => vault.User)
                .WithMany(user => user.Vaults)
                .HasForeignKey(vault => vault.UserId); // Kapcsolat definiálása

            // Egyéb konfigurációk itt

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

