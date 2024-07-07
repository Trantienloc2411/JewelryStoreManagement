﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(JSMDbContext))]
    partial class JSMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("ManufactureCost")
                        .HasColumnType("double precision");

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

                    b.Property<string>("CounterName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("CounterId");

                    b.ToTable("Counters");

                    b.HasData(
                        new
                        {
                            CounterId = 1,
                            IsActive = false,
                            Location = "Counter 01"
                        },
                        new
                        {
                            CounterId = 2,
                            IsActive = false,
                            Location = "Counter 02"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccumulatedPoint")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("CustomerGender")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataLayer.Entities.CustomerPolicy", b =>
                {
                    b.Property<Guid>("CPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ApprovedDate")
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
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("EmployeeGender")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeStatus")
                        .HasColumnType("integer");

                    b.Property<bool>("IsLogin")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ManagedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CounterId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("50449d1d-1c16-4562-8722-fdeea24b1357"),
                            CounterId = 1,
                            Email = "a@gmail.com",
                            EmployeeGender = 0,
                            EmployeeStatus = 1,
                            IsLogin = false,
                            ManagedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Nguyen Van A",
                            Password = "1",
                            Phone = "0354410931",
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeId = new Guid("3fe223eb-3757-47a3-869c-168c16f3dd97"),
                            CounterId = 2,
                            Email = "b@gmail.com",
                            EmployeeGender = 1,
                            EmployeeStatus = 0,
                            IsLogin = false,
                            ManagedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Le Van B",
                            Password = "1",
                            Phone = "0934425563",
                            RoleId = 2
                        },
                        new
                        {
                            EmployeeId = new Guid("f8a3563e-28b3-45e6-a889-073d56ee8a09"),
                            CounterId = 2,
                            Email = "admin@gmail.com",
                            EmployeeGender = 1,
                            EmployeeStatus = 0,
                            IsLogin = true,
                            ManagedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Admin",
                            Password = "1",
                            Phone = "0934425533",
                            RoleId = 3
                        },
                        new
                        {
                            EmployeeId = new Guid("2f2a6f7a-5d99-4bc7-8c09-397760d59b23"),
                            CounterId = 2,
                            Email = "sa@gmail.com",
                            EmployeeGender = 0,
                            EmployeeStatus = 0,
                            IsLogin = true,
                            ManagedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Super Admin",
                            Password = "sa@1",
                            Phone = "0934425533",
                            RoleId = 4
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Gift", b =>
                {
                    b.Property<Guid>("GiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("GiftName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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

                    b.Property<DateOnly>("DateUpdate")
                        .HasColumnType("date");

                    b.Property<int>("GoldContent")
                        .HasColumnType("integer");

                    b.Property<string>("GoldName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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

                    b.Property<string>("PromotionCode")
                        .HasColumnType("text");

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

                    b.Property<double>("ManufactureCost")
                        .HasColumnType("double precision");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double precision");

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

                    b.Property<string>("CertificateUrl")
                        .HasColumnType("text");

                    b.Property<int>("CounterId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<double>("ManufactureCost")
                        .HasColumnType("double precision");

                    b.Property<double>("MarkupRate")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductStatus")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<double>("StonePrice")
                        .HasColumnType("double precision");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.Property<int>("WeightUnit")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.HasIndex("CounterId");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataLayer.Entities.Promotion", b =>
                {
                    b.Property<string>("PromotionCode")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("FixedDiscountAmount")
                        .HasColumnType("double precision");

                    b.Property<int>("PromotionStatus")
                        .HasColumnType("integer");

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

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Staff"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Manager"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Administrator"
                        },
                        new
                        {
                            RoleId = 4,
                            RoleName = "Super Admin"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Transactions", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GiftId")
                        .HasColumnType("uuid");

                    b.Property<int>("PointMinus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransactionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TransactionId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("GiftId");

                    b.ToTable("Transactions");
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
                        .HasForeignKey("PromotionCode");

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

            modelBuilder.Entity("DataLayer.Entities.Transactions", b =>
                {
                    b.HasOne("DataLayer.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Gift", "Gift")
                        .WithMany("Transactions")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Gift");
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

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("DataLayer.Entities.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Gift", b =>
                {
                    b.Navigation("Transactions");
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
