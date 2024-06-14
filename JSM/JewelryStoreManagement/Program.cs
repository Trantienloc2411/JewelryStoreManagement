using DataLayer;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

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
            builder.Services.AddAuthorization();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("SuperAdmin", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        var user = context.User;
                        var roleClaim = user.FindFirst("Role");
                        if (roleClaim != null && roleClaim.Value == "1")
                        {
                            return true;
                        }
                        return false;
                    });
                });
                options.AddPolicy("AdminAccessPolicy", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        var user = context.User;
                        var roleClaim = user.FindFirst("Role");
                        if (roleClaim != null && (roleClaim.Value == "2" || roleClaim.Value == "1"))
                        {
                            return true;
                        }
                        return false;
                    });
                });
                //Add more role if you want...
            });

            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter the JWT token obtained from the login endpoint",
                    Name = "Authorization"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });
            builder.Services.AddAuthentication(item =>
            {
                item.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                item.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(item =>
            {
                item.RequireHttpsMetadata = true;
                item.SaveToken = true;
                item.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("c2VydmVwZXJmZWN0bHljaGVlc2VxdWlja2NvYWNoY29sbGVjdHNsb3Bld2lzZWNhbWU=")),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });    
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
                builder.Services.AddScoped<RoleRepository>();
                builder.Services.AddScoped<RefreshHandlerRepository>();
                builder.Services.AddScoped<IGenericRepository<BuyBack>, BuybackRepository>();
                builder.Services.AddScoped<IGenericRepository<Role>, RoleRepository>();
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
                builder.Services.AddScoped<IRoleService, RoleService>();

                var CORS_CONFIG = "_CORS_CONFIG";
                builder.Services.AddCors(options =>
                {
                    options.AddPolicy(name: CORS_CONFIG,
                        builder => builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
                });
                
                builder.Services.AddLogging();

                

                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);





                var app = builder.Build();

                // Configure the HTTP request pipeline.
                using (var scope = app.Services.CreateScope())
                {
                    var serviceProvider = scope.ServiceProvider;

                    var refreshHandler = serviceProvider.GetRequiredService<IRefreshHandlerService>();

                    refreshHandler.RemoveAllRefreshToken();
                }

                app.Use(async (context, next) =>
                {
                    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
                    var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
                    if (string.IsNullOrEmpty(authHeader))
                    {
                        logger.LogWarning("Authorization header is missing");
                    }
                    else
                    {
                        logger.LogInformation($"Authorization header: {authHeader}");
                    }
                    await next();
                });
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
