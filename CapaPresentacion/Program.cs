using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TallerEvaluativo.CapaAccesoDatos;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaLogicaNegocio;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            .AddScoped<ClienteService>() // CRUD Cliente
            .AddScoped<EmpresaService>() // CRUD Empresa
            .AddScoped<FacturaService>() // CRUD Factura
            .AddScoped<PersonaService>() // CRUD Persona
            .AddScoped<ProductoService>() // CRUD Producto
            .AddScoped<ProductosPorFacturaService>() // CRUD ProductoPorFactura
            .AddScoped<VendedorService>() // CRUD Vendedor
            .BuildServiceProvider();

        
        static int CRUD()
        {
            int numeroCrud;
           Console.WriteLine("Digite el numero que corresponde a la funcion que quieres ejecutar");
           Console.WriteLine("1. Obtener todos los datos registrados \n" +
            "2. Obtener los datos por su ID \n" +
            "3. Agregar \n" +
            "4. Actualizar \n" +
            "5. Eliminar \n" +
            "6. Salir\n");
            numeroCrud = int.Parse(Console.ReadLine());
            return numeroCrud;
        }
        while (true) // Inicia un ciclo infinito
        {
            Console.WriteLine("Digite el numero que corresponde a la entidad a la que quieres acceder");
            Console.WriteLine("1. Cliente \n" +
                "2. Empresa \n" +
                "3. Factura \n" +
                "4. Persona \n" +
                "5. Producto \n" +
                "6. ProductoPorFactura \n" +
                "7. Vendedor\n" +
                "8. Salir\n");

            int numeroEntidad;
            // Intenta parsear la entrada del usuario
            if (int.TryParse(Console.ReadLine(), out numeroEntidad))
            {
                switch (numeroEntidad)
                {
                    case 1:

                        break;
                    case 2:
                        Console.WriteLine("Ingresaste al area de EMPRESA");
                        int numeroCrud = CRUD();


                        switch (numeroCrud)
                        {
                            case 1:
                                // Obtiene todos los datos registrados

                                var empresaService = serviceProvider.GetService<EmpresaService>();

                                if (empresaService == null)
                                {
                                    Console.WriteLine("El servicio clienteService no se ha inicializado.");
                                    return; // Detener ejecución si no se inicializa
                                }

                                var empresas = await empresaService.ObtenerTodosLosProductos();

                                foreach (var empresa in empresas)
                                {
                                    Console.WriteLine($"Codigo: {empresa.Codigo}, Nombre: {empresa.Nombre}");
                                }
                                break;
                            case 2:
                                // Obtiene los datos por su ID
                                break;
                            case 3:
                                // Agrega una tupla
                                break;
                            case 4:
                                // Actualiza una tubla por su Primary key
                                break;
                            case 5:
                                // Elimina una tubla por su Primary Key
                                break;
                            default:
                                Console.WriteLine("Digitaste una accion que no existe");
                                break;
                        }

                 
                        break;
                    case 3:
                        Console.WriteLine("Ingresaste al area de FACTURA");
                        CRUD();
                        break;
                    case 4:
                        Console.WriteLine("Ingresaste al area de PERSONA");
                        CRUD();
                        break;
                    case 5:
                        Console.WriteLine("Ingresaste al area de PRODUCTO");
                        CRUD();
                        break;
                    case 6:
                        Console.WriteLine("Ingresaste al area de PRODUCTOPORFACTURA");
                        CRUD();
                        break;
                    case 7:
                        Console.WriteLine("Ingresaste al area de VENDEDOR");
                        CRUD();
                        break;
                    case 8:
                        Console.WriteLine("Gracias por Visitarnos. vuelve pronto");
                        CRUD();
                        break;
                    default:
                        Console.WriteLine("Digita una entidad que si exista");
                        continue; // Vuelve a iniciar el ciclo
                }
                break; // Si se ingresa un número válido, sal del ciclo
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
        
    }
}








    /* Obtener el servicio ProductoService del contenedor
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

    Console.WriteLine("Producto agregado exitosamente.");*/

