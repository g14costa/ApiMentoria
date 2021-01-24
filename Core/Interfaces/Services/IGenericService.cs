using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<T> FindAsync(int id);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> FindAllAsync();
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        bool Remove(int id);
    }
}
