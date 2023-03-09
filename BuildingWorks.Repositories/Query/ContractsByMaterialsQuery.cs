using BuildingWorks.Databasable.Entities.Providers;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Query
{
    public static class ContractsByMaterialsQuery
    {
        public static IQueryable<ContractsByMaterials> IncludeHierarchy(this IQueryable<ContractsByMaterials> query)
        {
            return query
                .Include(x => x.Material)
                .Include(x => x.Contract);
        }

        public static IQueryable<ContractsByMaterials> IncludeMaterials(this IQueryable<ContractsByMaterials> query)
        {
            return query
                .Include(contractPart => contractPart.Material);
        }
    }
}
