using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;
using Models.Resources.BuildingObject.Addresses;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/regions")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _service;

        public RegionController(IRegionService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get region by id.
        /// </summary>
        /// <param name="id"> Id to get region. </param>
        /// <returns> Single region. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var region = await _service.GetById(id);

            return Ok(region);
        }

        /// <summary>
        /// Get all regions.
        /// </summary>
        /// <returns> The list of regions. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RegionResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var regions = await _service.GetAll();

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
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete region by id.
        /// </summary>
        /// <param name="id"> Id to delete region. </param>
        /// <returns> Deleted region. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(RegionResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);

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
            var response = await _service.Update(resource.Id, resource);

            return Ok(response);
        }
    }
}
