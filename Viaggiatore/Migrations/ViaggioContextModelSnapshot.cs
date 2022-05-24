﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Viaggiatore.Data;

#nullable disable

namespace Viaggiatore.Migrations
{
    [DbContext(typeof(ViaggioContext))]
    partial class ViaggioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Viaggiatore.Models.Pacchetto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.Property<string>("descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("immagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("richiestaUtenteId")
                        .HasColumnType("int");

                    b.Property<string>("titolo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("richiestaUtenteId");

                    b.ToTable("pacchetti");
                });

            modelBuilder.Entity("Viaggiatore.Models.RichiestaUtente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cognome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("messaggio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("richiesteUtenti");
                });

            modelBuilder.Entity("Viaggiatore.Models.Pacchetto", b =>
                {
                    b.HasOne("Viaggiatore.Models.RichiestaUtente", "richiestaUtente")
                        .WithMany("pacchetti")
                        .HasForeignKey("richiestaUtenteId");

                    b.Navigation("richiestaUtente");
                });

            modelBuilder.Entity("Viaggiatore.Models.RichiestaUtente", b =>
                {
                    b.Navigation("pacchetti");
                });
#pragma warning restore 612, 618
        }
    }
}
