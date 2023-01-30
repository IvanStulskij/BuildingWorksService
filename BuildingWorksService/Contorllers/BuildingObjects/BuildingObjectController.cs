using BuildingWorks.Models.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;
using Models.Resources.BuildingObject;
using Models.Resources.Providers;

namespace BuildingWorksService.Contorllers.BuildingObjects
{
    [ApiController]
    [Route("/api/building-objects")]
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
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var buildingObject = await _service.GetById(id);

            return Ok(buildingObject);
        }

        /// <summary>
        /// Get all building-objects.
        /// </summary>
        /// <returns> The list of building-objects. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BuildingObjectResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var buildingObjects = await _service.GetAll();

            return Ok(buildingObjects);
        }

        /// <summary>
        /// Create building-object.
        /// </summary>
        /// <param name="form"> Form to create building object. </param>
        /// <returns> Created building-object. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] BuildingObjectForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete building-object by id.
        /// </summary>
        /// <param name="id"> Id to delete building-object. </param>
        /// <returns> Deleted building-object. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BuildingObjectResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);

            return Ok(response);
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
            var response = await _service.Update(resource.Id, resource);
            return Ok(response);
        }
    }
}
