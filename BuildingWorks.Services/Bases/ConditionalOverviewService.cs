using AutoMapper;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Repositories.Abstractions;
using BuildingWorks.Services.Interfaces;

namespace BuildingWorks.Services.Bases
{
    public class ConditionalOverviewService<T, TResource, TForm, TOverview> : ConditionalService<T, TResource, TForm>, IOverviewService<TResource, TForm, TOverview>
        where T : class, IPersistable<int>
        where TResource : class, IResource
        where TForm : class
        where TOverview: Overview

    {
        public ConditionalOverviewService(BuildingWorksDbContext context, IMapper mapper, IRepository<T, int> repository) : base(context, mapper)
        {
            Repository = repository;
        }

        public override IRepository<T, int> Repository { get; }

        public async Task<IEnumerable<TOverview>> GetAllOverview(PaginationParameters pagination)
        {
            return Repository
                .Get(pagination)
                .OrderBy(x => x.Id)
                .ProjectTo<TOverview>(Mapper);
        }
    }
}
