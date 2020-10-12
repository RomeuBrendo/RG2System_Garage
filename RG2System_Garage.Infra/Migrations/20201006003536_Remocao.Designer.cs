﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RG2System_Garage.Infra.Repositories;

namespace RG2System_Garage.Infra.Migrations
{
    [DbContext(typeof(RB2System_GarageContext))]
    [Migration("20201006003536_Remocao")]
    partial class Remocao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CPFCNPJ")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<string>("Telefone1")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<string>("Telefone2")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.ClienteVeiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("VeiculoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("ClienteVeiculo");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.EstoqueProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EstoqueAtual")
                        .HasColumnName("EstoqueAtual")
                        .HasColumnType("int");

                    b.Property<float>("PrecoCusto")
                        .HasColumnName("PrecoCusto")
                        .HasColumnType("float");

                    b.Property<float>("PrecoVenda")
                        .HasColumnName("PrecoVenda")
                        .HasColumnType("float");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("EstoqueProdutos");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Ano")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.ClienteVeiculo", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("RG2System_Garage.Domain.Entities.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.EstoqueProduto", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.Produto", null)
                        .WithOne("EstoqueProduto")
                        .HasForeignKey("RG2System_Garage.Domain.Entities.EstoqueProduto", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.Cliente", null)
                        .WithMany("Veiculos")
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
