using Microsoft.EntityFrameworkCore;
using Models.Repositories.Abstractions;

namespace Models.Repositories.Implementations
{
    public class PropertiesNamesRepository<T> : IPropertiesNamesRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;

        public PropertiesNamesRepository(DbSet<T> entities)
        {
            _entities = entities;
        }

        public IEnumerable<string> GetPropertiesNames()
        {
            return _entities.EntityType.GetProperties().Select(property => property.Name);
        }
    }
}
