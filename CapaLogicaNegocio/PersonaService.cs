//Capa de logica de negocio para Persona

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;
using TallerEvaluativo.CapaAccesoDatos;

namespace TallerEvaluativo.CapaLogicaNegocio
{
    public class PersonaService
    {
        private readonly IRepositorio<Persona> _personaRepositorio;

        public PersonaService(IRepositorio<Persona> personaRepositorio)
        {
            _personaRepositorio = personaRepositorio;
        }

        public async Task<IEnumerable<Persona>> ObtenerTodosLosProductos()
        {
            return await _personaRepositorio.ReadAll();
        }

        public async Task<Persona> ObtenerProductoPorId(int id)
        {
            return await _personaRepositorio.ReadById(id);
        }

        public async Task AgregarProducto(Persona Persona)
        {
            await _personaRepositorio.Create(Persona);
        }

        public async Task ActualizarProducto(Persona Persona)
        {
            await _personaRepositorio.Update(Persona);
        }

        public async Task EliminarProducto(int id)
        {
            await _personaRepositorio.Delete(id);
        }
    }
}
