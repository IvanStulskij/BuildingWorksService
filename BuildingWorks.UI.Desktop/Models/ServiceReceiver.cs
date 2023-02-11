using BuildingWorks.Common.Extensions;
using BuildingWorks.GlobalConstants;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BuildingWorks.Models
{
    public abstract class ServiceReceiver<T, TResource> where TResource : IResource
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly string _tableName;
        private readonly string _baseRequest;

        public ServiceReceiver()
        {
            _baseRequest = RequestsConstants.BaseRequest + _tableName;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var response = await _client.GetStringAsync(_baseRequest);
            
            return JsonConvert.DeserializeObject<IEnumerable<T>>(response);
        }

        public async void Create(TResource entity)
        {
            await _client.PostAsJsonAsync(_baseRequest, entity);
        }

        public void Update(TResource entity)
        {
            _client.PutAsJsonAsync(_baseRequest, entity);
        }

        public async void Delete(int id)
        {
            await _client.DeleteAsync($"{_baseRequest}/{id}");
        }
    }
}
