﻿// <auto-generated />
using System;
using EI20_21_ESII_PI_GGLP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EI20_21_ESII_PI_GGLP.Migrations
{
    [DbContext(typeof(GGLPDbContext))]
    partial class GGLPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Agendamento", b =>
                {
                    b.Property<int>("AgendamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AData")
                        .HasColumnType("datetime2");

                    b.Property<string>("AHoraFim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AHoraInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ANumPessoas")
                        .HasColumnType("int");

                    b.Property<int>("PessoaID")
                        .HasColumnType("int");

                    b.Property<int>("PontoDeInteresseID")
                        .HasColumnType("int");

                    b.HasKey("AgendamentoID");

                    b.HasIndex("PessoaID");

                    b.HasIndex("PontoDeInteresseID");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

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
                    b.Property<int>("DiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiaID");

                    b.ToTable("Dia");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Estado", b =>
                {
                    b.Property<int>("EstadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoID");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Horario", b =>
                {
                    b.Property<int>("HorarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaID")
                        .HasColumnType("int");

                    b.Property<int>("HFim")
                        .HasColumnType("int");

                    b.Property<int>("HInicio")
                        .HasColumnType("int");

                    b.Property<int>("PontoDeInteresseID")
                        .HasColumnType("int");

                    b.HasKey("HorarioID");

                    b.HasIndex("DiaID");

                    b.HasIndex("PontoDeInteresseID");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CTDataNas")
                        .HasColumnType("datetime2");

                    b.Property<string>("CTEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTLocalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CTNIF")
                        .HasColumnType("int");

                    b.Property<string>("CTPais")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

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

                    b.HasKey("PessoaID");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", b =>
                {
                    b.Property<int>("PontoDeInteresseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<int>("EstadoID")
                        .HasColumnType("int");

                    b.Property<string>("PComments")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("PContacto")
                        .HasColumnType("int");

                    b.Property<string>("PCoordenadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("PontoDeInteresseID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("EstadoID");

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

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.RegrasCOVID", b =>
                {
                    b.Property<int>("RegrasCOVID_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RDataVigor")
                        .HasColumnType("datetime2");

                    b.Property<string>("RDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("RegrasCOVID_ID");

                    b.ToTable("RegrasCOVID");
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Agendamento", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Pessoa", "Pessoa")
                        .WithMany("Agendamentos")
                        .HasForeignKey("PessoaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", "PontoDeInteresse")
                        .WithMany("Agendamentos")
                        .HasForeignKey("PontoDeInteresseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.Horario", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Dia", "Dia")
                        .WithMany("Horarios")
                        .HasForeignKey("DiaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", "PontoDeInteresse")
                        .WithMany("Horario")
                        .HasForeignKey("PontoDeInteresseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EI20_21_ESII_PI_GGLP.Models.PontoDeInteresse", b =>
                {
                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Categoria", "Categoria")
                        .WithMany("PontoDeInteresses")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EI20_21_ESII_PI_GGLP.Models.Estado", "Estado")
                        .WithMany("PontoDeInteresses")
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
