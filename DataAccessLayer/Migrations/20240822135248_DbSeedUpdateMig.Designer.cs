﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240822135248_DbSeedUpdateMig")]
    partial class DbSeedUpdateMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Entities.CustomRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.CustomUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BirthDate = new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mehmet",
                            ImgUrl = "/images/studentImages/e1.png",
                            LastName = "Ekinci",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 2,
                            BirthDate = new DateTime(2001, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ali",
                            ImgUrl = "/images/studentImages/e2.png",
                            LastName = "Yılmaz",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 3,
                            BirthDate = new DateTime(2002, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ahmet",
                            ImgUrl = "/images/studentImages/e3.png",
                            LastName = "Çelik",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 4,
                            BirthDate = new DateTime(2003, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mehmet",
                            ImgUrl = "/images/studentImages/e4.png",
                            LastName = "Demir",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 5,
                            BirthDate = new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Zeynep",
                            ImgUrl = "/images/studentImages/k1.png",
                            LastName = "Kara",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 6,
                            BirthDate = new DateTime(2001, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Elif",
                            ImgUrl = "/images/studentImages/k2.png",
                            LastName = "Yurt",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 7,
                            BirthDate = new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Fatma",
                            ImgUrl = "/images/studentImages/k3.png",
                            LastName = "Öztürk",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 8,
                            BirthDate = new DateTime(2002, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emine",
                            ImgUrl = "/images/studentImages/k4.png",
                            LastName = "Aydın",
                            isDeleted = true
                        },
                        new
                        {
                            StudentId = 9,
                            BirthDate = new DateTime(2001, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ayşe",
                            ImgUrl = "/images/studentImages/k5.png",
                            LastName = "Güneş",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 10,
                            BirthDate = new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Burak",
                            ImgUrl = "/images/studentImages/e5.png",
                            LastName = "Koç",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 11,
                            BirthDate = new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emre",
                            ImgUrl = "/images/studentImages/e6.png",
                            LastName = "Arslan",
                            isDeleted = true
                        },
                        new
                        {
                            StudentId = 12,
                            BirthDate = new DateTime(2002, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Oğuz",
                            ImgUrl = "/images/studentImages/e7.png",
                            LastName = "Turan",
                            isDeleted = false
                        },
                        new
                        {
                            StudentId = 13,
                            BirthDate = new DateTime(2001, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Cem",
                            ImgUrl = "/images/studentImages/e8.png",
                            LastName = "Sönmez",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Entities.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Entities.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EntityLayer.Entities.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EntityLayer.Entities.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EntityLayer.Entities.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
