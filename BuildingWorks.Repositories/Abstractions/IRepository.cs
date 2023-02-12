using BuildingWorks.Models.RequestParameters;

namespace BuildingWorks.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> Get(RequestParameters parameters);
        Task<T> Insert(T entity);
        Task Insert(IEnumerable<T> entities);
        Task<T> Update(T entity);
        void Delete(T entity);
    }

    public interface IRepository<T, TKey> : IRepository<T>
    {
        Task<T> GetById(TKey id);
    }
}
