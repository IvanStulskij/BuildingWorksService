using System.Linq.Expressions;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Models;
using BuildingWorks.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementations
{
    public abstract class Repository<T, TKey> : IRepository<T> where T : class, IPersistable<int> 
    {
        protected readonly BuildingWorksDbContext _context;
        private readonly DbSet<T> _set;

        public Repository(BuildingWorksDbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public IQueryable<T> Get(PaginationParameters pagination)
        {
            var entitiesByPage = _set.ToList().Take((pagination.EntitiesPerPage * (pagination.CurrentPage - 1))..(pagination.EntitiesPerPage * pagination.CurrentPage));
            
            return entitiesByPage.AsQueryable();
        }

        public async Task<T> Insert(T entity)
        {
            await _set.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task Insert(IEnumerable<T> entities)
        {
            await _set.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Update(T entity)
        {
            _set.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(T entity)
        {
            _set.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _set.FirstOrDefaultAsync(item => item.Id == id);
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }
    }
}