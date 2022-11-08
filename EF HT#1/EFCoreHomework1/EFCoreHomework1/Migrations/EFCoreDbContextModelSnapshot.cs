﻿// <auto-generated />
using EFCoreHomework1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreHomework1.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    partial class EFCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreHomework1.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Sum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Sum = 100
                        },
                        new
                        {
                            Id = 2,
                            Sum = 200
                        },
                        new
                        {
                            Id = 3,
                            Sum = 300
                        },
                        new
                        {
                            Id = 4,
                            Sum = 400
                        },
                        new
                        {
                            Id = 5,
                            Sum = 500
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
