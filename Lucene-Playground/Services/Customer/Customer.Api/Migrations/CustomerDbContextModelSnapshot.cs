﻿// <auto-generated />
using System;
using Customer.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Customer.Api.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    partial class CustomerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Customer.Api.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime")
                        .HasColumnName("Birthdate");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("LastName");

                    b.Property<string>("PhoneAreaCode")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasColumnName("PhoneAreaCode");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("PhoneNumber");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Customer.Api.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("RegoNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("RegoNumber");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("VIN");

                    b.Property<string>("VehicleMake")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("VehicleMake");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("VehicleModel");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Customer.Api.Entities.Vehicle", b =>
                {
                    b.HasOne("Customer.Api.Entities.Customer", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Customer.Api.Entities.Customer", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
