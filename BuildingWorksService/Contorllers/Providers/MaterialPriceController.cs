using BuildingWorks.Models;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Services.Interfaces.Providers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Providers
{
    [ApiController]
    [Route("/api/v1/materials-price")]
    public class MaterialPriceController : ControllerBase
    {
        private readonly IMaterialsPriceService _service;

        public MaterialPriceController(IMaterialsPriceService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get contracts-by-material by id.
        /// </summary>
        /// <param name="id"> Id to get material. </param>
        /// <returns> Single material. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MaterialsPriceResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            MaterialsPriceResource price = await _service.GetById(id);

            if (price == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(price);
        }

        /// <summary>
        /// Get all contracts-by-material.
        /// </summary>
        /// <returns> The list of contracts-by-material. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MaterialsPriceResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<MaterialsPriceResource> prices = await _service.GetAll(pagination);

            if (prices == null || !prices.Any())
            {
                return NotFound(ExceptionMessages.NoEntitiesInDb);
            }

            return Ok(prices);
        }

        /// <summary>
        /// Get contracts-by-material
        /// </summary>
        /// <param name="objectId"> Object id to get contracts-by-material. </param>
        /// <returns> The list of contracts-by-material. </returns>
        [HttpGet("getByObject")]
        [ProducesResponseType(typeof(IEnumerable<MaterialsPriceForm>), StatusCodes.Status200OK)]
        public IActionResult GetByObject([FromQuery] int objectId)
        {
            IEnumerable<MaterialsPriceForm> prices = _service.GetByObject(objectId);

            return Ok(prices);
        }

        [HttpGet("countPrice")]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        public IActionResult CountPrice([FromQuery] int objectId)
        {
            var price = _service.CountPrice(objectId);
            return Ok(price);
        }

        /// <summary>
        /// Create contracts-by-material.
        /// </summary>
        /// <param name="form"> Form to create material. </param>
        /// <returns> Created material. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(MaterialsPriceResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] MaterialsPriceForm form)
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
        [ProducesResponseType(typeof(IEnumerable<MaterialsPriceResource>), StatusCodes.Status200OK)]
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
        [ProducesResponseType(typeof(MaterialsPriceResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] MaterialsPriceResource resource)
        {
            var response = await _service.Update(resource);
            return Ok(response);
        }
    }
}
