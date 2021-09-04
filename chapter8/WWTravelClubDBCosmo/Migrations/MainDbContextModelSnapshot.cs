﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WWTravelClubDB;

namespace WWTravelClubDB.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WWTravelClubDB.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Country");

                    b.HasIndex("Name");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("WWTravelClubDB.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndValidityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("StartValidityDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("Name");

                    b.HasIndex("StartValidityDate", "EndValidityDate");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("WWTravelClubDB.Models.Package", b =>
                {
                    b.HasOne("WWTravelClubDB.Models.Destination", "MyDestination")
                        .WithMany("Packages")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyDestination");
                });

            modelBuilder.Entity("WWTravelClubDB.Models.Destination", b =>
                {
                    b.Navigation("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}
