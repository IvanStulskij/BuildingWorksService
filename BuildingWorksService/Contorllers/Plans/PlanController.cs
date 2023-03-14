using BuildingWorks.Common.Extensions;
using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.BuildingObject;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Services.Interfaces.Plans;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BuildingWorksService.Contorllers.Plans
{
    [ApiController]
    [Route("/api/v1/plans")]
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
            PlanResource plan = await _service.GetById(id);

            if (plan == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(plan);
        }

        /// <summary>
        /// Get all plans.
        /// </summary>
        /// <returns> The list of all plans. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PlanResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<PlanResource> plans = await _service.GetAll(pagination);

            return Ok(plans);
        }

        /// <summary>
        /// Get all plans overview.
        /// </summary>
        /// <returns> The list of plans. </returns>
        [HttpGet("overview")]
        [ProducesResponseType(typeof(IEnumerable<PlanOverview>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOverview([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<PlanOverview> plans = await _service.GetAllOverview(pagination);

            return Ok(plans);
        }

        /// <summary>
        /// Get properties names.
        /// </summary>
        /// <returns> The list of plan entity properties names. </returns>
        [HttpGet("getPropertiesNames")]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPropertiesNames()
        {
            IEnumerable<string> propertiesNames = await _service.GetPropertiesNames();

            return Ok(propertiesNames);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns> The list of plans by condition </returns>
        [HttpGet("getByCondition")]
        [ProducesResponseType(typeof(List<Plan>), StatusCodes.Status200OK)]
        public IActionResult GetByCondition([FromQuery] Condition condition)
        {
            IEnumerable<Plan> plans = _service.GetByCondition(condition, TablesNames.PlansName);

            if (plans == null || !plans.Any())
            {
                return NotFound(ExceptionMessages.EntityByConditionNotExists);
            }

            return Ok(plans);
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
            PlanResource plan = await _service.Create(resource);

            return Ok(plan);
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
            PlanResource plan = await _service.Delete(id);

            return Ok(plan);
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
            PlanResource response = await _service.Update(resource);

            return Ok(response);
        }
    }
}
