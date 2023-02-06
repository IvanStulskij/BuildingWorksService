using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFramework;

namespace BuildingWorks.Repositories.Query
{
    public static class ContractsByMaterials
    {
        public static IQueryable<ContractsByMaterials> IncludeHierarchy(this IQueryable<ContractsByMaterials> query)
        {
            return query
                .Include(x => x.Material);
        }
    }
}
