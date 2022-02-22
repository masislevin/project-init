using project.web.Core.Context;
using project.web.Core.Entities.Base;
using project.web.Core.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.web.Core.Repos
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        protected readonly DatabaseContext _context;

        public BaseRepo(DatabaseContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;            
        }

        public async Task InsertAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task InsertManyAsync(ICollection<T> entities)
        {
            if (entities == null) throw new ArgumentNullException();
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();
            var existing = await _context.Set<T>().FindAsync(entity.Id);
            _context.Entry(existing).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateManyAsync(ICollection<T> entities)
        {
            if (entities == null) throw new ArgumentNullException();
            foreach(var entity in entities)
            {
                var existing = await _context.Set<T>().FindAsync(entity.Id);
                _context.Entry(existing).CurrentValues.SetValues(entity);
            }
            await _context.SaveChangesAsync();
        }
    }
}
