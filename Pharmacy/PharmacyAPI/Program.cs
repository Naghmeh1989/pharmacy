using Microsoft.EntityFrameworkCore;
using PharmacyAPI.Mapping;
using PharmacyAPI.Middlewares;
using PharmacyAPI.Models;
using PharmacyAPI.Repositories;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("Logs/Pharmacy_Log.txt",rollingInterval:RollingInterval.Minute)
    .MinimumLevel.Warning()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PharmacyDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("PharmacyConnectionString")));
builder.Services.AddScoped<IProductRepository,SQLProductRepository>();
builder.Services.AddScoped<IAddressRepository, SQLAddressRepository>();
builder.Services.AddScoped<IBrandRepository, SQLBrandRepository>();
builder.Services.AddScoped<IUserRepository, SQLUserRepository>();
builder.Services.AddScoped<ITagRepository, SQLTagRepository>();
builder.Services.AddScoped<ITransactionRepository, SQLTransactionRepository>();
builder.Services.AddScoped<ITransactionStatusRepository, SQLTransactionStatusRepository>();
builder.Services.AddScoped<ICategoryRepository, SQLCategoryRepository>();
builder.Services.AddScoped<IPaymentRepository, SQLPaymentRepository>();
builder.Services.AddScoped<IPaymentStatusRepository, SQLPaymentStatusRepository>();
builder.Services.AddScoped<IPriceHistoryRepository, SQLPriceHistoryRepository>();
builder.Services.AddScoped<IDeliveryStatusRepository, SQLDeliveryStatusRepository>();
builder.Services.AddScoped<IOrderRepository, SQLOrderRepository>();
builder.Services.AddScoped<IOrderStatusRepository, SQLOrderStatusRepository>();
builder.Services.AddScoped<IOrderDetailsRepository, SQLOrderDetailsRepository>();
builder.Services.AddScoped<IProductTagRepository, SQLProductTagRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
