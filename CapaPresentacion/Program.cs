using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TallerEvaluativo.CapaAccesoDatos;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaLogicaNegocio;
using System.Threading.Tasks;

//Capa de Presentacion (Interfaz de usuario)
class Program
{
    static async Task Main(string[] args)
    {

        // Configuración del contenedor de servicios
        var serviceProvider = new ServiceCollection()
            .AddDbContext<BdfacturasContext>(options =>
                options.UseSqlServer("Server=PC-MIGUELL\\SQLEXPRESS;Database=BDFacturas;Trusted_Connection=True;"))
            .AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>)) // Registro del repositorio genérico
            .AddScoped<Cliente>() // Registro del servicio Cliente
            .AddScoped<Empresa>() // Registro del servicio Empresa
            .AddScoped<Factura>() // Registro del servicio Factura
            .AddScoped<Persona>() // Registro del servicio Persona
            .AddScoped<Producto>() // Registro del servicio Producto
            .AddScoped<ProductosPorFactura>() // Registro del servicio ProductoPorFactura
            .AddScoped<Vendedor>() // Registro del servicio Vendedor
            .AddScoped<ProductoService>() // CRUD generico
            .BuildServiceProvider();


        // Obtener el servicio ProductoService del contenedor
        var productoService = serviceProvider.GetService<ProductoService>();

        if (productoService == null)
        {
            Console.WriteLine("El servicio ProductoService no se ha inicializado.");
            return; // Detener ejecución si no se inicializa
        }

        Console.WriteLine("Agrega un nuevo Producto");
        Console.WriteLine("Ingrese el codigo:");
        string codigo = Console.ReadLine();

        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el numero de Stock");
        int stock = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor unitario");
        double valorU = double.Parse(Console.ReadLine());


        // Crear una nueva instancia de Producto
        var nuevoProducto = new Producto
        {
            Codigo = codigo,
            Nombre = nombre,
            Stock = stock,
            ValorUnitario = valorU
        };

        // Agregar el nuevo producto a la base de datos
        await productoService.AgregarProducto(nuevoProducto);

        Console.WriteLine("Producto agregado exitosamente.");
    }
}
