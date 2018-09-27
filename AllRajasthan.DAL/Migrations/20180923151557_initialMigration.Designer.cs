﻿// <auto-generated />
using System;
using AllRajasthan.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllRajasthan.DAL.Migrations
{
    [DbContext(typeof(AllRajasthanDbContext))]
    [Migration("20180923151557_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllRajasthan.DAL.EntityModel.Itinerary", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Day");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<Guid>("PackageID");

                    b.HasKey("ID");

                    b.HasIndex("PackageID");

                    b.ToTable("Itineraries");
                });

            modelBuilder.Entity("AllRajasthan.DAL.EntityModel.Package", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CancellationPolicy")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Exclusions")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Images")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("PackageName");

                    b.Property<int>("TotalDays");

                    b.HasKey("ID");

                    b.HasIndex("PackageName")
                        .IsUnique()
                        .HasFilter("[PackageName] IS NOT NULL");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("AllRajasthan.DAL.EntityModel.PackageType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("Inclusions")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<Guid>("PackageID");

                    b.Property<string>("PackageTypeName")
                        .IsRequired();

                    b.Property<int>("Sort");

                    b.HasKey("ID");

                    b.HasIndex("PackageID");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("AllRajasthan.DAL.EntityModel.Itinerary", b =>
                {
                    b.HasOne("AllRajasthan.DAL.EntityModel.Package", "Package")
                        .WithMany("Itineraries")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllRajasthan.DAL.EntityModel.PackageType", b =>
                {
                    b.HasOne("AllRajasthan.DAL.EntityModel.Package", "Package")
                        .WithMany("PackageTypes")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}