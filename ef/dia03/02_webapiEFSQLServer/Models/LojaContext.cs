using Microsoft.EntityFrameworkCore;

namespace _02_webapiEFSQLServer.Models;

public class LojaContext : DbContext
{
    public DbSet<Cliente> clientes {get; set;} = null!;
    public DbSet<Pedido> pedidos {get; set;} = null!;
    public DbSet<Produto> produtos {get; set;} = null!;
    //public DbSet<Item> itens {get; set;} = null!;
    public LojaContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pedido>()
                    .HasMany(ped => ped.produtos)
                    .WithMany(prod => prod.pedidos)
                    .UsingEntity<Item>();
    }

}