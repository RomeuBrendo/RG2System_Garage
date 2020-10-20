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
    [Migration("20201019235006_ValorPadrao")]
    partial class ValorPadrao
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

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.ConfiguracaoDadosEmpresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("ConfiguracaoDadosEmpresa");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Movimentacao", b =>
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

                    b.Property<Guid>("ProdutoServicoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoServicoId");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Orcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("ExisteOrdemServico")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(1500) CHARACTER SET utf8mb4")
                        .HasMaxLength(1500);

                    b.Property<double>("ValorAcrescimo")
                        .HasColumnName("Acrescimo")
                        .HasColumnType("double");

                    b.Property<double>("ValorDesconto")
                        .HasColumnName("Desconto")
                        .HasColumnType("double");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.OrcamentoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("OrcamentoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("OrcamentoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("OrcamentoItem");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.ProdutoServico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<string>("Observacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(2000) CHARACTER SET utf8mb4")
                        .HasMaxLength(2000)
                        .HasDefaultValue("");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProdutoServico");
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

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.ConfiguracaoDadosEmpresa", b =>
                {
                    b.OwnsOne("RG2System_Garage.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ConfiguracaoDadosEmpresaId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Endereco")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                                .HasMaxLength(50);

                            b1.HasKey("ConfiguracaoDadosEmpresaId");

                            b1.ToTable("ConfiguracaoDadosEmpresa");

                            b1.WithOwner()
                                .HasForeignKey("ConfiguracaoDadosEmpresaId");
                        });

                    b.OwnsOne("RG2System_Garage.Domain.ValueObjects.Nome", "Nome", b1 =>
                        {
                            b1.Property<Guid>("ConfiguracaoDadosEmpresaId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Fantasia")
                                .IsRequired()
                                .HasColumnName("NomeFantasia")
                                .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                                .HasMaxLength(500);

                            b1.Property<string>("RazaoSocial")
                                .IsRequired()
                                .HasColumnName("RazaoSocial")
                                .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                                .HasMaxLength(500);

                            b1.HasKey("ConfiguracaoDadosEmpresaId");

                            b1.ToTable("ConfiguracaoDadosEmpresa");

                            b1.WithOwner()
                                .HasForeignKey("ConfiguracaoDadosEmpresaId");
                        });

                    b.OwnsOne("RG2System_Garage.Domain.ValueObjects.Telefone", "Telefone", b1 =>
                        {
                            b1.Property<Guid>("ConfiguracaoDadosEmpresaId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Celular")
                                .IsRequired()
                                .HasColumnName("Celular")
                                .HasColumnType("varchar(16) CHARACTER SET utf8mb4")
                                .HasMaxLength(16);

                            b1.Property<string>("Fixo")
                                .IsRequired()
                                .HasColumnName("Fixo")
                                .HasColumnType("varchar(16) CHARACTER SET utf8mb4")
                                .HasMaxLength(16);

                            b1.HasKey("ConfiguracaoDadosEmpresaId");

                            b1.ToTable("ConfiguracaoDadosEmpresa");

                            b1.WithOwner()
                                .HasForeignKey("ConfiguracaoDadosEmpresaId");
                        });
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Movimentacao", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.ProdutoServico", null)
                        .WithMany("FichaMovimentacao")
                        .HasForeignKey("ProdutoServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.Orcamento", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("RG2System_Garage.Domain.Entities.OrcamentoItem", b =>
                {
                    b.HasOne("RG2System_Garage.Domain.Entities.Orcamento", "Orcamento")
                        .WithMany("Itens")
                        .HasForeignKey("OrcamentoId");

                    b.HasOne("RG2System_Garage.Domain.Entities.ProdutoServico", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
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
