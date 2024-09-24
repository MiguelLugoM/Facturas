using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esta interfaz nos sirve para no repetir codigo e implementarlas en todas las clases que necesiten CRUD
namespace TallerEvaluativo.CapaAccesoDatos
{
    public interface IRepositorio<Entidad> where Entidad : class
    {
        // Task significa que el metodo va a ser asincrono y esto mejorara el rendimiento
        Task<IEnumerable<Entidad>> ReadAll();
        Task<Entidad> ReadById(int id);
        Task Create(Entidad entity);
        Task Update(Entidad entity);
        Task Delete(int id);

    }
}
