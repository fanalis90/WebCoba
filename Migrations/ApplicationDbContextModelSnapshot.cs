﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCoba.Data;

#nullable disable

namespace WebCoba.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebCoba.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDatetime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDatetime = new DateTime(2023, 9, 24, 15, 26, 14, 32, DateTimeKind.Local).AddTicks(3365),
                            DisplayOrder = 1,
                            Name = "action"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDatetime = new DateTime(2023, 9, 24, 15, 26, 14, 32, DateTimeKind.Local).AddTicks(3384),
                            DisplayOrder = 2,
                            Name = "sci-fi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDatetime = new DateTime(2023, 9, 24, 15, 26, 14, 32, DateTimeKind.Local).AddTicks(3389),
                            DisplayOrder = 3,
                            Name = "history"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDatetime = new DateTime(2023, 9, 24, 15, 26, 14, 32, DateTimeKind.Local).AddTicks(3392),
                            DisplayOrder = 4,
                            Name = "batman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
