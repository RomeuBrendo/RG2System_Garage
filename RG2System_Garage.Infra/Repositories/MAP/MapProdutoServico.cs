using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapProdutoServico : IEntityTypeConfiguration<ProdutoServico>
    {
        public void Configure(EntityTypeBuilder<ProdutoServico> builder)
        {
            builder.ToTable("ProdutoServico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasMaxLength(150);
            builder.Property(x => x.Observacao).HasMaxLength(2000).HasDefaultValue("");

            builder.Ignore(x => x.UltimaMovimentacao);

        }
    }
}
