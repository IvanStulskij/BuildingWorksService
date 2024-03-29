﻿using BuildingWorks.Models;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("/api/v1/workers-salaries")]
    public class WorkerSalaryController : ControllerBase
    {
        private readonly IWorkerSalaryService _service;
        private readonly ILogger _logger;

        public WorkerSalaryController(IWorkerSalaryService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get worker-salary by id.
        /// </summary>
        /// <param name="id"> Id to get worker-salary. </param>
        /// <returns> Single worker-salary. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            WorkerSalaryResource workerSalary = await _service.GetById(id);

            if (workerSalary == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(workerSalary);
        }

        /// <summary>
        /// Get all workers-salaries.
        /// </summary>
        /// <returns> The list of workers-salaries. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WorkerSalaryResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<WorkerSalaryResource> salaries = await _service.GetAll(pagination);

            return Ok(salaries);
        }

        /// <summary>
        /// Get building object total salaries amount.
        /// </summary>
        /// <param name="objectId"> Id to get workers-salaries. </param>
        /// <returns> The list of workers-salaries. </returns>
        [HttpGet("getTotalByObject")]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        public IActionResult GetTotalByObject([FromQuery] int objectId)
        {
            float totalSalariesAmount = _service.GetTotalBAmountByObject(objectId);

            return Ok(totalSalariesAmount);
        }

        /// <summary>
        /// Create worker-salary.
        /// </summary>
        /// <param name="form"> Form to create worker-salary. </param>
        /// <returns> Created worker-salary. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] WorkerSalaryForm form)
        {
            WorkerSalaryResource response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete worker-salary by id.
        /// </summary>
        /// <param name="id"> Id to delete worker-salary. </param>
        /// <returns> Deleted worker-salary. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            WorkerSalaryResource response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update worker-salary.
        /// </summary>
        /// <param name="resource"> Resource to create provider. </param>
        /// <returns> Updated provider. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] WorkerSalaryResource resource)
        {
            WorkerSalaryResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
