﻿// <auto-generated />
using ImobiliariaWebView.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImobiliariaWebView.Migrations
{
    [DbContext(typeof(ImobiliariaContext))]
    [Migration("20230124182514_MapeandoBancoImobiliaria")]
    partial class MapeandoBancoImobiliaria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ImobiliariaWebView.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("complemento");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cpf_cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("numero");

                    b.Property<string>("TelefoneCelular")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone_celular");

                    b.Property<string>("TelefoneResidencial")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone_residencial");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("uf");

                    b.HasKey("IdCliente");

                    b.ToTable("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}