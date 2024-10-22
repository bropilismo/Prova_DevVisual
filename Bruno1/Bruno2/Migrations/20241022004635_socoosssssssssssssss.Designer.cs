﻿// <auto-generated />
using Bruno1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bruno1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241022004635_socoosssssssssssssss")]
    partial class socoosssssssssssssss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Bruno1.Models.Folha", b =>
                {
                    b.Property<string>("folhaId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ano")
                        .HasColumnType("TEXT");

                    b.Property<string>("funcionarioId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("mes")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("quantidade")
                        .HasColumnType("TEXT");

                    b.Property<double>("valor")
                        .HasColumnType("REAL");

                    b.HasKey("folhaId");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("Bruno1.Models.Funcionario", b =>
                {
                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("cpf");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}