using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapMovimentacao : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.ToTable("Movimentacao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoCusto).HasColumnName("PrecoCusto");
            builder.Property(x => x.PrecoVenda).HasColumnName("PrecoVenda");
            builder.Property(x => x.EstoqueAtual).HasColumnName("EstoqueAtual");
        }
    }
}
