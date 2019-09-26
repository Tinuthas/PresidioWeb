﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PresidioWebAsp.Context;

namespace PresidioWebAsp.Migrations
{
    [DbContext(typeof(PresidioContext))]
    partial class PresidioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PresidioWebAsp.Models.Cela", b =>
                {
                    b.Property<int>("CelaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("CelaId");

                    b.ToTable("Cela");
                });

            modelBuilder.Entity("PresidioWebAsp.Models.Presidiario", b =>
                {
                    b.Property<int>("PresidiarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CelaId");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<int>("Escolaridade");

                    b.Property<string>("Nome");

                    b.HasKey("PresidiarioId");

                    b.HasIndex("CelaId");

                    b.ToTable("Presidiarios");
                });

            modelBuilder.Entity("PresidioWebAsp.Models.Presidiario", b =>
                {
                    b.HasOne("PresidioWebAsp.Models.Cela", "Cela")
                        .WithMany("Presidiarios")
                        .HasForeignKey("CelaId");
                });
#pragma warning restore 612, 618
        }
    }
}