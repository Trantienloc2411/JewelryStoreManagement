using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyBack>().HasKey(bb => bb.BuyBackId);
            modelBuilder.Entity<BuyBack>()
                  .HasOne(bb => bb.Order)  // Assuming BuyBack has a navigation property Order
                  .WithOne(o => o.BuyBack) // Assuming Order has a navigation property BuyBack
                  .HasForeignKey<BuyBack>(bb => bb.OrderId);
            modelBuilder.Entity<BuyBack>()
                .HasOne(c => c.Product).WithMany(bb => bb.BuyBacks).HasForeignKey(d => d.ProductId);

            modelBuilder.Entity<Counter>().HasKey(c => c.CounterId);

            modelBuilder.Entity<Customer>().HasKey(cu => cu.CustomerId);

            modelBuilder.Entity<CustomerPolicy>().HasKey(cp => cp.CPId);
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
            //new
            modelBuilder.Entity<Order>()
                .HasOne(o => o.CustomerPolicy)
                .WithOne(cp => cp.Order)
                .HasForeignKey<Order>(o => o.CPId)
                .IsRequired(false);
            
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

            modelBuilder.Entity<Transactions>().HasKey(t => t.TransactionId);
            modelBuilder.Entity<Transactions>().HasOne<Customer>(c => c.Customer).WithMany(t => t.Transactions);
            modelBuilder.Entity<Transactions>().HasOne<Gift>(g => g.Gift).WithMany(t => t.Transactions);

            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 1,
                RoleName = "Staff"
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 2,
                RoleName = "Manager"
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 3,
                RoleName = "Administrator"
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 4,
                RoleName = "Super Admin"
            });
            
            modelBuilder.Entity<Role>().HasData(new Role
                        {
                            RoleId = 5,
                            RoleName = "Customer"
                        }); 

            modelBuilder.Entity<Counter>().HasData(new Counter
            {
                CounterId = 1,
                Location = "Counter 01",
                CounterName = "Counter 01"
            });
            modelBuilder.Entity<Counter>().HasData(new Counter
            {
                CounterId = 2,
                Location = "Counter 02",
                CounterName = "Counter 02"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
	            EmployeeId = Guid.NewGuid(),
	            Name = "Nguyen Van A",
	            CounterId = 1,
	            Email = "a@gmail.com",
	            Password = "$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W",
	            Phone = "0354410931",
	            EmployeeGender = Employee.EmployeeGenders.Male,
	            EmployeeStatus = Employee.EmployeeStatuses.Inactive,
	            IsLogin = false,
	            RoleId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
	            EmployeeId = Guid.NewGuid(),
	            Name = "Le Van B",
	            CounterId = 2,
	            Email = "b@gmail.com",
	            Password = @"$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W",
	            Phone = "0934425563",
	            EmployeeGender = Employee.EmployeeGenders.Female,
	            EmployeeStatus = Employee.EmployeeStatuses.Active,
	            IsLogin = false,
	            RoleId = 2
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                Name = "Admin",
                CounterId = 2,
                Email = "admin@gmail.com",
                Password = @"$2a$11$Tr9OUgu.cRTTH.rb93o9QuTXxbJhLKu/KgCmxRgbU/4YT5BPQp/2W",
                Phone = "0934425533",
                EmployeeGender = Employee.EmployeeGenders.Female,
                EmployeeStatus = Employee.EmployeeStatuses.Active,
                IsLogin = true,
                RoleId = 3
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                Name = "Super Admin",
                CounterId = 2,
                Email = "sa@gmail.com",
                Password = @"$2a$11$rvbF4Kctvp1VFftcz.cTf.iCV.Gjrw65RzPy4XsOmyx8.dea6KLN6",
                Phone = "0934425533",
                EmployeeGender = Employee.EmployeeGenders.Male,
                EmployeeStatus = Employee.EmployeeStatuses.Active,
                IsLogin = true,
                RoleId = 4
            });

            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod
            {
                PaymentId = 1,
                PaymentType = "Cash"
            });
            
            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod
            {
                PaymentId = 2,
                PaymentType = "Mobile Banking"
            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 1,
                TypeName = "Gold",
                BuyPricePerGram = 500000,
                SellPricePerGram = 750000,
                DateUpdated = DateTime.UtcNow
            });

            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 2,
                TypeName = "Diamond",
                BuyPricePerGram = 5000000,
                SellPricePerGram = 7500000,
                DateUpdated = DateTime.UtcNow
            });

            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 3,
                TypeName = "Jewel",
                BuyPricePerGram = 2000000,
                SellPricePerGram = 3000000,
                DateUpdated = DateTime.UtcNow
            });

            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 4,
                TypeName = "Vàng nhẫn SJC 99,99 1 chỉ, 2 chỉ, 5 chỉ",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 5,
                TypeName = "Vàng nhẫn SJC 99,99 0,3 chỉ, 0,5 chỉ",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 6,
                TypeName = "Vàng nữ trang 99,99%",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 7,
                TypeName = "Vàng nữ trang 99%",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 8,
                TypeName = "Vàng nữ trang 75%",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 9,
                TypeName = "Vàng nữ trang 58,3%",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow

            });
            
            modelBuilder.Entity<TypePrice>().HasData(new TypePrice
            {
                TypeId = 10,
                TypeName = "Vàng nữ trang 41,7%",
                BuyPricePerGram = 0,
                SellPricePerGram = 0,
                DateUpdated = DateTime.UtcNow
            });
            
            
            
            string[] imageUrls = new string[]
            {
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F1.jpg?alt=media&token=edd76054-7ffd-4726-9f57-3a5abe125c10",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F2.jpg?alt=media&token=54f08c6f-e41e-4cde-b6c6-1e40194320a5",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F3.jpg?alt=media&token=f255817b-bc8f-405c-91f8-a5c733b20a16",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F4.jpg?alt=media&token=d87d662c-f2ff-4dec-ac0a-8da9fb426585",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F5.jpg?alt=media&token=d0f7a320-2176-4b9c-b6b3-df74cbf36baa",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2FDayChuyenBac.jpg?alt=media&token=4badf84f-4a3c-489a-bf3b-59bd3517dd8a",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F7.jpg?alt=media&token=5b91fa57-76a5-4911-820b-86f9b11ebbf9",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F8.jpg?alt=media&token=bbe17db6-2209-42ad-86dd-ee2422be3d56",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F9.jpg?alt=media&token=0f4b2e0c-ecf4-4ea8-9047-efe08d5b4e71",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F10.jpg?alt=media&token=55a92de8-ee5c-42c9-9abe-878a240dd0f1",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F11.jpg?alt=media&token=7afc835a-dc04-491f-a922-14f97c05ad47",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F12.jpg?alt=media&token=4d09d356-609b-410c-8a9a-bafdb4c906cd",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F14.jpg?alt=media&token=f9685ad2-52ff-4c5b-b27d-af7e82831126",
    "https://firebasestorage.googleapis.com/v0/b/jss-prn221.appspot.com/o/Products%2F15.jpg?alt=media&token=54605a2e-243b-471a-95be-1636963e915a"
            };

            // Product Data
            for (int i = 1; i <= 30; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = $"Gold Product {i}",
                    Barcode = $"GOLD00{i}",
                    ManufactureCost = 1000000 + i * 1000,
                    Weight = 50.0 + i,
                    Quantity = 10 + i,
                    Description = $"Gold product description {i}",
                    CounterId = 1,
                    TypeId = 1,
                    Img = imageUrls[i % imageUrls.Length],
                    ProductStatus = Product.ProductStatuses.Active,
                    Price = 1500000 + i * 1000,
                    MarkupRate = 0.5,
                    WeightUnit = Product.Units.g,
                    StonePrice = 750000 + i * 5000
                });
            }

            for (int i = 1; i <= 30; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = $"Diamond Product {i}",
                    Barcode = $"DIAMOND00{i}",
                    ManufactureCost = 5000000 + i * 5000,
                    Weight = 10.0 + i,
                    Quantity = 5 + i,
                    Description = $"Diamond product description {i}",
                    CounterId = 1,
                    TypeId = 2,
                    Img = imageUrls[i % imageUrls.Length],
                    ProductStatus = Product.ProductStatuses.Active,
                    Price = 7500000 + i * 5000,
                    MarkupRate = 0.6,
                    WeightUnit = Product.Units.g,
                    StonePrice = 15000000 + i * 5000
                });
            }

            for (int i = 1; i <= 30; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = $"Jewel Product {i}",
                    Barcode = $"JEWEL00{i}",
                    ManufactureCost = 2000000 + i * 2000,
                    Weight = 20.0 + i,
                    Quantity = 15 + i,
                    Description = $"Jewel product description {i}",
                    CounterId = 1,
                    TypeId = 3,
                    Img = imageUrls[i % imageUrls.Length],
                    ProductStatus = Product.ProductStatuses.Active,
                    Price = 3000000 + i * 2000,
                    MarkupRate = 0.55,
                    WeightUnit = Product.Units.g,
                    StonePrice = 5000000 + i * 2000
                });
            }


            modelBuilder.Entity<Promotion>().HasData(new Promotion
            {
                PromotionCode = "Promotion 01",
                Description = "This is the promtion super hot",
                DiscountPercentage = 10,
                EndDate = DateTime.UtcNow.AddDays(10),
                PromotionStatus = Promotion.PromotionStatuses.Active
            });
            
            modelBuilder.Entity<Promotion>().HasData(new Promotion
            {
                PromotionCode = "Promotion 02",
                Description = "This is the promtion super hot",
                DiscountPercentage = 10,
                EndDate = DateTime.UtcNow.AddDays(-10),
                PromotionStatus = Promotion.PromotionStatuses.Inactive
                
            });
            
            modelBuilder.Entity<Promotion>().HasData(new Promotion
            {
                PromotionCode = "Promotion 03",
                Description = "This is the promtion super hot",
                DiscountPercentage = 10,
                EndDate = DateTime.UtcNow.AddDays(-10),
                PromotionStatus = Promotion.PromotionStatuses.Deleted
                
            });

            modelBuilder.Entity<Gift>().HasData(new Gift
            {
                GiftId = Guid.NewGuid(),
                GiftName = "Lịch vạn niên 2025",
                PointRequired = 6000
            });
            
            modelBuilder.Entity<Gift>().HasData(new Gift
            {
                GiftId = Guid.NewGuid(),
                GiftName = "Bộ bàn ghế gỗ",
                PointRequired = 14000
            });
            
            modelBuilder.Entity<Gift>().HasData(new Gift
            {
                GiftId = Guid.NewGuid(),
                GiftName = "Áo mưa",
                PointRequired = 3500
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = Guid.NewGuid(),
                Name = "anh Lâm",
                AccumulatedPoint = 3000,
                Address = "Xã Hồng Thủy, Huyện Lệ Thủy, Quảng Bình",
                Email = "lamAnh@hotmail.com",
                Phone = "0820256734",
                CustomerGender = Customer.CustomerGenders.Male
            });
            
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = Guid.NewGuid(),
                Name = "Nguyễn Thị Hoa",
                AccumulatedPoint = 0,
                Address = "Phường Tân Phú, Quận 7, Thành phố Hồ Chí Minh",
                Email = "hoanguyen@outlook.com",
                Phone = "0987654321",
                CustomerGender = Customer.CustomerGenders.Female
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = Guid.NewGuid(),
                Name = "Phạm Văn Đức",
                AccumulatedPoint = 0,
                Address = "Phường Cửa Nam, Quận Hoàn Kiếm, Hà Nội",
                Email = "ducpham@yahoo.com",
                Phone = "0909876543",
                CustomerGender = Customer.CustomerGenders.Male
            });
            
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = Guid.NewGuid(),
                Name = "Trần Minh",
                AccumulatedPoint = 2500,
                Address = "Phường Cầu Diễn, Quận Nam Từ Liêm, Hà Nội",
                Email = "minhTran@gmail.com",
                Phone = "0912345678",
                CustomerGender = Customer.CustomerGenders.Female
            });
            
            














            //base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //DeployDB do not change this
                //optionsBuilder.UseNpgsql("Server=jss-dev.postgres.database.azure.com;Database=JSM;Port=5432;User Id=fams;Password=Jss12345;Ssl Mode=Require;Trust Server Certificate = true");
                //
                //LocalDb
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=JSM;Username=postgres;Password=24112003;Integrated Security=true;");
                
            }
        }

        
        



    }
}

