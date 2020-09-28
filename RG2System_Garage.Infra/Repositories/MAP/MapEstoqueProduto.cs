using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapEstoqueProduto : IEntityTypeConfiguration<EstoqueProduto>
    {
        public void Configure(EntityTypeBuilder<EstoqueProduto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoCusto).HasColumnName("PrecoCusto");
            builder.Property(x => x.PrecoVenda).HasColumnName("PrecoVenda");
            builder.Property(x => x.EstoqueAtual).HasColumnName("EstoqueAtual");
        }
    }
}
