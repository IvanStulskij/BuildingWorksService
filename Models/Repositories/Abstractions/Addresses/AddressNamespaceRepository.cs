using Models.Repositories.Implementations;

namespace Models.Repositories.Abstractions.Addresses
{
    public abstract class AddressNamespaceRepository<T, TKey> : Repository<T, TKey>, IAddressNamespaceRepository<T> where T : class
    {
        protected AddressNamespaceRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public T GetByName(string name)
        {
            return GetByCondition(a => a.Equals(name)).FirstOrDefault();
        }
    }
}
