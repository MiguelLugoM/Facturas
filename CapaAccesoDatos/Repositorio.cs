using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEvaluativo.CapaAccesoDatos.BD;

// Esto es una clase generica donde vamos  a implementar la interfaz 
namespace TallerEvaluativo.CapaAccesoDatos
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly BdfacturasContext _context;

        public Repositorio(BdfacturasContext context)
        {
            _context = context;
        }

        // Obtener todos los elementos
        public async Task<IEnumerable<T>> ReadAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        // Obtener un elemento por su ID
        public async Task<T> ReadById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        // Agregar una nueva entidad
        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Actualiza una entidad
        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        // Elimina una entidad por su ID
        public async Task Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

    }
}
