//Capa de logica de negocio para ProductosPorFactura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;


namespace TallerEvaluativo.CapaLogicaNegocio
{
    public class ProductosPorFacturaService
    {
        private readonly IRepositorio<ProductosPorFactura> _productosPorFacturaRepositorio;

        public ProductosPorFacturaService(IRepositorio<ProductosPorFactura> productosPorFactura)
        {
            _productosPorFacturaRepositorio = productosPorFactura;
        }

        public async Task<IEnumerable<ProductosPorFactura>> ObtenerTodosLosProductos()
        {
            return await _productosPorFacturaRepositorio.ReadAll();
        }

        public async Task<ProductosPorFactura> ObtenerProductoPorId(int id)
        {
            return await _productosPorFacturaRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(ProductosPorFactura productosPorFactura)
        {
            await _productosPorFacturaRepositorio.Create(productosPorFactura);
        }

        public async Task ActualizarProducto(ProductosPorFactura productosPorFactura)
        {
            await _productosPorFacturaRepositorio.Update(productosPorFactura);
        }

        public async Task EliminarProducto(int id)
        {
            await _productosPorFacturaRepositorio.Delete(id);
        }
    }
}
