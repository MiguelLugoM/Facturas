//Capa de logica de negocio para Cliente

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;
namespace TallerEvaluativo.CapaLogicaNegocio
{
    public class ClienteService
    {
        private readonly IRepositorio<Cliente> _clienteRepositorio;

        public ClienteService(IRepositorio<Cliente> facturaRepositorio)
        {
            _clienteRepositorio = facturaRepositorio;
        }

        public async Task<IEnumerable<Cliente>> ObtenerTodosLosProductos()
        {
            return await _clienteRepositorio.ReadAll();
        }

        public async Task<Cliente> ObtenerProductoPorId(int id)
        {
            return await _clienteRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(Cliente cliente)
        {
            await _clienteRepositorio.Create(cliente);
        }

        public async Task ActualizarProducto(Cliente cliente)
        {
            await _clienteRepositorio.Update(cliente);
        }

        public async Task EliminarProducto(int id)
        {
            await _clienteRepositorio.Delete(id);
        }
    }
}
