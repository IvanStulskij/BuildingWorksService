using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models;
using BuildingWorks.Databasable;
using BuildingWorks.Common.Extensions;
using BuildingWorks.Models;
using BuildingWorks.Services.Interfaces;

namespace BuildingWorks.Services.Bases
{
    public abstract class ConditionalService<T, TResource, TForm> : Service<T, TResource, TForm>, IConditionalService<T, TResource, TForm>
        where T : class, IPersistable<int>
        where TResource : class, IResource
        where TForm : class

    {
        private readonly DbSet<T> _set;
        private readonly IMapper _mapper;

        public ConditionalService(BuildingWorksDbContext context, IMapper mapper) : base(context, mapper)
        {
            _set = context.Set<T>();
            _mapper = mapper;
        }

        public async Task<IEnumerable<TResource>> GetByCondition(Condition condition, string tableName)
        {
            var conditionalSelectQuery = new TemplateConditionalSelectQuery
                (
                    tableName,
                    condition.PropertyName,
                    condition.CompatibleValue
                );

            return _set
                .FromSqlRaw(conditionalSelectQuery.Query)
                .AsNoTracking()
                .ProjectTo<TResource>(_mapper);
        }
    }
}
