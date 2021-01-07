﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("High")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Low")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("MarketCap")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Open")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("Volume")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cryptos");
                });
#pragma warning restore 612, 618
        }
    }
}
