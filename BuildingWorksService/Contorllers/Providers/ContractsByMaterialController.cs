using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Models.Services.Interfaces.Providers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Providers
{
    [ApiController]
    [Route("api/materials-price")]
    public class ContractsByMaterialController : ControllerBase
    {
        private readonly IContractsByMaterialService _service;

        public ContractsByMaterialController(IContractsByMaterialService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get contracts-by-material by id.
        /// </summary>
        /// <param name="id"> Id to get material. </param>
        /// <returns> Single material. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ContractsByMaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var entitiy = await _service.GetById(id);

            return Ok(entitiy);
        }

        /// <summary>
        /// Get all contracts-by-material.
        /// </summary>
        /// <returns> The list of contracts-by-material. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ContractsByMaterialResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAll();

            return Ok(entities);
        }

        /// <summary>
        /// Get contracts-by-material
        /// </summary>
        /// <param name="objectId"> Object id to get contracts-by-material. </param>
        /// <returns> The list of contracts-by-material. </returns>
        [HttpGet("getMaterialsContracts")]
        [ProducesResponseType(typeof(IEnumerable<ContractsByMaterialResource>), StatusCodes.Status200OK)]
        public IActionResult GetMaterialsContracts([FromQuery] int objectId)
        {
            var entities = _service.GetMaterialsContracts(objectId);
            return Ok(entities);
        }

        [HttpGet("getMaterialsPrice")]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        public IActionResult GetMaterialsPrice([FromQuery] int objectId)
        {
            var price = _service.GetMaterialPrice(objectId);
            return Ok(price);
        }

        /// <summary>
        /// Create contracts-by-material.
        /// </summary>
        /// <param name="form"> Form to create material. </param>
        /// <returns> Created material. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(ContractsByMaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] ContractsByMaterialForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete contracts-by-material by id.
        /// </summary>
        /// <param name="id"> Id to delete contracts-by-material. </param>
        /// <returns> Deleted material. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(IEnumerable<ContractsByMaterialResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
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
        [ProducesResponseType(typeof(ContractsByMaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] ContractsByMaterialResource resource)
        {
            var response = await _service.Update(resource.Id, resource);
            return Ok(response);
        }
    }
}
