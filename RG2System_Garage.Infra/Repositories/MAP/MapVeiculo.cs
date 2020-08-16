using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapVeiculo : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Placa).HasMaxLength(15);

            builder.Property(x => x.Modelo).HasMaxLength(150);
            
        }
    }
}
