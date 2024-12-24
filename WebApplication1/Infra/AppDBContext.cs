using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models;

public class AppDBContext(DbContextOptions<AppDBContext> options): DbContext(options) {

    public DbSet<CarteiraEntity> Wallets { get; set; }
    public DbSet<TransferEntity> Transfer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<CarteiraEntity>()
            .HasIndex(i => new { i.CPFCNPJ, i.Email })
            .IsUnique();
    }
}