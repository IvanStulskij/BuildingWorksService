using Microsoft.AspNetCore.Mvc;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Services.Interfaces.Providers;
using BuildingWorks.Models;

namespace BuildingWorksService.Contorllers.Providers
{
    [ApiController]
    [Route("/api/providers")]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _service;

        public ProviderController(IProviderService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get provider by id.
        /// </summary>
        /// <param name="id"> Id to get provider. </param>
        /// <returns> Single provider. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var provider = await _service.GetById(id);

            if (provider == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(provider);
        }

        /// <summary>
        /// Get all providers.
        /// </summary>
        /// <returns> The list of providers. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProviderResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            var providers = await _service.GetAll(pagination);

            return Ok(providers);
        }

        /// <summary>
        /// Create provider.
        /// </summary>
        /// <param name="provider"> Provider to create. </param>
        /// <returns> Created provider. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] ProviderForm provider)
        {
            var response = await _service.Create(provider);

            return Ok(response);
        }

        /// <summary>
        /// Delete provider by id.
        /// </summary>
        /// <param name="id"> Id to delete provider. </param>
        /// <returns> Deleted provider. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(List<ProviderResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        /// <summary>
        /// Update provider.
        /// </summary>
        /// <param name="provider"> Resource to create provider. </param>
        /// <returns> Updated provider. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] ProviderResource provider)
        {
            var response = await _service.Update(provider);
            return Ok(response);
        }
    }
}
