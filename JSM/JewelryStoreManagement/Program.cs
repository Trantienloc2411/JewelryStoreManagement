using DataLayer;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.Services;
using Microsoft.EntityFrameworkCore;

namespace JewelryStoreManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddDbContext<JSMDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("Local")));
            
            //Add Scope 
                //Repositories
                
                builder.Services.AddScoped<BuybackRepository>();
                builder.Services.AddScoped<CounterRepository>();
                builder.Services.AddScoped<CustomerPolicyRepository>();
                builder.Services.AddScoped<CustomerRepository>();
                builder.Services.AddScoped<EmployeeRepository>();
                builder.Services.AddScoped<GiftRepository>();
                builder.Services.AddScoped<GoldRepository>();
                builder.Services.AddScoped<OrderDetailRepository>();
                builder.Services.AddScoped<OrderRepository>();
                builder.Services.AddScoped<ProductRepository>();
                builder.Services.AddScoped<PromotionRepository>();
                builder.Services.AddScoped<TypePriceRepository>();
                builder.Services.AddScoped<WarrantyRepository>();
                builder.Services.AddScoped<RefreshHandlerRepository>();
                builder.Services.AddScoped<IGenericRepository<BuyBack>, BuybackRepository>();
                builder.Services.AddScoped<IGenericRepository<Counter>, CounterRepository>();
                builder.Services.AddScoped<IGenericRepository<CustomerPolicy>, CustomerPolicyRepository>();
                builder.Services.AddScoped<IGenericRepository<Customer>, CustomerRepository>();
                builder.Services.AddScoped<IGenericRepository<Employee>, EmployeeRepository>();
                builder.Services.AddScoped<IGenericRepository<Gift>, GiftRepository>();
                builder.Services.AddScoped<IGenericRepository<Gold>, GoldRepository>();
                builder.Services.AddScoped<IGenericRepository<OrderDetail>, OrderDetailRepository>();
                builder.Services.AddScoped<IGenericRepository<Order>, OrderRepository>();
                builder.Services.AddScoped<IGenericRepository<Product>, ProductRepository>();
                builder.Services.AddScoped<IGenericRepository<Promotion>, PromotionRepository>();
                builder.Services.AddScoped<IGenericRepository<TypePrice>, TypePriceRepository>();
                builder.Services.AddScoped<IGenericRepository<Warranty>, WarrantyRepository>();
                builder.Services.AddScoped<IGenericRepository<RefreshToken>, RefreshHandlerRepository>();
                
                //IService + Service
                builder.Services.AddScoped<IRefreshHandlerService, RefreshHandlerService>();
                builder.Services.AddScoped<IBuyBackService, BuyBackService>();
                builder.Services.AddScoped<ICounterService, CounterService>();
                builder.Services.AddScoped<ICustomerPolicyService, CustomerPolicyService>();
                builder.Services.AddScoped<ICustomerService, CustomerService>();
                builder.Services.AddScoped<IEmployeeService, EmployeeService>();
                builder.Services.AddScoped<IGiftService, GiftService>();
                builder.Services.AddScoped<IGoldService, GoldService>();
                builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
                builder.Services.AddScoped<IOrderService, OrderService>();
                builder.Services.AddScoped<IProductService, ProductService>();
                builder.Services.AddScoped<IPromotionService, PromotionService>();
                builder.Services.AddScoped<ITypePriceService, TypePriceService>();
                builder.Services.AddScoped<IWarrantyService, WarrantyService>();
                    
                var CORS_CONFIG = "_CORS_CONFIG";
                builder.Services.AddCors(options =>
                {
                    options.AddPolicy(name: CORS_CONFIG,
                        builder => builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
                });
                
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


                
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseCors(CORS_CONFIG);
            app.MapControllers();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
