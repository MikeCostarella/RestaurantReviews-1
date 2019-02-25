﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RestaurantReviews.Data;

namespace RestaurantReviews.Data.Migrations
{
    [DbContext(typeof(RestaurantReviewsContext))]
    partial class RestaurantReviewsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RestaurantReviews.Data.Entities.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RestaurantId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("Country")
                        .HasMaxLength(50);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("EmailAddress")
                        .HasMaxLength(60);

                    b.Property<bool>("IsConfirmed")
                        .HasColumnName("IsConfirmed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasMaxLength(30);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnName("PostalCode")
                        .HasMaxLength(11);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("State")
                        .HasMaxLength(20);

                    b.Property<string>("WebsiteUrl")
                        .HasColumnName("WebsiteUrl")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Restaurants","DomainData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ee5ad3e-1e1e-467a-9ecb-971a1e3aec7f"),
                            Address = "Park Drive",
                            City = "Niles",
                            Country = "USA",
                            EmailAddress = "",
                            IsConfirmed = true,
                            Name = "Bombay Curry and Grill",
                            Phone = "(330) 544-4444",
                            PostalCode = "44446",
                            State = "OH",
                            WebsiteUrl = "https://www.doordash.com/store/bombay-curry-grill-niles-403108/"
                        },
                        new
                        {
                            Id = new Guid("e5e972bb-7968-466e-b493-dd05948a7fea"),
                            Address = "5555 Youngstown Warren Rd #175",
                            City = "Niles",
                            Country = "USA",
                            EmailAddress = "",
                            IsConfirmed = true,
                            Name = "Mizu Japanese Restaurant - Niles",
                            Phone = "(330) 652-2888",
                            PostalCode = "44446",
                            State = "OH",
                            WebsiteUrl = "http://www.mizu-oh.com/"
                        },
                        new
                        {
                            Id = new Guid("2c2cbc01-09e7-4847-81ef-7548cdf0a01a"),
                            Address = "824 N State St",
                            City = "Girard",
                            Country = "USA",
                            EmailAddress = "",
                            IsConfirmed = true,
                            Name = "The Daily Grind, Girard",
                            Phone = "(234) 421-5118",
                            PostalCode = "44420",
                            State = "OH",
                            WebsiteUrl = "http://www.thedailygrindgirard.com/"
                        });
                });

            modelBuilder.Entity("RestaurantReviews.Data.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReviewId");

                    b.Property<string>("Comment")
                        .HasColumnName("Comment")
                        .HasMaxLength(1000);

                    b.Property<int>("Rating")
                        .HasColumnName("Rating");

                    b.Property<Guid>("RestaurauntId")
                        .HasColumnName("RestaurauntId");

                    b.Property<DateTime>("SubmissionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SubmissionDate");

                    b.Property<Guid>("UserId")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("Reviews","DomainData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16df3133-95d2-472a-9c3e-2ce0df5acccd"),
                            Comment = "The food was excellent.",
                            Rating = 4,
                            RestaurauntId = new Guid("0ee5ad3e-1e1e-467a-9ecb-971a1e3aec7f"),
                            SubmissionDate = new DateTime(2019, 2, 22, 5, 5, 23, 9, DateTimeKind.Utc).AddTicks(8826),
                            UserId = new Guid("8555ff24-7bc7-47a2-9bff-29631386e04f")
                        },
                        new
                        {
                            Id = new Guid("85f490b2-a3f2-423c-b80b-8557e937c5fc"),
                            Comment = "The food was good.",
                            Rating = 3,
                            RestaurauntId = new Guid("e5e972bb-7968-466e-b493-dd05948a7fea"),
                            SubmissionDate = new DateTime(2019, 2, 22, 5, 5, 23, 10, DateTimeKind.Utc).AddTicks(2176),
                            UserId = new Guid("8555ff24-7bc7-47a2-9bff-29631386e04f")
                        },
                        new
                        {
                            Id = new Guid("72226d68-e160-47e0-96b7-a27fa40fce20"),
                            Comment = "Great food and great service.",
                            Rating = 5,
                            RestaurauntId = new Guid("2c2cbc01-09e7-4847-81ef-7548cdf0a01a"),
                            SubmissionDate = new DateTime(2019, 2, 22, 5, 5, 23, 10, DateTimeKind.Utc).AddTicks(2191),
                            UserId = new Guid("8555ff24-7bc7-47a2-9bff-29631386e04f")
                        },
                        new
                        {
                            Id = new Guid("1be5046a-ab20-40f9-b678-9b0db543e974"),
                            Comment = "Excellent coffee.",
                            Rating = 5,
                            RestaurauntId = new Guid("2c2cbc01-09e7-4847-81ef-7548cdf0a01a"),
                            SubmissionDate = new DateTime(2019, 2, 22, 5, 5, 23, 10, DateTimeKind.Utc).AddTicks(2193),
                            UserId = new Guid("aa7bd40c-b52c-4979-8645-8332e5bca63a")
                        });
                });

            modelBuilder.Entity("RestaurantReviews.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DateCreated");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("EmailAddress")
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .HasColumnName("MiddleName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users","DomainData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8555ff24-7bc7-47a2-9bff-29631386e04f"),
                            DateCreated = new DateTime(2019, 2, 22, 5, 5, 23, 8, DateTimeKind.Utc).AddTicks(7306),
                            EmailAddress = "user1@email.com",
                            FirstName = "1",
                            IsActive = true,
                            LastName = "User1"
                        },
                        new
                        {
                            Id = new Guid("aa7bd40c-b52c-4979-8645-8332e5bca63a"),
                            DateCreated = new DateTime(2019, 2, 22, 5, 5, 23, 8, DateTimeKind.Utc).AddTicks(9246),
                            EmailAddress = "user2@email.com",
                            FirstName = "2",
                            IsActive = true,
                            LastName = "User2"
                        },
                        new
                        {
                            Id = new Guid("746cf42d-d282-45ec-8d91-7b3858f1876a"),
                            DateCreated = new DateTime(2019, 2, 22, 5, 5, 23, 8, DateTimeKind.Utc).AddTicks(9260),
                            EmailAddress = "user3@email.com",
                            FirstName = "3",
                            IsActive = true,
                            LastName = "User3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}