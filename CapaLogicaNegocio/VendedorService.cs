//Capa de logica de negocio para Vendedor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;

namespace TallerEvaluativo.CapaLogicaNegocio
{
    public class VendedorService
    {
        private readonly IRepositorio<Vendedor> _vendedorRepositorio;

        public VendedorService(IRepositorio<Vendedor> personaRepositorio)
        {
            _vendedorRepositorio = personaRepositorio;
        }

        public async Task<IEnumerable<Vendedor>> ObtenerTodosLosProductos()
        {
            return await _vendedorRepositorio.ReadAll();
        }

        public async Task<Vendedor> ObtenerProductoPorId(int id)
        {
            return await _vendedorRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(Vendedor vendedor)
        {
            await _vendedorRepositorio.Create(vendedor);
        }

        public async Task ActualizarProducto(Vendedor vendedor)
        {
            await _vendedorRepositorio.Update(vendedor);
        }

        public async Task EliminarProducto(int id)
        {
            await _vendedorRepositorio.Delete(id);
        }
    }
}
