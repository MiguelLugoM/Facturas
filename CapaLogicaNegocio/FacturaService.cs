//Capa de logica de negocio para Factura

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;

namespace TallerEvaluativo.CapaLogicaNegocio
{
    public class FacturaService
    {
        private readonly IRepositorio<Factura> _facturaRepositorio;

        public FacturaService(IRepositorio<Factura> facturaRepositorio)
        {
            _facturaRepositorio = facturaRepositorio; 
        }

        public async Task<IEnumerable<Factura>> ObtenerTodosLosProductos()
        {
            return await _facturaRepositorio.ReadAll();
        }

        public async Task<Factura> ObtenerProductoPorId(int id)
        {
            return await _facturaRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(Factura factura)
        {
            await _facturaRepositorio.Create(factura);
        }

        public async Task ActualizarProducto(Factura factura)
        {
            await _facturaRepositorio.Update(factura);
        }

        public async Task EliminarProducto(int id)
        {
            await _facturaRepositorio.Delete(id);
        }


    }
}
