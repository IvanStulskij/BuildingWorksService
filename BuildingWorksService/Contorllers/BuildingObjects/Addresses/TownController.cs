using BuildingWorks.Models;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/v1/towns")]
    public class TownController : ControllerBase
    {
        private readonly ITownService _service;
        private readonly ILogger _logger;

        public TownController(ITownService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
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
            TownResource town = await _service.GetById(id);

            if (town == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(town);
        }

        /// <summary>
        /// Get all towns.
        /// </summary>
        /// <returns> The list of towns. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<TownResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<TownResource> towns = await _service.GetAll(pagination);

            if (towns == null || !towns.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

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
            TownResource response = await _service.Create(form);

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
            TownResource response = await _service.Delete(id);

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
            TownResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
