using BuildingWorks.Models.Databasable.Tables.Provides;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Repositories.Abstractions.Providers;

namespace Models.Repositories.Implementations.Providers
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
