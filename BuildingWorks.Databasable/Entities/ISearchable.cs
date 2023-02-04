using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BuildingWorks.Models.Databasable.Tables
{
    public interface ISearchable<T> where T : class, ITableRecord
    {
        public IQueryable<T> SearchByProperty(DbSet<T> tableToSearch, IProperty property, object paramToSearch);
    }
}
