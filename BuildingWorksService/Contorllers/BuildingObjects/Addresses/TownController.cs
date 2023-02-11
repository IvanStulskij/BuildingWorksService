using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/towns")]
    public class TownController : ControllerBase
    {
        private readonly ITownService _service;

        public TownController(ITownService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get town by id.
        /// </summary>
        /// <param name="id"> Id to get town. </param>
        /// <returns> Single town. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TownResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var town = await _service.GetById(id);

            return Ok(town);
        }

        /// <summary>
        /// Get all towns.
        /// </summary>
        /// <returns> The list of towns. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<TownResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var towns = await _service.GetAll();

            return Ok(towns);
        }

        /// <summary>
        /// Create town.
        /// </summary>
        /// <param name="form"> Form to create town. </param>
        /// <returns> Created town. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(TownResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] TownForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete town by id.
        /// </summary>
        /// <param name="id"> Id to delete town. </param>
        /// <returns> Deleted town. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(TownResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update town.
        /// </summary>
        /// <param name="resource"> Resource to update town. </param>
        /// <returns> Updated town. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(TownResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] TownResource resource)
        {
            var response = await _service.Update(resource.Id, resource);

            return Ok(response);
        }
    }
}
