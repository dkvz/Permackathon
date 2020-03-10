﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Permackathon.Financial.DAL;

namespace Permackathon.Financial.DAL.Migrations
{
    [DbContext(typeof(FinancialContext))]
    [Migration("20200310173510_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Permackathon.Financial.DAL.Entities.EffectiveEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CashFlow")
                        .HasColumnType("REAL");

                    b.Property<double>("Eat")
                        .HasColumnType("REAL");

                    b.Property<double>("Grow")
                        .HasColumnType("REAL");

                    b.Property<double>("Learn")
                        .HasColumnType("REAL");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Effectives");
                });

            modelBuilder.Entity("Permackathon.Financial.DAL.Entities.PredictionEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CashFlow")
                        .HasColumnType("REAL");

                    b.Property<double>("Eat")
                        .HasColumnType("REAL");

                    b.Property<double>("Grow")
                        .HasColumnType("REAL");

                    b.Property<double>("Learn")
                        .HasColumnType("REAL");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Predictions");
                });
#pragma warning restore 612, 618
        }
    }
}