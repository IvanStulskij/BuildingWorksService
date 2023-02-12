using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Models.RequestParameters;
using BuildingWorks.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

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

        public IQueryable<T> Get(RequestParameters parameters)
        {
            return _set
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize);
        }

        public async Task<T> GetById(int id)
        {
            return await _set.FirstOrDefaultAsync(x => x.Id == id);
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

        public void Delete(T entity)
        {
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }
    }
}