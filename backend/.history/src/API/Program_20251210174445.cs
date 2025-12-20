using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Host=ep-summer-darkness-a8z961xv-pooler.eastus2.azure.neon.tech;Username=neondb_owner;Password=npg_wdQt6ca2ezlg;Database=neondb;SSL Mode=Require;Trust Server Certificate=true;");

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.Run();

