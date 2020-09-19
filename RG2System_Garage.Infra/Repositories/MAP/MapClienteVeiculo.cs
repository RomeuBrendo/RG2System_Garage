using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    class MapClienteVeiculo : IEntityTypeConfiguration<ClienteVeiculo>
    {
        public void Configure(EntityTypeBuilder<ClienteVeiculo> builder)
        {
            builder.ToTable("ClienteVeiculo");

            builder.HasKey(x => x.Id);

            //Foreikey
            //builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("ClienteId");
            //builder.HasOne(x => x.Veiculo).WithMany().HasForeignKey("VeiculoId");
        }
    }
}
