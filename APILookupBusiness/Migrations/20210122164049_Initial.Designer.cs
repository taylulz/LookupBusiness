﻿// <auto-generated />
using LookupBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LookupBusiness.Migrations
{
    [DbContext(typeof(LookupBusinessContext))]
    [Migration("20210122164049_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LookupBusiness.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NearestIntersection")
                        .IsRequired();

                    b.Property<string>("Offerings")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Pricing");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("LookupBusiness.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NearestIntersection")
                        .IsRequired();

                    b.Property<string>("Offerings")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Pricing");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
