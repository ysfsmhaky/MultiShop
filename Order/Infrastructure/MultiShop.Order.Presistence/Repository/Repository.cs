using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Presistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Presistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OrderContext _contex;

        public Repository(OrderContext contex)
        {
            _contex = contex;
        }
        public async Task CreateAsync(T entity)
        {
            _contex.Set<T>().Add(entity);
            await _contex.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _contex?.Set<T>().Remove(entity);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _contex.Set<T>().ToListAsync();    
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _contex.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _contex.Set<T>().FindAsync(id);
        }
 
        public async Task UpdateAsync(T entity)
        {
            _contex.Set<T>().Update(entity);
            await _contex.SaveChangesAsync();
        }
    }

}