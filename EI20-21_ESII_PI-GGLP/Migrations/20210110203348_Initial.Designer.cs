﻿// <auto-generated />
using System;
using EI20_21_ESII_PI_GGLP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EI20_21_ESII_PI_GGLP.Migrations
{
    [DbContext(typeof(GGLPDbContext))]
    [Migration("20210110203348_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Agendamento", b =>
                {
                    b.Property<int>("Agendamento_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AHora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ANumPessoas")
                        .HasColumnType("int");

                    b.Property<int>("Pessoa_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Pessoa_ID1")
                        .HasColumnType("int");

                    b.Property<int?>("PontoDeInteresse_ID")
                        .HasColumnType("int");

                    b.Property<int>("PontoDeIntersse_ID")
                        .HasColumnType("int");

                    b.HasKey("Agendamento_ID");

                    b.HasIndex("Pessoa_ID1");

                    b.HasIndex("PontoDeInteresse_ID");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Categoria", b =>
                {
                    b.Property<int>("Categoria_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categoria_ID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Contacts", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Dia", b =>
                {
                    b.Property<int>("Dia_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dia_ID");

                    b.ToTable("Dia");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Estado", b =>
                {
                    b.Property<int>("Estado_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Estado_ID");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Horario", b =>
                {
                    b.Property<int>("Horario_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dia_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Dia_ID1")
                        .HasColumnType("int");

                    b.Property<string>("HComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HFim")
                        .HasColumnType("int");

                    b.Property<int>("HInicio")
                        .HasColumnType("int");

                    b.Property<int?>("PontoDeInteresse_ID")
                        .HasColumnType("int");

                    b.Property<int>("PontosDeInteresse_ID")
                        .HasColumnType("int");

                    b.HasKey("Horario_ID");

                    b.HasIndex("Dia_ID1");

                    b.HasIndex("PontoDeInteresse_ID");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Pessoa", b =>
                {
                    b.Property<int>("Pessoa_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PComments")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("PContato")
                        .HasColumnType("int");

                    b.Property<string>("PEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Pessoa_ID");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", b =>
                {
                    b.Property<int>("PontoDeInteresse_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Categoria_ID1")
                        .HasColumnType("int");

                    b.Property<int>("Estado_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Estado_ID1")
                        .HasColumnType("int");

                    b.Property<int>("Gestor_ID")
                        .HasColumnType("int");

                    b.Property<string>("PComments")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("PContacto")
                        .HasColumnType("int");

                    b.Property<string>("PCoordenadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCovid")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<DateTime>("PDataEstado")
                        .HasColumnType("datetime2");

                    b.Property<string>("PDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("PEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<byte[]>("PImagem")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PMaxPessoas")
                        .HasColumnType("int");

                    b.Property<string>("PNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PNumPessoas")
                        .HasColumnType("int");

                    b.Property<int?>("Pessoa_ID")
                        .HasColumnType("int");

                    b.HasKey("PontoDeInteresse_ID");

                    b.HasIndex("Categoria_ID1");

                    b.HasIndex("Estado_ID1");

                    b.HasIndex("Pessoa_ID");

                    b.ToTable("PontoDeInteresse");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Pontos", b =>
                {
                    b.Property<int>("PontoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PContacto")
                        .HasColumnType("int");

                    b.Property<string>("PCoordenadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCovid")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("PDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("PEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PHorarioFeriado")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PHorarioFimSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PHorarioSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PPersonsNum")
                        .HasColumnType("int");

                    b.Property<string>("PPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PTotalPersonsNum")
                        .HasColumnType("int");

                    b.HasKey("PontoId");

                    b.ToTable("Pontos");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Agendamento", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Pessoa", "Pessoa")
                        .WithMany("Agendamento")
                        .HasForeignKey("Pessoa_ID1");

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", "PontoDeInteresse")
                        .WithMany("Agendamento")
                        .HasForeignKey("PontoDeInteresse_ID");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Horario", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Dia", "Dia")
                        .WithMany("Horario")
                        .HasForeignKey("Dia_ID1");

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", "PontoDeInteresse")
                        .WithMany("Horario")
                        .HasForeignKey("PontoDeInteresse_ID");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Categoria", "Categoria")
                        .WithMany("PontoDeInteresse")
                        .HasForeignKey("Categoria_ID1");

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Estado", "Estado")
                        .WithMany("PontoDeInteresse")
                        .HasForeignKey("Estado_ID1");

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Pessoa", "Pessoa")
                        .WithMany("PontoDeInteresse")
                        .HasForeignKey("Pessoa_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
