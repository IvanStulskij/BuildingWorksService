using BuildingWorks.Models;
using System.Net.Http.Json;

namespace BuildingWorks.UI.BlazorWebAssembly.Client.Services
{
    public abstract class Service<TForm, TResource> : IService<TForm, TResource>
    {
        private readonly HttpClient _http;
        private readonly string _entity;
        
        public Service(HttpClient http, string entity)
        {
            _http = http;
            _entity = entity;
        }

        protected string Path => $"{_http.BaseAddress.AbsolutePath}{_entity}";

        public async Task<IEnumerable<TForm>> GetAll(PaginationParameters pagination)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<TForm>>($"{_entity}?EntitesPerPage={pagination.EntitiesPerPage}&CurrentPage={pagination.CurrentPage}");

            if (entities == null)
            {
                throw new Exception("No entities");
            }

            return entities;
        }

        public async Task Create(TForm entity)
        {
            await _http.PostAsJsonAsync(_entity, entity);
        }

        public async Task Delete(int id)
        {
            await _http.DeleteAsync($"{_entity}/{id}");
        }

        public async Task Update(TResource entity)
        {
            await _http.PutAsJsonAsync($"{_entity}", entity);
        }
    }

    public abstract class OverviewService<TForm, TResource, TOverivew> : Service<TForm, TResource>, IOverviewService<TForm, TResource, TOverivew>
    {
        private readonly HttpClient _http;
        private readonly string _entity;

        public OverviewService(HttpClient http, string entity) : base(http, entity)
        {
            _http = http;
            _entity = entity;
        }

        public async Task<IEnumerable<TOverivew>> GetAllOverview(PaginationParameters pagination)
        {
            var entities = await _http.GetFromJsonAsync<IEnumerable<TOverivew>>($"{_entity}/overview?EntitiesPerPage={pagination.EntitiesPerPage}&CurrentPage={pagination.CurrentPage}");

            if (entities == null)
            {
                throw new Exception("No entities");
            }

            return entities;
        }
    }
}
