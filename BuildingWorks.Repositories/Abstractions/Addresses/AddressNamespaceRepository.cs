using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Repositories.Implementations;

namespace BuildingWorks.Repositories.Abstractions.Addresses
{
    public abstract class AddressNamespaceRepository<T, TKey> : Repository<T, TKey>, IAddressNamespaceRepository<T> where T : IPersistable<int>, class
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
