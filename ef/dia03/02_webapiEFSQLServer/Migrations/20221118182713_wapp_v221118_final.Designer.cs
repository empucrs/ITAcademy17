﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_webapiEFSQLServer.Models;

#nullable disable

namespace _02webapiEFSQLServer.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20221118182713_wapp_v221118_final")]
    partial class wappv221118final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Item", b =>
                {
                    b.Property<int>("pedidoid")
                        .HasColumnType("int");

                    b.Property<int>("produtoid")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("pedidoid", "produtoid");

                    b.HasIndex("produtoid");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("clienteid")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataDaAquisicao")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("valorUnitario")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Item", b =>
                {
                    b.HasOne("_02_webapiEFSQLServer.Models.Pedido", "pedido")
                        .WithMany("itens")
                        .HasForeignKey("pedidoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_02_webapiEFSQLServer.Models.Produto", "produto")
                        .WithMany("itens")
                        .HasForeignKey("produtoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pedido");

                    b.Navigation("produto");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Pedido", b =>
                {
                    b.HasOne("_02_webapiEFSQLServer.Models.Cliente", "cliente")
                        .WithMany("pedidos")
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Cliente", b =>
                {
                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Pedido", b =>
                {
                    b.Navigation("itens");
                });

            modelBuilder.Entity("_02_webapiEFSQLServer.Models.Produto", b =>
                {
                    b.Navigation("itens");
                });
#pragma warning restore 612, 618
        }
    }
}