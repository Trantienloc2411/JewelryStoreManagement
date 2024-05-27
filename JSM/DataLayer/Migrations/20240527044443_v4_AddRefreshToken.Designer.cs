﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(JSMDbContext))]
    [Migration("20240527044443_v4_AddRefreshToken")]
    partial class v4_AddRefreshToken
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Entities.BuyBack", b =>
                {
                    b.Property<Guid>("BuyBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("HaveInvoice")
                        .HasColumnType("boolean");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("BuyBackId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("BuyBacks");
                });

            modelBuilder.Entity("DataLayer.Entities.Counter", b =>
                {
                    b.Property<int>("CounterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CounterId"));

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.HasKey("CounterId");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccummulatedPoint")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataLayer.Entities.CustomerPolicy", b =>
                {
                    b.Property<Guid>("CPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ApproveBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("ApprovedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<double>("DiscountRate")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsApprovalRequired")
                        .HasColumnType("boolean");

                    b.Property<int>("PublishingStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CPId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerPolicies");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CounterId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<bool>("isLogin")
                        .HasColumnType("boolean");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CounterId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DataLayer.Entities.Gift", b =>
                {
                    b.Property<Guid>("GiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("GiftName")
                        .HasColumnType("text");

                    b.Property<int>("PointRequired")
                        .HasColumnType("integer");

                    b.HasKey("GiftId");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("DataLayer.Entities.Gold", b =>
                {
                    b.Property<Guid>("GoldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("BuyingPrice")
                        .HasColumnType("double precision");

                    b.Property<int>("GoldContent")
                        .HasColumnType("integer");

                    b.Property<string>("GoldName")
                        .HasColumnType("text");

                    b.Property<string>("GoldType")
                        .HasColumnType("text");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("double precision");

                    b.HasKey("GoldId");

                    b.ToTable("Golds");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("text");

                    b.Property<int>("AccumulatedPoint")
                        .HasColumnType("integer");

                    b.Property<int>("CounterId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<Guid>("PromotionCode")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("CounterId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PromotionCode");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderDetail", b =>
                {
                    b.Property<string>("OrderDetailId")
                        .HasColumnType("text");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("integer");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DataLayer.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentId"));

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PaymentId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Barcode")
                        .HasColumnType("text");

                    b.Property<int>("CounterId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<int>("ManuafactureCost")
                        .HasColumnType("integer");

                    b.Property<double>("MarkupRate")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("ProductId");

                    b.HasIndex("CounterId");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataLayer.Entities.Promotion", b =>
                {
                    b.Property<Guid>("PromotionCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("FixedDiscountAmount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PromotionCode");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DataLayer.Entities.RefreshToken", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RefreshTokenString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Statuses")
                        .HasColumnType("integer");

                    b.Property<string>("TokenId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("EmployeeId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("DataLayer.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataLayer.Entities.TypePrice", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TypeId"));

                    b.Property<double>("BuyPricePerGram")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("SellPricePerGram")
                        .HasColumnType("double precision");

                    b.Property<string>("TypeName")
                        .HasColumnType("text");

                    b.HasKey("TypeId");

                    b.ToTable("TypePrices");
                });

            modelBuilder.Entity("DataLayer.Entities.Warranty", b =>
                {
                    b.Property<Guid>("WarrantyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OrderDetailId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("WarrantyId");

                    b.HasIndex("OrderDetailId")
                        .IsUnique();

                    b.ToTable("Warranties");
                });

            modelBuilder.Entity("DataLayer.Entities.BuyBack", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithOne("BuyBack")
                        .HasForeignKey("DataLayer.Entities.BuyBack", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Product", "Product")
                        .WithMany("BuyBacks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataLayer.Entities.CustomerPolicy", b =>
                {
                    b.HasOne("DataLayer.Entities.Customer", "Customer")
                        .WithMany("CustomerPolicies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.HasOne("DataLayer.Entities.Counter", "Counter")
                        .WithMany("Employees")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Counter");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.HasOne("DataLayer.Entities.Counter", "Counter")
                        .WithMany("Orders")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Promotion", "Promotion")
                        .WithMany("Orders")
                        .HasForeignKey("PromotionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Counter");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("PaymentMethod");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderDetail", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.HasOne("DataLayer.Entities.Counter", "Counter")
                        .WithMany("Products")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.TypePrice", "TypePrice")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Counter");

                    b.Navigation("TypePrice");
                });

            modelBuilder.Entity("DataLayer.Entities.Warranty", b =>
                {
                    b.HasOne("DataLayer.Entities.OrderDetail", "OrderDetail")
                        .WithOne("Warranty")
                        .HasForeignKey("DataLayer.Entities.Warranty", "OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("DataLayer.Entities.Counter", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Navigation("CustomerPolicies");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Navigation("BuyBack")
                        .IsRequired();

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderDetail", b =>
                {
                    b.Navigation("Warranty")
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Entities.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Navigation("BuyBacks");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DataLayer.Entities.Promotion", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DataLayer.Entities.TypePrice", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
