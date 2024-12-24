using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
public class AppDBContext(DbContextOptions<AppDBContext> options): DbContext(options) {

    public DbSet<WalletEntity> Wallets { get; set; }
    public DbSet<TransferEntity> Transfer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<WalletEntity>()
            .HasIndex(i => new { i.CPFCNPJ, i.Mail })
            .IsUnique();

        modelBuilder.Entity<WalletEntity>()
            .Property(c => c.CurrentBalance)
            .HasColumnType("decimal(10,2)");

        modelBuilder.Entity<WalletEntity>()
            .Property(u => u.UserType)
            .HasConversion<string>();

        modelBuilder.Entity<TransferEntity>()
            .HasKey(t => t.IdTransfer);

        modelBuilder.Entity<TransferEntity>()
            .HasOne(s => s.Sender)
            .WithMany()
            .HasForeignKey(fk => fk.SenderId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Transaction_Sender");

        modelBuilder.Entity<TransferEntity>()
            .Property(v => v.Valor)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<TransferEntity>()
            .HasOne(t => t.Receiver)
            .WithMany()
            .HasForeignKey(r => r.Receiver)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Transaction_Receiver");
    }
}