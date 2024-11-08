﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Praktos.DatabaseContext;

#nullable disable

namespace LibraryPlusApiDb.Migrations
{
    [DbContext(typeof(TestApiDB))]
    [Migration("20241108114459_Migrations")]
    partial class Migrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Praktos.Model.Autors", b =>
                {
                    b.Property<int>("Id_Autors")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Autors"));

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Autors");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("Praktos.Model.BookRentalHistory", b =>
                {
                    b.Property<int>("Id_BookRentalHistory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_BookRentalHistory"));

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Books")
                        .HasColumnType("int");

                    b.Property<int>("Id_Readers")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_BookRentalHistory");

                    b.HasIndex("Id_Books");

                    b.HasIndex("Id_Readers");

                    b.ToTable("BookRentalsHistory");
                });

            modelBuilder.Entity("Praktos.Model.Books", b =>
                {
                    b.Property<int>("Id_Books")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Books"));

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Autors")
                        .HasColumnType("int");

                    b.Property<int>("Id_Genre")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfPublication")
                        .HasColumnType("int");

                    b.HasKey("Id_Books");

                    b.HasIndex("Id_Autors");

                    b.HasIndex("Id_Genre");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Praktos.Model.Genres", b =>
                {
                    b.Property<int>("Id_Genres")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Genres"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Genres");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Praktos.Model.Readers", b =>
                {
                    b.Property<int>("Id_Readers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Readers"));

                    b.Property<int>("ContactDetails")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Readers");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Praktos.Model.BookRentalHistory", b =>
                {
                    b.HasOne("Praktos.Model.Books", "Books")
                        .WithMany()
                        .HasForeignKey("Id_Books")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Praktos.Model.Readers", "Readers")
                        .WithMany()
                        .HasForeignKey("Id_Readers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Readers");
                });

            modelBuilder.Entity("Praktos.Model.Books", b =>
                {
                    b.HasOne("Praktos.Model.Autors", "Autors")
                        .WithMany()
                        .HasForeignKey("Id_Autors")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Praktos.Model.Genres", "Genres")
                        .WithMany()
                        .HasForeignKey("Id_Genre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autors");

                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
