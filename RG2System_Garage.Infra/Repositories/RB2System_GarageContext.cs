using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Infra.Repositories.MAP;

namespace RG2System_Garage.Infra.Repositories
{
    public class RB2System_GarageContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=RG2System;Uid=root;Pwd=root;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Ignore<ConventionPropertyExtensions>();

            //ignorar classes
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new MapVeiculo());
            modelBuilder.ApplyConfiguration(new MapCliente());
            modelBuilder.ApplyConfiguration(new MapProduto());

            base.OnModelCreating(modelBuilder);
        }
    }
}
