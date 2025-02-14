﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProcessosApp.Contexts;

#nullable disable

namespace ProcessosApp.Migrations
{
    [DbContext(typeof(ProcessosContext))]
    [Migration("20241212030902_CreateProcessosTable")]
    partial class CreateProcessosTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ProcessosApp.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataVisualizacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeProcesso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Npu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Processos");
                });
#pragma warning restore 612, 618
        }
    }
}
