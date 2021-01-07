﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210107035749_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("API.Entities.Crypto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Close")
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("High")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Low")
                        .HasColumnType("TEXT");

                    b.Property<long>("MarketCap")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Open")
                        .HasColumnType("TEXT");

                    b.Property<long>("Volume")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cryptos");
                });
#pragma warning restore 612, 618
        }
    }
}