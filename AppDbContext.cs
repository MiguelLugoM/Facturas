using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Define tus tablas o entidades aquí
    //public DbSet<Producto> Productos { get; set; }
}
