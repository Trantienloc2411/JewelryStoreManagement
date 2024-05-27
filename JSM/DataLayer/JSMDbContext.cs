﻿using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
#pragma warning disable
namespace DataLayer
{
	public class JSMDbContext : DbContext
	{
		public JSMDbContext() { }	
		public JSMDbContext(DbContextOptions<JSMDbContext> options) : base(options) { }

		public virtual DbSet<BuyBack> BuyBacks { get; set; }
		public virtual DbSet<Counter> Counters { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<CustomerPolicy> CustomerPolicies { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
		public virtual DbSet<Gift> Gifts { get; set; }
		public virtual DbSet<Gold> Golds { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<OrderDetail> OrderDetails { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Promotion> Promotions { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<TypePrice> TypePrices { get; set; }
		public virtual DbSet<Warranty> Warranties { get; set; }
		public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
		public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyBack>().HasKey(bb => bb.BuyBackId);
			modelBuilder.Entity<BuyBack>()
                  .HasOne(bb => bb.Order)  // Assuming BuyBack has a navigation property Order
                  .WithOne(o => o.BuyBack) // Assuming Order has a navigation property BuyBack
                  .HasForeignKey<BuyBack>(bb => bb.OrderId);
			modelBuilder.Entity<BuyBack>()
				.HasOne(c => c.Product).WithMany(bb => bb.BuyBacks).HasForeignKey(d => d.ProductId);

			modelBuilder.Entity<Counter>().HasKey(c =>  c.CounterId );

			modelBuilder.Entity<Customer>().HasKey(cu =>  cu.CustomerId );

			modelBuilder.Entity<CustomerPolicy>().HasKey(cp =>  cp.CPId);
			modelBuilder.Entity<CustomerPolicy>().HasOne(cu => cu.Customer).WithMany(cp => cp.CustomerPolicies).HasForeignKey(cp => cp.CustomerId);

			modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
			modelBuilder.Entity<Employee>().HasOne(r => r.Role).WithMany(e => e.Employees).HasForeignKey(r => r.RoleId);
			modelBuilder.Entity<Employee>().HasOne(co => co.Counter).WithMany(e => e.Employees).HasForeignKey(co => co.CounterId);

			modelBuilder.Entity<Gift>().HasKey(g => g.GiftId);

			modelBuilder.Entity<Gold>().HasKey(go => go.GoldId);

			modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
			modelBuilder.Entity<Order>().HasOne(e => e.Employee).WithMany(o => o.Orders).HasForeignKey(e => e.EmployeeId).HasPrincipalKey(e => e.EmployeeId);
			modelBuilder.Entity<Order>().HasOne(cu => cu.Customer).WithMany(o => o.Orders).HasForeignKey(cu => cu.CustomerId).HasPrincipalKey(cu => cu.CustomerId);
			modelBuilder.Entity<Order>().HasOne(co => co.Counter).WithMany(o => o.Orders).HasForeignKey(co => co.CounterId).HasPrincipalKey(co => co.CounterId);
			modelBuilder.Entity<Order>().HasOne(pr => pr.Promotion).WithMany(o => o.Orders).HasForeignKey(o => o.PromotionCode).HasPrincipalKey(po => po.PromotionCode);
			modelBuilder.Entity<Order>().HasOne(pm => pm.PaymentMethod).WithMany(o => o.Orders)
				.HasForeignKey(o => o.PaymentId).HasPrincipalKey(o => o.PaymentId);

			modelBuilder.Entity<OrderDetail>().HasKey(od => od.OrderDetailId);
			modelBuilder.Entity<OrderDetail>().HasOne(p => p.Product).WithMany(od => od.OrderDetails).HasForeignKey(od => od.ProductId);
			modelBuilder.Entity<OrderDetail>().HasOne(o => o.Order).WithMany(od => od.OrderDetails).HasForeignKey(od => od.OrderId);

			modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
			modelBuilder.Entity<Product>().HasOne(co => co.Counter).WithMany(p => p.Products).HasForeignKey(p => p.CounterId);
			modelBuilder.Entity<Product>().HasOne(tp => tp.TypePrice).WithMany(p => p.Products).HasForeignKey(p => p.TypeId);

			modelBuilder.Entity<Promotion>().HasKey(pr => pr.PromotionCode);

			modelBuilder.Entity<Role>().HasKey(r => r.RoleId);

			modelBuilder.Entity<TypePrice>().HasKey(tp => tp.TypeId);

			modelBuilder.Entity<Warranty>().HasKey(w => w.WarrantyId);
            modelBuilder.Entity<Warranty>()
				.HasOne(w => w.OrderDetail)              // Navigation property in Warranty
				.WithOne(od => od.Warranty)              // Navigation property in OrderDetail
				.HasForeignKey<Warranty>(w => w.OrderDetailId);

            modelBuilder.Entity<PaymentMethod>().HasKey(p => p.PaymentId);

            modelBuilder.Entity<RefreshToken>().HasKey(rt => rt.EmployeeId);








            //base.OnModelCreating(modelBuilder);
        }

        
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=JSM;Username=postgres;Password=24112003;Integrated Security=true;Include Error Detail=True");
			}
		}




	}
}

