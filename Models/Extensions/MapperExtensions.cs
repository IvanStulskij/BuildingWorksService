using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Models.Extensions
{
    public static class MapperExtensions
    {
        public static IQueryable<T> ProjectTo<T>(this IQueryable source, IMapper mapper, params Expression<Func<T, object>>[] membersToExpand)
        {
            return source.ProjectTo(mapper.ConfigurationProvider, null, membersToExpand);
        }
    }
}
