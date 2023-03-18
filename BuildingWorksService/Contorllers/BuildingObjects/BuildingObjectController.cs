using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects
{
    [ApiController]
    [Route("/api/v1/building-objects")]
    public class BuildingObjectController : ControllerBase
    {
        private readonly IBuildingObjectService _service;

        public BuildingObjectController(IBuildingObjectService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get building-object by id.
        /// </summary>
        /// <param name="id"> Id to get provider. </param>
        /// <returns> Single provider. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BuildingObjectResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            BuildingObjectResource buildingObject = await _service.GetById(id);

            if (buildingObject == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(buildingObject);
        }

        /// <summary>
        /// Get all building-objects.
        /// </summary>
        /// <returns> The list of building-objects. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BuildingObjectResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<BuildingObjectResource> buildingObjects = await _service.GetAll(pagination);

            if (buildingObjects == null || !buildingObjects.Any())
            {
                return NotFound(ExceptionMessages.NoEntitiesInDb);
            }

            return Ok(buildingObjects);
        }

        /// <summary>
        /// Get all building-objects overview.
        /// </summary>
        /// <returns> The list of building-objects. </returns>
        [HttpGet("overview")]
        [ProducesResponseType(typeof(IEnumerable<BuildingObjectResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOverview([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<BuildingObjectOverview> buildingObjects = await _service.GetAllOverview(pagination);

            if (buildingObjects == null || !buildingObjects.Any())
            {
                return NotFound(ExceptionMessages.NoEntitiesInDb);
            }

            return Ok(buildingObjects);
        }

        /// <summary>
        /// Create building-object.
        /// </summary>
        /// <param name="form"> Form to create building object. </param>
        /// <returns> Created building-object. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(BuildingObjectResource), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] BuildingObjectForm form)
        {
            BuildingObjectResource buildingObject = await _service.Create(form);

            return Ok(buildingObject);
        }

        /// <summary>
        /// Delete building-object by id.
        /// </summary>
        /// <param name="id"> Id to delete building-object. </param>
        /// <returns> Deleted building-object. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BuildingObjectResource), StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            BuildingObjectResource buildingObject = await _service.Delete(id);

            return Ok(buildingObject);
        }

        /// <summary>
        /// Update building-object.
        /// </summary>
        /// <param name="resource"> Resource to update building-object. </param>
        /// <returns> Updated building-object. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BuildingObjectResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] BuildingObjectResource resource)
        {
            BuildingObjectResource buildingObject = await _service.Update(resource);

            return Ok(buildingObject);
        }
    }
}
