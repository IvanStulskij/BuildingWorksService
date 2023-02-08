using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/addresses")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get address by id.
        /// </summary>
        /// <param name="id"> Id to get address. </param>
        /// <returns> Single address. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var address = await _service.GetById(id);

            return Ok(address);
        }

        /// <summary>
        /// Get all addresses.
        /// </summary>
        /// <returns> The list of addresses. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AddressResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var addresses = await _service.GetAll();

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
            var address = _service.GetByPosition(regionName, townName, streetName);

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
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete address by id.
        /// </summary>
        /// <param name="id"> Id to delete address. </param>
        /// <returns> Deleted address. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(AddressResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);

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
            var response = await _service.Update(resource.Id, resource);
            return Ok(response);
        }
    }
}
