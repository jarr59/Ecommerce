using Ecommerce.Products.Data;
using Ecommerce.Products.Data.Repositories;
using Ecommerce.Products.Handlers;
using Ecommerce.Products.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(DummyMarker).Assembly));

builder.Services.AddAutoMapper(new List<Assembly> { typeof(Program).Assembly });

builder.Services.AddScoped<IProductRepo, ProductRepo>();

builder.Services.AddCors(x =>
{
    x.AddDefaultPolicy(e =>
    {
        e.AllowAnyMethod();
        e.AllowAnyOrigin();
        e.AllowAnyHeader();
    });
        
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
