using BuildingWorks.Models;
using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/v1/regions")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _service;
        private readonly ILogger _logger;

        public RegionController(IRegionService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get region by id.
        /// </summary>
        /// <param name="id"> Id to get region. </param>
        /// <returns> Single region. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            RegionResource region = await _service.GetById(id);

            if (region == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(region);
        }

        /// <summary>
        /// Get all regions.
        /// </summary>
        /// <returns> The list of regions. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RegionResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll(PaginationParameters pagination)
        {
            IEnumerable<RegionResource> regions = await _service.GetAll(pagination);

            if (regions == null || !regions.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(regions);
        }

        /// <summary>
        /// Create region.
        /// </summary>
        /// <param name="form"> Form to create region. </param>
        /// <returns> Created region. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] RegionForm form)
        {
            RegionResource region = await _service.Create(form);

            return Ok(region);
        }

        /// <summary>
        /// Delete region by id.
        /// </summary>
        /// <param name="id"> Id to delete region. </param>
        /// <returns> Deleted region. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            RegionResource response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update region.
        /// </summary>
        /// <param name="resource"> Resource to update region. </param>
        /// <returns> Updated region. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] RegionResource resource)
        {
            RegionResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
