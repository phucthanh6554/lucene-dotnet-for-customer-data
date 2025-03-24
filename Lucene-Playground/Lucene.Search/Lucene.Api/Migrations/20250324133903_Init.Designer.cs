﻿// <auto-generated />
using System;
using Lucene.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lucene.Api.Migrations
{
    [DbContext(typeof(LuceneDbContext))]
    [Migration("20250324133903_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lucene.Api.Entities.SyncDataControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("IndexName");

                    b.Property<DateTime>("LastSync")
                        .HasColumnType("datetime")
                        .HasColumnName("LastSync");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("IndexPath");

                    b.HasKey("Id");

                    b.ToTable("SyncDataControls");
                });
#pragma warning restore 612, 618
        }
    }
}
