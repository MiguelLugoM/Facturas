//Capa de logica de negocio para Empresa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;
namespace TallerEvaluativo.CapaLogicaNegocio

{
    public class EmpresaService
    {
        private readonly IRepositorio<Empresa> _empresaRepositorio;

        public EmpresaService(IRepositorio<Empresa> empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public async Task<IEnumerable<Empresa>> ObtenerTodosLosProductos()
        {
            return await _empresaRepositorio.ReadAll();
        }

        public async Task<Empresa> ObtenerProductoPorId(int id)
        {
            return await _empresaRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(Empresa empresa)
        {
            await _empresaRepositorio.Create(empresa);
        }

        public async Task ActualizarProducto(Empresa empresa)
        {
            await _empresaRepositorio.Update(empresa);
        }

        public async Task EliminarProducto(int id)
        {
            await _empresaRepositorio.Delete(id);
        }
    }
}
