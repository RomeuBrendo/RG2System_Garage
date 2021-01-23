using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    class MapOrdemServico : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.Property(x => x.Observacao);

            builder.Property(x => x.DataFinalizacao).HasDefaultValue(null);
            builder.Property(x => x.Status).HasMaxLength(50);

            builder.HasOne(x => x.Orcamento).WithMany().HasForeignKey("OrcamentoId");
            builder.HasMany(x => x.FormaPagamentos).WithOne().HasForeignKey("FormaPagamentoId");

            builder.HasIndex(x => x.Numero);
            builder.Property(x => x.Numero).ValueGeneratedOnAdd().IsUnicode();
        }
    }
}
