using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }
        
        public async Task<bool> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _repository.FindAllAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _repository.FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> filter)
        {
            return await _repository.FindAsync(filter);
        }

        public bool Remove(int id)
        {
            var entity = FindAsync(id).Result;

            if (entity == null)
            {
                return false;
            }

            return _repository.Remove(entity);
        }

        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
