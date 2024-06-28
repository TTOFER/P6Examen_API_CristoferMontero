using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using P6Examen_API_CristoferMontero.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//1
var CnnStrBuilder = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("CnnStr"));

//2 
CnnStrBuilder.Password = "123Queso";

//3
string cnnStr = CnnStrBuilder.ConnectionString;

//4
builder.Services.AddDbContext<Ex1p6assets20243Context>(options => options.UseSqlServer(cnnStr));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
