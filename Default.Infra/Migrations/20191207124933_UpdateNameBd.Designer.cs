﻿// <auto-generated />
using System;
using Default.Infra.Persistence.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Default.Infra.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20191207124933_UpdateNameBd")]
    partial class UpdateNameBd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Default.Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Default.Domain.Entity.User", b =>
                {
                    b.OwnsOne("Default.Domain.ObjectValues.Email", "Email", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Endereco")
                                .IsRequired()
                                .HasColumnName("EnderecoEmail")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("Default.Domain.ObjectValues.Nome", "Nome", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasColumnName("PrimeiroNome")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("UltimoNome")
                                .IsRequired()
                                .HasColumnName("Ultimonome")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
