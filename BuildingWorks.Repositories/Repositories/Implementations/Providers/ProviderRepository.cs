using BuildingWorks.Databasable;
using BuildingWorks.Databasable.Entities.Providers;
using BuildingWorks.Repositories.Implementations;
using BuildingWorks.Repositories.Repositories.Abstractions.Providers;
using Microsoft.EntityFrameworkCore;

namespace BuildingWorks.Repositories.Implementation.Providers
{
    public sealed class ProviderRepository : Repository<Provider, int>, IProviderRepository
    {
        public ProviderRepository(BuildingWorksDbContext context) : base(context)
        {
        }

        public async Task<Provider> GetById(int id)
        {
            return await _context.Providers.FirstOrDefaultAsync(provider => provider.Id == id);
        }
    }
}