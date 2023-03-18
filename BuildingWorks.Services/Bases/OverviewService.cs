using AutoMapper;
using BuildingWorks.Databasable;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Services.Interfaces;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;

namespace BuildingWorks.Services.Bases
{
    public abstract class OverviewService<T, TResource, TForm, TOverview> : Service<T, TResource, TForm>, IOverviewService<TResource, TForm, TOverview>
        where T : class, IPersistable<int>
        where TResource : class, IResource
        where TForm : class
        where TOverview: Overview
    {
        public OverviewService(BuildingWorksDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<TOverview>> GetAllOverview(PaginationParameters pagination)
        {
            return Repository
                .Get(pagination)
                .OrderBy(x => x.Id)
                .ProjectTo<TOverview>(Mapper);
        }
    }
}
