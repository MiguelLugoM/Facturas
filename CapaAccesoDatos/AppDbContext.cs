//Contexto de base de datos

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    /*
    public AppDbContext()
    {
    }*/

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    // Define tus tablas o entidades 
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Vendedor> Vendedors { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Producto> Productos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuración de la cadena de conexión a SQL
        optionsBuilder.UseSqlServer("Data Source=PC-MIGUELL\\SQLEXPRESS;Initial Catalog=BDFacturas;Integrated Security=True;TrustServerCertificate=True");
    }
}


