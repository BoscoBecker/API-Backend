using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using WebApplication1.Models;

    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    var app = builder.Build();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment()) app.MapOpenApi();
    builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectionString")));
    app.Run();