using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Helpers;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        protected readonly DbSet<T> entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }



        public async Task CreateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            await entities.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }

            entities.Remove(entity);

            await SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            return await entities.IncludeMultiple(includes).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id, params Expression<Func<T, object>>[] includes)
        {
            if (id is null) throw new ArgumentNullException();

            T entity = await entities.IncludeMultiple(includes).FirstOrDefaultAsync(e => e.Id == id);

            if (entity is null) throw new NullReferenceException("Not Found Data");

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            entities.Update(entity);
            await SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            entity.SoftDelete = true;

            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync() => _context.SaveChangesAsync();
    }
}