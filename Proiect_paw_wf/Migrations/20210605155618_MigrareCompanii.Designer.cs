﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_paw_wf.Modele;

namespace Proiect_paw_wf.Migrations
{
    [DbContext(typeof(ALApplicationContext))]
    [Migration("20210605155618_MigrareCompanii")]
    partial class MigrareCompanii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15");

            modelBuilder.Entity("Proiect_paw_wf.Modele.Companie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nume")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipBilete")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companii");
                });

            modelBuilder.Entity("Proiect_paw_wf.Modele.Ruta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cod")
                        .HasColumnType("TEXT");

                    b.Property<int>("CompanieId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPlecare")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destinatie")
                        .HasColumnType("TEXT");

                    b.Property<int>("NrKm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Plecare")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanieId");

                    b.ToTable("Rute");
                });

            modelBuilder.Entity("Proiect_paw_wf.Modele.Ruta", b =>
                {
                    b.HasOne("Proiect_paw_wf.Modele.Companie", null)
                        .WithMany("Rute")
                        .HasForeignKey("CompanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}