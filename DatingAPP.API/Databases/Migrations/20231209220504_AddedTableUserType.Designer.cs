﻿// <auto-generated />
using System;
using DatingApp.API.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatingApp.API.Databases.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231209220504_AddedTableUserType")]
    partial class AddedTableUserType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DatingApp.API.Databases.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KnownAs")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DatingApp.API.Databases.Entities.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("DatingApp.API.Databases.Entities.User", b =>
                {
                    b.HasOne("DatingApp.API.Databases.Entities.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("DatingApp.API.Databases.Entities.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
