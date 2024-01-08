﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTB.Eshop.Infrastructure.Database;

#nullable disable

namespace UTB.Eshop.Infrastructure.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    partial class EshopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UTB.Eshop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageSource")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "",
                            ImageSource = "/img/produkty-02.jpg",
                            Name = "Chleba",
                            Price = 20.0
                        },
                        new
                        {
                            ID = 2,
                            Description = "",
                            ImageSource = "/img/produkty-01.jpg",
                            Name = "Rohlík",
                            Price = 5.0
                        },
                        new
                        {
                            ID = 3,
                            Description = "",
                            ImageSource = "/img/produkty-08.jpg",
                            Name = "Věneček",
                            Price = 40.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
