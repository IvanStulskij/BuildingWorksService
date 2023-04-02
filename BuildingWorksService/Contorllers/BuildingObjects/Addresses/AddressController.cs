using BuildingWorks.Models;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/v1/addresses")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;
        private readonly ILogger _logger;

        public AddressController(IAddressService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get address by id.
        /// </summary>
        /// <param name="id"> Id to get address. </param>
        /// <returns> Single address. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            AddressResource address = await _service.GetById(id);

            if (address == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(address);
        }

        /// <summary>
        /// Get all addresses.
        /// </summary>
        /// <returns> The list of addresses. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AddressResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<AddressResource> addresses = await _service.GetAll(pagination);

            if (addresses == null || !addresses.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(addresses);
        }

        /// <summary>
        /// Get by position.
        /// </summary>
        /// <returns> The list of addresses. </returns>
        [HttpGet("getByPosition")]
        [ProducesResponseType(typeof(IEnumerable<AddressResource>), StatusCodes.Status200OK)]
        public IActionResult GetByPosition([FromQuery] string regionName, string townName, string streetName)
        {
            AddressResource address = _service.GetByPosition(regionName, townName, streetName);

            if (address == null)
            {
                _logger.LogWarning("Entity with such params does't exist");
                return NotFound();
            }

            return Ok(address);
        }

        /// <summary>
        /// Create address.
        /// </summary>
        /// <param name="form"> Form to create address. </param>
        /// <returns> Created address. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] AddressForm form)
        {
            AddressResource response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete address by id.
        /// </summary>
        /// <param name="id"> Id to delete address. </param>
        /// <returns> Deleted address. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            AddressResource response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update address.
        /// </summary>
        /// <param name="resource"> Resource to update address. </param>
        /// <returns> Updated address. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] AddressResource resource)
        {
            AddressResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
