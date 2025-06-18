using FinanzasApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movimiento> Movimientos { get; set; }


    }
}
