using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapOrcamentoItens : IEntityTypeConfiguration<OrcamentoItem>
    {
        public void Configure(EntityTypeBuilder<OrcamentoItem> builder)
        {
            builder.ToTable("OrcamentoItem");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoVenda).HasMaxLength(999999);
            builder.Property(x => x.Quantidade).HasMaxLength(9999).HasDefaultValue(0);
        }

    }
}
