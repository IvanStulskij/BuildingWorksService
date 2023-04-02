using BuildingWorks.Common.Extensions;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using Models;

namespace BuildingWorks.Services.Interfaces
{
    public interface IService<TResource, TResourceForm> where TResource : class, IResource
    {
        Task<IEnumerable<TResource>> GetAll(PaginationParameters pagination);

        Task<TResource> GetById(int id);

        Task<TResource> Create(TResourceForm form);

        Task<TResource> Update(TResource resource);

        Task<TResource> Delete(int id);
    }

    public interface IOverviewService<TResource, TResourceForm, TOverview> : IService<TResource, TResourceForm>
        where TResource : class, IResource
        where TOverview: Overview
    {
        Task<IEnumerable<TOverview>> GetAllOverview(PaginationParameters pagination);
    }

    public interface IConditionalService<T, TResource, TForm> : IService<TResource, TForm>
        where TResource : class, IResource
    {
        Task<IEnumerable<TResource>> GetByCondition(Condition condition, string tableName);
    }
}