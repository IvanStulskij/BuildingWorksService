﻿using BuildingWorks.Common.Extensions;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("/api/v1/workers")]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _service;
        private readonly ILogger _logger;

        public WorkerController(IWorkerService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get worker by id.
        /// </summary>
        /// <param name="id"> Id to get worker. </param>
        /// <returns> Single worker. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var worker = await _service.GetById(id);

            if (worker == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(worker);
        }

        /// <summary>
        /// Get all workers overview.
        /// </summary>
        /// <returns> The list of workers. </returns>
        [HttpGet("overview")]
        [ProducesResponseType(typeof(IEnumerable<WorkerOverview>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOverview([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<WorkerOverview> workers = await _service.GetAllOverview(pagination);

            if (workers == null || !workers.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(workers);
        }

        /// <summary>
        /// Get all workers.
        /// </summary>
        /// <returns> The list of workers. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<WorkerResource> workers = await _service.GetAll(pagination);

            if (workers == null || !workers.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(workers);
        }

        /// <summary>
        /// Get workers by brigade id.
        /// </summary>
        /// <param name="brigadeCode"> BrigadeId id to get workers. </param>
        /// <returns> The list of workers by brigade. </returns>
        [HttpGet("getByBrigade")]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public IActionResult GetByBrigade([FromRoute] PaginationParameters pagination, [FromQuery] int brigadeCode)
        {
            IEnumerable<WorkerResource> workers = _service.GetByBrigade(pagination, brigadeCode);

            if (workers == null || !workers.Any())
            {
                return NotFound("There are no workers for those brigade");
            }

            return Ok(workers);
        }

        /// <summary>
        /// Get workers by condition.
        /// </summary>
        /// <param name="condition"> Condition id to get workers. </param>
        /// <returns> The list of workers by condition. </returns>
        [HttpGet("getByCondition")]
        [ProducesResponseType(typeof(IEnumerable<WorkerResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByCondition([FromBody] Condition condition)
        {
            IEnumerable<WorkerResource> workers = await _service.GetByCondition(condition, TablesNames.WorkersTableName);

            if (workers == null || !workers.Any())
            {
                _logger.LogWarning("There are no workers for those condition");

                return NotFound();
            }

            return Ok(workers);
        }

        /// <summary>
        /// Create worker.
        /// </summary>
        /// <param name="worker"> Worker form to create worker. </param>
        /// <returns> Created worker. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
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
        [ProducesResponseType(typeof(List<WorkerResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
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
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] WorkerResource provider)
        {
            var response = await _service.Update(provider);
            return Ok(response);
        }
    }
}
