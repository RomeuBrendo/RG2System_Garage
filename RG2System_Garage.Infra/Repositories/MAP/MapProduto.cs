using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao).HasMaxLength(150);
            
            builder.Property(x => x.Estoque).HasMaxLength(15000);
        }
    }
}
