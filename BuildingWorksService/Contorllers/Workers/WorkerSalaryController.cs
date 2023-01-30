using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;
using Models.Resources.Providers;
using Models.Resources.Workers;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("/api/workers-salaries")]
    public class WorkerSalaryController : ControllerBase
    {
        private readonly IWorkerSalaryService _service;

        public WorkerSalaryController(IWorkerSalaryService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get worker-salary by id.
        /// </summary>
        /// <param name="id"> Id to get worker-salary. </param>
        /// <returns> Single worker-salary. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var workerSalary = await _service.GetById(id);

            return Ok(workerSalary);
        }

        /// <summary>
        /// Get all workers-salaries.
        /// </summary>
        /// <returns> The list of workers-salaries. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WorkerSalaryResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var salaries = await _service.GetAll();

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
            var totalSalariesAmount = _service.GetTotalByObject(objectId);

            return Ok(totalSalariesAmount);
        }

        /// <summary>
        /// Create worker-salary.
        /// </summary>
        /// <param name="form"> Form to create worker-salary. </param>
        /// <returns> Created worker-salary. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(WorkerSalary), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] WorkerSalaryForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete worker-salary by id.
        /// </summary>
        /// <param name="id"> Id to delete worker-salary. </param>
        /// <returns> Deleted worker-salary. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(WorkerSalaryResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);

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
            var response = await _service.Update(resource.Id, resource);

            return Ok(response);
        }
    }
}
