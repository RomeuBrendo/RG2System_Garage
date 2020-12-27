﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RG2System_Garage.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RG2System_Garage.Infra.Repositories.MAP
{
    public class MapOrcamento : IEntityTypeConfiguration<Orcamento>
    {
        public void Configure(EntityTypeBuilder<Orcamento> builder)
        {
            builder.ToTable("Orcamento");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("ClienteId").OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Observacao).HasMaxLength(1500);
            builder.Property(x => x.ValorTotal).IsRequired();
            builder.Property(x => x.FormaPagamento).HasMaxLength(50);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.ExisteOrdemServico).HasDefaultValue(false);
            builder.Property(x => x.ValorDesconto).HasColumnName("Desconto");
            builder.Property(x => x.ValorAcrescimo).HasColumnName("Acrescimo");
            builder.Property(x => x.Numero);

        }
    }
}
