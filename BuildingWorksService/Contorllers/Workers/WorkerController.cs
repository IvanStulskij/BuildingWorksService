using BuildingWorks.Models.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Resources.Providers;
using Models.Resources.Workers;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("/api/workers")]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _service;

        public WorkerController(IWorkerService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get worker by id.
        /// </summary>
        /// <param name="id"> Id to get worker. </param>
        /// <returns> Single worker. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var worker = await _service.GetById(id);

            return Ok(worker);
        }

        /// <summary>
        /// Get all workers.
        /// </summary>
        /// <returns> The list of workers. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var workers = await _service.GetAll();

            return Ok(workers);
        }

        /// <summary>
        /// Get workers by brigade id.
        /// </summary>
        /// <param name="brigadeCode"> Brigade id to get workers. </param>
        /// <returns> The list of workers by brigade. </returns>
        [HttpGet("getByBrigade")]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public IActionResult GetByBrigade([FromQuery] int brigadeCode)
        {
            var workers = _service.GetByBrigade(brigadeCode);
            return Ok(workers);
        }

        /// <summary>
        /// Get workers by condition.
        /// </summary>
        /// <param name="condition"> Condition id to get workers. </param>
        /// <returns> The list of workers by condition. </returns>
        [HttpGet("getByCondition")]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public IActionResult GetByCondition([FromBody] Condition condition)
        {
            var workers = _service.GetByCondition(condition);
            return Ok(workers);
        }

        /// <summary>
        /// Create worker.
        /// </summary>
        /// <param name="worker"> Worker form to create worker. </param>
        /// <returns> Created worker. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] WorkerForm worker)
        {
            var response = await _service.Create(worker);

            return Ok(response);
        }

        /// <summary>
        /// Delete worker by id.
        /// </summary>
        /// <param name="id"> Id to delete worker. </param>
        /// <returns> Deleted worker. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(List<ProviderResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        /// <summary>
        /// Update worker.
        /// </summary>
        /// <param name="provider"> Resource to create worker. </param>
        /// <returns> Updated worker. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(ProviderResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] WorkerResource provider)
        {
            var response = await _service.Update(provider.Id, provider);
            return Ok(response);
        }
    }
}
