using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapFormaPagamento : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("FormaPagamento");

            builder.HasKey("Id");
            builder.Property(x => x.Descricao).HasMaxLength(150);
            builder.Property(x => x.Tipo).HasMaxLength(30);
            builder.Property(x => x.PrazoRecebimento).HasMaxLength(150);
            builder.Property(x => x.QuantidadeParcela).HasMaxLength(80);

        }
    }
}
