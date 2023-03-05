using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Services.Interfaces.Plans;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BuildingWorksService.Contorllers.Plans
{
    [ApiController]
    [Route("/api/plans")]
    public sealed class PlanController : ControllerBase
    {
        private readonly IPlanService _service;

        public PlanController(IPlanService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get plan by id.
        /// </summary>
        /// <param name="id"> Id to get plan. </param>
        /// <returns> Single plan. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PlanResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var activity = await _service.GetById(id);
            return Ok(activity);
        }

        /// <summary>
        /// Get all plans.
        /// </summary>
        /// <returns> The list of all plans. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<PlanResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();
            return Ok(response);
        }

        /// <summary>
        /// Get properties names.
        /// </summary>
        /// <returns> The list of plan entity properties names. </returns>
        [HttpGet("getPropertiesNames")]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPropertiesNames()
        {
            var response = await _service.GetPropertiesNames();
            return Ok(response);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns> The list of plans by condition </returns>
        [HttpGet("getByCondition")]
        [ProducesResponseType(typeof(List<Plan>), StatusCodes.Status200OK)]
        public IActionResult GetByCondition([FromQuery] Condition condition)
        {
            var response = _service.GetByCondition(condition, TablesNames.PlansName);
            return Ok(response);
        }

        /// <summary>
        /// Create plan.
        /// </summary>
        /// <param name="plan"> Plan form to create plan. </param>
        /// <returns> Created plan. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(PlanResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] PlanForm resource)
        {
            var response = await _service.Create(resource);
            return Ok(response);
        }

        /// <summary>
        /// Delete plan by id.
        /// </summary>
        /// <param name="id"> Id to delete plan. </param>
        /// <returns> Deleted plan. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(PlanResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        /// <summary>
        /// Update plan.
        /// </summary>
        /// <param name="resource"> Plan resource to update plan. </param>
        /// <returns> Updated plan. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(PlanResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] PlanResource resource)
        {
            var response = await _service.Update(resource);
            return Ok(response);
        }
    }
}
