﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yempo_API.Data;

#nullable disable

namespace Yempo_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230817134436_AddPersonsSeed")]
    partial class AddPersonsSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Yempo_API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 38,
                            Firstname = "John",
                            Lastname = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 24,
                            Firstname = "Jenny",
                            Lastname = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            Firstname = "Mark",
                            Lastname = "Smith"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
