using BuildingWorks.Models;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("/api/v1/brigades")]
    public class BrigadeController : ControllerBase
    {
        private readonly IBrigadeService _service;
        private readonly ILogger _logger;

        public BrigadeController(IBrigadeService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get brigade by id.
        /// </summary>
        /// <param name="id"> Id to get brigade. </param>
        /// <returns> Single brigade. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            BrigadeResource brigade = await _service.GetById(id);

            if (brigade == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(brigade);
        }

        /// <summary>
        /// Get all brigades.
        /// </summary>
        /// <returns> The list of brigades. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<BrigadeResource> brigades = await _service.GetAll(pagination);

            if (brigades == null || !brigades.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(brigades);
        }

        /// <summary>
        /// Get brigades by building-object.
        /// </summary>
        /// <param name="objectId"> Object id to get brigades. </param>
        /// <returns> The list of brigades. </returns>
        [HttpGet("getByObject")]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public IActionResult GetByObject([FromQuery] int objectId)
        {
            IEnumerable<BrigadeResource> brigades = _service.GetByObject(objectId);

            if (brigades == null || !brigades.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(brigades);
        }

        /// <summary>
        /// Get brigades codes.
        /// </summary>
        /// <returns> The list of brigades codes. </returns>
        [HttpGet("getCodes")]
        [ProducesResponseType(typeof(IEnumerable<int>), StatusCodes.Status200OK)]
        public IActionResult GetCodes([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<int> codes = _service.GetCodes(pagination);

            return Ok(codes);
        }

        /// <summary>
        /// Create brigade.
        /// </summary>
        /// <param name="form"> BrigadeId form to create brigade. </param>
        /// <returns> Created brigade. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] BrigadeForm form)
        {
            BrigadeResource brigade = await _service.Create(form);

            return Ok(brigade);
        }

        /// <summary>
        /// Delete brigade by id.
        /// </summary>
        /// <param name="id"> Id to delete brigade. </param>
        /// <returns> Deleted brigade. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            BrigadeResource brigade = await _service.Delete(id);

            return Ok(brigade);
        }

        /// <summary>
        /// Updated brigade.
        /// </summary>
        /// <param name="brigade"> Resource to create brigade. </param>
        /// <returns> Updated brigade. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] BrigadeResource brigade)
        {
            BrigadeResource response = await _service.Update(brigade);

            return Ok(response);
        }
    }
}
