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
    }
}
