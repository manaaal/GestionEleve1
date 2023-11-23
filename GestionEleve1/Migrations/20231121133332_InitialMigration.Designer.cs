﻿// <auto-generated />
using System;
using GestionEleve1.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionEleve1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231121133332_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionEleve1.Models.Eleve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<int>("EtablissementId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EtablissementId");

                    b.ToTable("Eleve");
                });

            modelBuilder.Entity("GestionEleve1.Models.Etablissement", b =>
                {
                    b.Property<int>("EtablissementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EtablissementId"));

                    b.Property<string>("EtablissementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EtablissementId");

                    b.ToTable("Etablissement");
                });

            modelBuilder.Entity("GestionEleve1.Models.Eleve", b =>
                {
                    b.HasOne("GestionEleve1.Models.Etablissement", "Etablissement")
                        .WithMany()
                        .HasForeignKey("EtablissementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etablissement");
                });
#pragma warning restore 612, 618
        }
    }
}
