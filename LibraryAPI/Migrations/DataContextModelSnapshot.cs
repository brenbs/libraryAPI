﻿// <auto-generated />
using System;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PublisherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Realese")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autor = "Jane Austen",
                            Name = "Orgulho e Preconceito",
                            PublisherId = 1,
                            Realese = 1813,
                            Stock = 25
                        },
                        new
                        {
                            Id = 2,
                            Autor = "Tatsuki Fujimoto",
                            Name = "Chainsaw Man Vol.1",
                            PublisherId = 5,
                            Realese = 2010,
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            Autor = "Jane Austen",
                            Name = "Razão e Sensibilidade",
                            PublisherId = 1,
                            Realese = 1811,
                            Stock = 30
                        },
                        new
                        {
                            Id = 4,
                            Autor = "Antoine de Saint-Exupéry",
                            Name = "O Pequeno Príncipe",
                            PublisherId = 4,
                            Realese = 1943,
                            Stock = 35
                        },
                        new
                        {
                            Id = 5,
                            Autor = "Neil Gaiman",
                            Name = "Coraline",
                            PublisherId = 4,
                            Realese = 2002,
                            Stock = 18
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "São Paulo",
                            Name = "Pé da Letra"
                        },
                        new
                        {
                            Id = 2,
                            City = "Fortaleza",
                            Name = "JBC"
                        },
                        new
                        {
                            Id = 3,
                            City = "Vitória",
                            Name = "MangaPop"
                        },
                        new
                        {
                            Id = 4,
                            City = "São Paulo",
                            Name = "Intrínseca"
                        },
                        new
                        {
                            Id = 5,
                            City = "Rio de Janeiro",
                            Name = "Panini"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Devolution")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Forecast")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("LibraryAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Álvaro Weyne rua Manoel Pereira n°489",
                            City = "Fortaleza,CE",
                            Email = "brenbs@gmail.com",
                            Name = "Brenda"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Moranguinho, rua Maria n°321",
                            City = "Horizonte,CE",
                            Email = "manhu@gmail.com",
                            Name = "Emauela"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Damas, rua Professor Costa Mendes n°933",
                            City = "Fortaleza,CE",
                            Email = "lolo@gmail.com",
                            Name = "Heloísa"
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Aldeota, Av.Dom Luís n°5001",
                            City = "Fortaleza,CE",
                            Email = "tonys@gmail.com",
                            Name = "Antonio"
                        },
                        new
                        {
                            Id = 5,
                            Adress = "Álvaro Weyne,Coelho Neto n°400",
                            City = "Fortaleza,CE",
                            Email = "manel@gmail.com",
                            Name = "Emanuel"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.HasOne("LibraryAPI.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryAPI.Models.Rental", b =>
                {
                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
