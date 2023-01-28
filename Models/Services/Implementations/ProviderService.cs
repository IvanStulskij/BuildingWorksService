using AutoMapper;
using AutoMapper.QueryableExtensions;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorksBackend.Services.Interfaces;
using Models.Contexts;
using Models.Extensions;
using Microsoft.EntityFrameworkCore;
using Models.Resources.Providers;
using Models.Repositories.Abstractions.Providers;

namespace Models.Services.Implementations
{
    public class ProviderService :
        Service<Provider, ProviderResource>,
        IProviderService
    {
        public override IProviderRepository Repository { get; }

        public ProviderService(
            IProviderRepository repository,
            BuildingWorksDbContext context,
            IMapper mapper
            ) : base(context, mapper)
        {
            Repository = repository;
        }

        public Task<List<ProviderResource>> GetAll()
        {
            return Repository.Get()
                .ProjectTo<ProviderResource>(Mapper).ToListAsync();
        }

        public override async Task<ProviderResource> GetById(int id)
        {
            return Mapper.Map<ProviderResource>(await Context.Providers.FirstOrDefaultAsync(provider => provider.Id == id));
        }

        public async Task<Provider> Update(ProviderResource resource)
        {
            var entity = await Context.Providers.FirstOrDefaultAsync(provider => provider.Id == resource.ProviderCode);
            entity = Mapper.Map<Provider>(resource);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<ProviderResource> Create(ProviderForm providerForm)
        {
            var entity = Mapper.Map<ProviderForm>(providerForm);
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

            return Mapper.Map<ProviderResource>(entity);
        }
    }
}
