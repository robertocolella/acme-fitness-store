﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using acme_order.Db;

namespace acmeorder.Migrations.Sqlite
{
    [DbContext(typeof(SqliteOrderContext))]
    [Migration("20220509091741_InitialSqlite")]
    partial class InitialSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("acme_order.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Card")
                        .HasColumnName("card")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cart")
                        .HasColumnName("cart")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date")
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 5, 9, 9, 17, 40, 879, DateTimeKind.Utc).AddTicks(7650));

                    b.Property<string>("Delivery")
                        .HasColumnName("delivery")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Firstname")
                        .HasColumnName("firstname")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Lastname")
                        .HasColumnName("lastname")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Paid")
                        .HasColumnName("paid")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Total")
                        .HasColumnName("total")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("order");
                });
#pragma warning restore 612, 618
        }
    }
}
