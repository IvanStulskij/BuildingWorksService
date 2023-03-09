using BuildingWorks.Models;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/streets")]
    public class StreetController : ControllerBase
    {
        private readonly IStreetService _service;

        public StreetController(IStreetService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get street by id.
        /// </summary>
        /// <param name="id"> Id to get street. </param>
        /// <returns> Single street. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            StreetResource street = await _service.GetById(id);

            if (street == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(street);
        }

        /// <summary>
        /// Get all streets.
        /// </summary>
        /// <returns> The list of streets. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StreetResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<StreetResource> streets = await _service.GetAll(pagination);

            return Ok(streets);
        }

        /// <summary>
        /// Create street.
        /// </summary>
        /// <param name="form"> Form to create street. </param>
        /// <returns> Created street. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] StreetForm form)
        {
            StreetResource response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete street by id.
        /// </summary>
        /// <param name="id"> Id to delete street. </param>
        /// <returns> Deleted street. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            StreetResource response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update street.
        /// </summary>
        /// <param name="resource"> Resource to update street. </param>
        /// <returns> Updated street. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] StreetResource resource)
        {
            StreetResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
