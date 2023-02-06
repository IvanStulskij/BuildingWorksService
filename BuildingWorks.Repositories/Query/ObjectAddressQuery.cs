using BuildingWorks.Databasable.Entities.BuildingObjects.Address;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Query
{
    public static class ObjectAddressQuery
    {
        public static IQueryable<ObjectAddress> IncludeHierarchy(this IQueryable<ObjectAddress> query)
        {
            return query
                .Include(x => x.Town)
                .Include(x => x.Region)
                .Include(x => x.Street);
        }
    }
}
