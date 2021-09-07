﻿// <auto-generated />
using System;
using IdentityServer.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServer.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20210907063505_Init user and userClaims table.")]
    partial class InituseranduserClaimstable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            ConcurrencyStamp = "3fffbbf3-7d05-4b27-b419-930cb036e837",
                            IsActive = true,
                            Password = "password",
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            Username = "Frank"
                        },
                        new
                        {
                            Id = new Guid("c6e8040f-b2c0-4986-af6c-d3b650e0927e"),
                            ConcurrencyStamp = "85032bef-d0fa-4b10-bae9-914e47a8a0b0",
                            IsActive = true,
                            Password = "Helios",
                            Subject = "5BE86359-073C-434B-AD2D-A3932222DABE",
                            Username = "Quentin"
                        });
                });

            modelBuilder.Entity("IdentityServer.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09402969-6b79-426f-9ec3-92d7dfd5df2f"),
                            ConcurrencyStamp = "61fdbf3d-acee-4ce9-9154-b136ea184af5",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Frank"
                        },
                        new
                        {
                            Id = new Guid("bc4f03f3-057a-4482-a77a-0fdba8f7239f"),
                            ConcurrencyStamp = "0378facc-1a16-4ae1-8c2c-812eb020ff36",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("9af19235-b344-4f39-b71e-0ecd13658e36"),
                            ConcurrencyStamp = "7161170f-4059-40a5-bf5a-a37437de6143",
                            Type = "email",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FrankUnderwood@someProvider.com"
                        },
                        new
                        {
                            Id = new Guid("9834ee0e-ba76-4e8d-8d19-22bdb94cf480"),
                            ConcurrencyStamp = "aa29e987-ad8d-4cce-9335-21eac80ee3c6",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "En"
                        },
                        new
                        {
                            Id = new Guid("d58f23ca-f25d-4730-9a4b-0de367523fdb"),
                            ConcurrencyStamp = "6c416774-4f1b-40f8-bf3a-b8f5152efb46",
                            Type = "given_name",
                            UserId = new Guid("c6e8040f-b2c0-4986-af6c-d3b650e0927e"),
                            Value = "Quentin"
                        },
                        new
                        {
                            Id = new Guid("62e3e514-810d-4358-95ad-bcd31ab5026c"),
                            ConcurrencyStamp = "290bfe87-5d08-4e87-bcd1-79a49d55b768",
                            Type = "family_name",
                            UserId = new Guid("c6e8040f-b2c0-4986-af6c-d3b650e0927e"),
                            Value = "Couissinier"
                        },
                        new
                        {
                            Id = new Guid("dbad180e-09cd-49a3-be96-a5300ab7a818"),
                            ConcurrencyStamp = "7dc991ae-b070-4039-8033-d21bab6c774e",
                            Type = "email",
                            UserId = new Guid("c6e8040f-b2c0-4986-af6c-d3b650e0927e"),
                            Value = "Quentin.couissinier@someProvider.com"
                        },
                        new
                        {
                            Id = new Guid("33367cc5-aa93-4bc7-9cc2-cec41bd32ea1"),
                            ConcurrencyStamp = "8fafe672-1734-47fc-bbf2-924b532a8b79",
                            Type = "country",
                            UserId = new Guid("c6e8040f-b2c0-4986-af6c-d3b650e0927e"),
                            Value = "Fr"
                        });
                });

            modelBuilder.Entity("IdentityServer.Entities.UserClaim", b =>
                {
                    b.HasOne("IdentityServer.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}