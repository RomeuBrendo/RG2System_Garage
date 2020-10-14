using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.ValueObjects;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    class MapConfiguracaoDadosEmpresa : IEntityTypeConfiguration<ConfiguracaoDadosEmpresa>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoDadosEmpresa> builder)
        {
            builder.ToTable("ConfiguracaoDadosEmpresa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Endereco).HasMaxLength(1000);

            builder.OwnsOne<Nome>(x => x.Nome, cb => {
                cb.Property(x => x.RazaoSocial).HasMaxLength(500).IsRequired().HasColumnName("RazaoSocial");
                cb.Property(x => x.Fantasia).HasMaxLength(500).IsRequired().HasColumnName("NomeFantasia");
            });

            builder.OwnsOne<Telefone>(x => x.Telefone, cb => {
                cb.Property(x => x.Celular).HasMaxLength(16).IsRequired().HasColumnName("Celular");
                cb.Property(x => x.Fixo).HasMaxLength(16).IsRequired().HasColumnName("Fixo");
            });

            builder.OwnsOne<Email>(x => x.Email, cb => {
                cb.Property(x => x.Endereco).HasMaxLength(50).IsRequired().HasColumnName("Email");
            });
        }
    }
}
