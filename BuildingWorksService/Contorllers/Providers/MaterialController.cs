using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Services.Interfaces.Providers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Providers
{
    [ApiController]
    [Route("/api/materials")]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _service;

        public MaterialController(IMaterialService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get material by id.
        /// </summary>
        /// <param name="id"> Id to get material. </param>
        /// <returns> Single material. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var activity = await _service.GetById(id);

            return Ok(activity);
        }

        /// <summary>
        /// Get all materials.
        /// </summary>
        /// <returns> The list of materials. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MaterialResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var providers = await _service.GetAll();

            return Ok(providers);
        }

        /// <summary>
        /// Create material.
        /// </summary>
        /// <param name="form"> Form to create material. </param>
        /// <returns> Created material. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] MaterialForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete material by id.
        /// </summary>
        /// <param name="id"> Id to delete form. </param>
        /// <returns> Deleted material. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        /// <summary>
        /// Update material.
        /// </summary>
        /// <param name="resource"> Resource to update material. </param>
        /// <returns> Updated form. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] MaterialResource resource)
        {
            var response = await _service.Update(resource.Id, resource);
            return Ok(response);
        }
    }
}
