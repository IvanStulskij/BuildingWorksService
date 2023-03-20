using BuildingWorks.Models;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services
{
    public interface IService<TForm, TResource>
    {
        Task<IEnumerable<TForm>> GetAll(PaginationParameters pagination);

        Task<TResource> GetById(int id);

        Task Create(TForm entity);

        Task Delete(int id);

        Task Update(TResource entity);
    }

    public interface IOverviewService<TForm, TResource, TOverview> : IService<TForm, TResource>
    {
        Task<IEnumerable<TOverview>> GetAllOverview(PaginationParameters pagination);
    }
}
