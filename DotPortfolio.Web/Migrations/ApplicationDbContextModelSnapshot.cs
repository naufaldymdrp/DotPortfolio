﻿// <auto-generated />
using System;
using DotPortfolio.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotPortfolio.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("DotPortfolio.Web.Data.EmployeeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EmployDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3935),
                            EmployDate = new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3923),
                            Name = "Nomad"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3937),
                            EmployDate = new DateTime(2022, 11, 24, 11, 5, 39, 416, DateTimeKind.Local).AddTicks(3936),
                            Name = "Nopal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
