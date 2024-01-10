﻿// <auto-generated />
using System;
using Authorization.Microservice.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Authorization.Microservice.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231226120236_defaultUser")]
    partial class defaultUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Authorization.Microservice.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb587003-9bcb-4d9d-af12-f5944a4d7a82"),
                            Email = "a@mail.ru",
                            ImagePath = "/content/avatars/35a44d12-42f9-4254-a7d3-2e3bf26c934c.jpg",
                            PasswordHash = "473287f8298dba7163a897908958f7c0eae733e25d2e027992ea2edc9bed2fa8",
                            Role = "user",
                            Username = "Andrey Glazev"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}