using BuildingWorks.Models;

namespace BuildingWorks.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> Get(PaginationParameters pagination);
        Task<T> Insert(T entity);
        Task Insert(IEnumerable<T> entities);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }

    public interface IRepository<T, TKey> : IRepository<T>
    {
        Task<T> GetById(TKey id);
    }
}
