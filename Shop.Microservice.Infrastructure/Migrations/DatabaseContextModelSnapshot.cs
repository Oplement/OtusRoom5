﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Shop.Microservice.Infrastructure;

#nullable disable

namespace Shop.Microservice.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Shop.Microservice.Domain.Common.Balance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<double>("AmountForSend")
                        .HasColumnType("double precision");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Balances");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c26e3c4b-a5ae-4271-968c-a1a57281b4c8"),
                            Amount = 10.0,
                            AmountForSend = 100.0,
                            UserId = new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e")
                        },
                        new
                        {
                            Id = new Guid("3cb5940e-87f0-4b75-a820-08f17cffada1"),
                            Amount = 20.0,
                            AmountForSend = 200.0,
                            UserId = new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a19d3e")
                        });
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Common.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8948b2a3-a264-4cb7-8345-646e5e33ca3f"),
                            Count = 2,
                            Description = "Размеры S,M,L",
                            Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg",
                            Price = 5999,
                            Title = "Худи"
                        },
                        new
                        {
                            Id = new Guid("5405b1c7-b492-4a80-8421-50ac44dea656"),
                            Count = 5,
                            Description = "10000мАч",
                            Image = "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg",
                            Price = 2399,
                            Title = "ПоверБанк"
                        },
                        new
                        {
                            Id = new Guid("d35d0fc0-f16f-42c2-a34a-3b6a1aec2b1e"),
                            Count = 2,
                            Description = "Размеры S,M,L",
                            Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg",
                            Price = 5999,
                            Title = "Худи"
                        },
                        new
                        {
                            Id = new Guid("970c38cd-d58b-45f8-9453-f0496b168bb8"),
                            Count = 5,
                            Description = "10000мАч",
                            Image = "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg",
                            Price = 2399,
                            Title = "ПоверБанк"
                        },
                        new
                        {
                            Id = new Guid("f471ef19-1e1e-414a-9494-dbb80c42ed40"),
                            Count = 2,
                            Description = "Размеры S,M,L",
                            Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg",
                            Price = 5999,
                            Title = "Худи"
                        },
                        new
                        {
                            Id = new Guid("d437a0dd-699f-4443-8860-33580ffcdbe4"),
                            Count = 5,
                            Description = "10000мАч",
                            Image = "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg",
                            Price = 2399,
                            Title = "ПоверБанк"
                        },
                        new
                        {
                            Id = new Guid("95d9c951-486d-4dbd-b318-473e86e18795"),
                            Count = 2,
                            Description = "Размеры S,M,L",
                            Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg",
                            Price = 5999,
                            Title = "Худи"
                        },
                        new
                        {
                            Id = new Guid("2067e886-ec57-4592-93e6-03e4ef59fe35"),
                            Count = 5,
                            Description = "10000мАч",
                            Image = "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg",
                            Price = 2399,
                            Title = "ПоверБанк"
                        },
                        new
                        {
                            Id = new Guid("9a6204f3-498e-418f-9868-99281c9899f8"),
                            Count = 2,
                            Description = "Размеры S,M,L",
                            Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg",
                            Price = 5999,
                            Title = "Худи"
                        },
                        new
                        {
                            Id = new Guid("6e3e1faf-4f7f-45b4-b170-2efdb25883ca"),
                            Count = 5,
                            Description = "10000мАч",
                            Image = "https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg",
                            Price = 2399,
                            Title = "ПоверБанк"
                        });
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Common.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ReceiverID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SenderID")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("deb9e453-48a8-4e45-b2df-c75dc062bc18"),
                            CreateAt = new DateTime(2024, 1, 29, 19, 55, 9, 690, DateTimeKind.Utc).AddTicks(7121),
                            OrderStatus = 0,
                            UserId = new Guid("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e")
                        });
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Entities.OrderProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d30ebcf-3584-4e41-97f6-2c96a8e7a21c"),
                            Count = 1,
                            OrderId = new Guid("deb9e453-48a8-4e45-b2df-c75dc062bc18"),
                            ProductId = new Guid("8948b2a3-a264-4cb7-8345-646e5e33ca3f")
                        });
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Entities.OrderProduct", b =>
                {
                    b.HasOne("Shop.Microservice.Domain.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Microservice.Domain.Common.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Microservice.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
