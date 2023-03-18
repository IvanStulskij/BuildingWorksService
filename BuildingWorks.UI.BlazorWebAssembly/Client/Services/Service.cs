using BuildingWorks.Models;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services
{
    public abstract class Service<TForm, TResource> : IService<TForm, TResource>
    {
        private readonly HttpClient _http;
        private readonly string _entityPath;

        public Service(HttpClient http, string entityPath)
        {
            _http = http;
            _entityPath = entityPath;
        }

        public async Task<IEnumerable<TForm>> GetAll(PaginationParameters pagination)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<TForm>>($"{_entityPath}?EntitesPerPage={pagination.EntitiesPerPage}&CurrentPage={pagination.CurrentPage}");

            if (entities == null)
            {
                throw new Exception("No entities");
            }

            return entities;
        }

        public async Task Create(TForm entity)
        {
            await _http.PostAsJsonAsync(_entityPath, entity);
        }

        public async Task Delete(int id)
        {
            await _http.DeleteAsync($"{_entityPath}/{id}");
        }

        public async Task Update(TResource entity)
        {
            await _http.PutAsJsonAsync($"{_entityPath}", entity);
        }
    }

    public abstract class OverviewService<TForm, TResource, TOverivew> : Service<TForm, TResource>, IOverviewService<TForm, TResource, TOverivew>
    {
        private readonly string _entityPath;
        private readonly HttpClient _http;

        public OverviewService(HttpClient http, string entityPath) : base(http, entityPath)
        {
            _entityPath = entityPath;
            _http = http;
        }

        public async Task<IEnumerable<TOverivew>> GetAllOverview(PaginationParameters pagination)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<TOverivew>>($"{_entityPath}/overview?EntitiesPerPage={pagination.EntitiesPerPage}&CurrentPage={pagination.CurrentPage}");

            if (entities == null)
            {
                throw new Exception("No entities");
            }

            return entities;
        }
    }
}
