using Microsoft.EntityFrameworkCore;
namespace WebApplication1 {
    internal static class Program {
        private static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddOpenApi();

            var app = builder.Build();
            if (app.Environment.IsDevelopment()) app.MapOpenApi();
            builder.Services.AddDbContext<AppDBContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectionString")));
            app.Run();
        }
    }
}