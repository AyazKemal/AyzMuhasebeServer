﻿// <auto-generated />
using System;
using AyzMuhasebeServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AyzMuhasebeServer.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230430085651_main-role-duzeltme")]
    partial class mainroleduzeltme
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DatabaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRoleCreatedByAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("MainRoles");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRoleAndRoleRelationship", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("MainRoleAndRoleRelationships");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRoleAndUserRelationship", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("MainRoleAndUserRelationships");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.UserAndCompanyRelationship", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CompanyId");

                    b.ToTable("UserAndCompanyRelationships");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRole", b =>
                {
                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRoleAndRoleRelationship", b =>
                {
                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.MainRole", "MainRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId");

                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Identity.AppRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("AppRole");

                    b.Navigation("MainRole");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.MainRoleAndUserRelationship", b =>
                {
                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.MainRole", "MainRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId");

                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Identity.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("AppUser");

                    b.Navigation("Company");

                    b.Navigation("MainRole");
                });

            modelBuilder.Entity("AyzMuhasebeServer.Domain.AppEntities.UserAndCompanyRelationship", b =>
                {
                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Identity.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("AyzMuhasebeServer.Domain.AppEntities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("AppUser");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
