
using FinanzasApp.API.Data;
using FinanzasApp.API.Interfaces;
using FinanzasApp.API.Repositories;
using FinanzasApp.API.Services;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IMovimientoRepository, MovimientoRepository>();
            builder.Services.AddScoped<IMovimientoService, MovimientoService>();
            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
