using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Services.Interfaces.Plans;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Plans
{
    [ApiController]
    [Route("/api/v1/plan-details")]
    public class PlanDetailController : ControllerBase
    {
        private readonly IPlanDetailsService _service;
        private readonly ILogger _logger;

        public PlanDetailController(IPlanDetailsService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get plan-detail by id.
        /// </summary>
        /// <param name="id"> Id to get plan-detail. </param>
        /// <returns> Single plan-detail. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PlanDetailResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            PlanDetailResource planDetail = await _service.GetById(id);

            if (planDetail == null)
            {
                _logger.LogWarning(ExceptionMessages.EntityByIdNotExists);

                return NotFound();
            }

            return Ok(planDetail);
        }

        /// <summary>
        /// Get all plan-details.
        /// </summary>
        /// <returns> The list of all plan-details. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PlanDetailResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<PlanDetailResource> planDetails = await _service.GetAll(pagination);

            if (planDetails == null || !planDetails.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(planDetails);
        }

        /// <summary>
        /// Get all plan-details overview.
        /// </summary>
        /// <returns> The list of plan-details. </returns>
        [HttpGet("overview")]
        [ProducesResponseType(typeof(IEnumerable<PlanDetailOverview>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOverview([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<PlanDetailOverview> planDetails = await _service.GetAllOverview(pagination);

            if (planDetails == null || !planDetails.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(planDetails);
        }

        /// <summary>
        /// Count done percent by plan.
        /// </summary>
        /// <param name="planId"> Plan id to count done percent. </param>
        /// <returns> Done percent of plan. </returns>
        [HttpGet("countDonePercent")]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        public async Task<IActionResult> CountDonePercent([FromQuery] int planId)
        {
            float donePercent = await _service.CountDonePercent(planId);

            return Ok(donePercent);
        }

        /// <summary>
        /// Get plan-details by plan.
        /// </summary>
        /// <param name="planId"> Plan id to get plan-details. </param>
        /// <returns> The list of plan-details. </returns>
        [HttpGet("getByPlan")]
        [ProducesResponseType(typeof(IEnumerable<PlanDetail>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByPlan([FromQuery] int planId)
        {
            IEnumerable<PlanDetail> planDetails = await _service.GetByPlan(planId);

            if (planDetails == null || !planDetails.Any())
            {
                _logger.LogWarning(ExceptionMessages.NoEntitiesInDb);

                return NotFound();
            }

            return Ok(planDetails);
        }

        /// <summary>
        /// Get completed plan-details.
        /// </summary>
        /// <param name="planDetails"> The list of all plan-details. </param>
        /// <returns> The list of completed plan-details. </returns>
        [HttpPost("getCompleted")]
        [ProducesResponseType(typeof(PlanDetail), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompleted([FromBody] IEnumerable<PlanDetail> planDetails)
        {
            IEnumerable<PlanDetail> completed = await _service.GetCompleted(planDetails);

            if (completed == null || !completed.Any())
            {
                _logger.LogWarning("No completed entities");

                return NotFound();
            }

            return Ok(completed);
        }

        /// <summary>
        /// Create plan-detail.
        /// </summary>
        /// <param name="form"> Plan-detail form to create plan-detail. </param>
        /// <returns> Created plan-detail. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(PlanDetailResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] PlanDetailForm form)
        {
            PlanDetailResource planDetail = await _service.Create(form);

            return Ok(planDetail);
        }

        /// <summary>
        /// Delete plan-detail by id.
        /// </summary>
        /// <param name="id"> Id to delete plan-detail. </param>
        /// <returns> Deleted plan-detail. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(PlanDetailResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            PlanDetailResource planDetail = await _service.Delete(id);
            
            return Ok(planDetail);
        }

        /// <summary>
        /// Update plan-detail.
        /// </summary>
        /// <param name="resource"> Plan form to update plan. </param>
        /// <returns> Updated plan. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(PlanDetailResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] PlanDetailResource resource)
        {
            PlanDetailResource planDetail = await _service.Update(resource);

            return Ok(planDetail);
        }
    }
}
