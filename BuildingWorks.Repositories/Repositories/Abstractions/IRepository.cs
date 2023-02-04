namespace Models.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
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
