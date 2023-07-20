//global using Restaurant.Dto.CustomerDto;
global using Restaurant.DbModels;
global using Restaurant.Dto;
//global using Restaurant.Services.CustomerService;
global using Microsoft.EntityFrameworkCore;
global using Restaurant.DbModels;
global using Microsoft.AspNetCore.Mvc;
using Restaurant.Services.AuthServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//builder.Services.AddScoped<IAuthService, IAuthService>();
//builder.Services.AddScoped<AuthService, AuthService>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
