﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockAndPrice.Data;

#nullable disable

namespace StockAndPrice.Data.Migrations
{
    [DbContext(typeof(StockAndPriceContext))]
    [Migration("20230330175135_changes-on-system")]
    partial class changesonsystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("StockAndPrice.Shared.PriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PriceListName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PriceList");
                });

            modelBuilder.Entity("StockAndPrice.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StockAndPrice.Shared.ProductPrice", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceListId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "PriceListId");

                    b.HasIndex("PriceListId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductPrices");
                });

            modelBuilder.Entity("StockAndPrice.Shared.ProductStock", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Avaliable")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CriticalStock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "WarehouseId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("ProductStocks");
                });

            modelBuilder.Entity("StockAndPrice.Shared.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WarehouseAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("StockAndPrice.Shared.ProductPrice", b =>
                {
                    b.HasOne("StockAndPrice.Shared.PriceList", "PriceList")
                        .WithMany("ProductPrices")
                        .HasForeignKey("PriceListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockAndPrice.Shared.Product", "Product")
                        .WithOne("Price")
                        .HasForeignKey("StockAndPrice.Shared.ProductPrice", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PriceList");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockAndPrice.Shared.ProductStock", b =>
                {
                    b.HasOne("StockAndPrice.Shared.Product", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockAndPrice.Shared.Warehouse", "Warehouse")
                        .WithMany("Stocks")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("StockAndPrice.Shared.PriceList", b =>
                {
                    b.Navigation("ProductPrices");
                });

            modelBuilder.Entity("StockAndPrice.Shared.Product", b =>
                {
                    b.Navigation("Price")
                        .IsRequired();

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("StockAndPrice.Shared.Warehouse", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
