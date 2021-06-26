﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeApp.Data;

namespace RecipeApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RecipeApp.Models.Favorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RecipeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("RecipeApp.Models.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ing001")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing002")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing003")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing004")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing005")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing006")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing007")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing008")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing009")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing010")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing011")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing012")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing013")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing014")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing015")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing016")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing017")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing018")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing019")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing020")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing021")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing022")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing023")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing024")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing025")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing026")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing027")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing028")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing029")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing030")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing031")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing032")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing033")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing034")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing035")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing036")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing037")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing038")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing039")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing040")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing041")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing042")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing043")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing044")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing045")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing046")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing047")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing048")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing049")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing050")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing051")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing052")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing053")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing054")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing055")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing056")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing057")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing058")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing059")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing060")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing061")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing062")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing063")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing064")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing065")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing066")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing067")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing068")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing069")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing070")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing071")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing072")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing073")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing074")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing075")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing076")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing077")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing078")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing079")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing080")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing081")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing082")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing083")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing084")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing085")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing086")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing087")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing088")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing089")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing090")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing091")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing092")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing093")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing094")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing095")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing096")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing097")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing098")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing099")
                        .HasColumnType("bit");

                    b.Property<bool>("Ing100")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
