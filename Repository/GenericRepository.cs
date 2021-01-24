using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {        
        private readonly DbSet<T> _entities;
        private readonly MentoriaContext _context;

        public GenericRepository(MentoriaContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _context.AddAsync(entity);
                var result = await _context.SaveChangesAsync();

                return result == 1;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _entities.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public bool Remove(T entity)
        {
            try
            {
                _entities.Remove(entity);
                var result = _context.SaveChanges();

                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _entities.Update(entity);
                var result = _context.SaveChanges();

                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
