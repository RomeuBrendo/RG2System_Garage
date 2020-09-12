using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(300);
            builder.Property(x => x.Telefone1).HasMaxLength(15);
            builder.Property(x => x.Telefone2).HasMaxLength(15);
            builder.Property(x => x.CPFCNPJ).HasMaxLength(20);
        }
    }
}
