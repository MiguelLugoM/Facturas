//Capa de logica de negocio para Producto

using TallerEvaluativo.CapaAccesoDatos;
using TallerEvaluativo.CapaAccesoDatos.BD;

namespace TallerEvaluativo.CapaLogicaNegocio;
public class ProductoService
{
    private readonly IRepositorio<Producto> _productoRepositorio;

    //Constructor
    public ProductoService(IRepositorio<Producto> productoRepositorio)
    {
        _productoRepositorio = productoRepositorio;
    }

    public async Task<IEnumerable<Producto>> ObtenerTodosLosProductos()
    {
        return await _productoRepositorio.ReadAll();
    }

    public async Task<Producto> ObtenerProductoPorId(int id)
    {
        return await _productoRepositorio.ReadById(id);
    }

    public async Task AgregarProducto(Producto producto)
    {
        await _productoRepositorio.Create(producto);
    }

    public async Task ActualizarProducto(Producto producto)
    {
        await _productoRepositorio.Update(producto);
    }

    public async Task EliminarProducto(int id)
    {
        await _productoRepositorio.Delete(id);
    }
}