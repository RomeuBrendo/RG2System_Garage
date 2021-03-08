using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapORPagamento : IEntityTypeConfiguration<ORPagamento>
    {
        public void Configure(EntityTypeBuilder<ORPagamento> builder)
        {
            builder.ToTable("ORPagamento");

            builder.HasKey(x => x.Id);

          //  builder.HasOne(x => x.OrdemServico).WithMany().HasForeignKey("OrdemServicoId");
            builder.HasOne(x => x.FormaPagamento).WithMany().HasForeignKey("FormaPagamentoId");

            builder.Property(x => x.Valor).HasColumnType<decimal>("decimal(18,2)");
        }
    }
}
