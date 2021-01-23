using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Infra.Repositories.MAP;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace RG2System_Garage.Infra.Repositories
{
    public class RB2System_GarageContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Veiculo> Veiculos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ProdutoServico> ProdutosServicos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ClienteVeiculo> ClienteVeiculo { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Movimentacao> Movimentacao { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ConfiguracaoDadosEmpresa> ConfiguracaoDadosEmpresa { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Orcamento> Orcamentos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<OrcamentoItem> OrcamentoItens { get; set; }

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
            modelBuilder.ApplyConfiguration(new MapProdutoServico());
            modelBuilder.ApplyConfiguration(new MapClienteVeiculo());
            modelBuilder.ApplyConfiguration(new MapMovimentacao());
            modelBuilder.ApplyConfiguration(new MapConfiguracaoDadosEmpresa());
            modelBuilder.ApplyConfiguration(new MapOrcamento());
            modelBuilder.ApplyConfiguration(new MapOrcamentoItens());
            modelBuilder.ApplyConfiguration(new MapFormaPagamento());
            modelBuilder.ApplyConfiguration(new MapOrdemServico());
            modelBuilder.ApplyConfiguration(new MapORPagamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
