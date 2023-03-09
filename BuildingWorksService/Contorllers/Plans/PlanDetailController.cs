using BuildingWorks.Databasable.Entities.Plans;
using BuildingWorks.Models;
using BuildingWorks.Models.Resources.Plans;
using BuildingWorks.Services.Interfaces.Plans;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Plans
{
    [ApiController]
    [Route("/api/plan-details")]
    public class PlanDetailController : ControllerBase
    {
        private readonly IPlanDetailsService _service;

        public PlanDetailController(IPlanDetailsService service)
        {
            _service = service;
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
                return NotFound("Entity with such id doesn't exist");
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
            
            return Ok(planDetails);
        }

        /// <summary>
        /// Count done percent by plan.
        /// </summary>
        /// <param name="planId"> Plan id to count done percent. </param>
        /// <returns> Done percent of plan. </returns>
        [HttpGet("countDonePercent")]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        public IActionResult CountDonePercent([FromQuery] int planId)
        {
            float donePercent = _service.CountDonePercent(planId);

            return Ok(donePercent);
        }

        /// <summary>
        /// Get plan-details by plan.
        /// </summary>
        /// <param name="planId"> Plan id to get plan-details. </param>
        /// <returns> The list of plan-details. </returns>
        [HttpGet("getByPlan")]
        [ProducesResponseType(typeof(IEnumerable<PlanDetail>), StatusCodes.Status200OK)]
        public IActionResult GetByPlan([FromQuery] int planId)
        {
            IEnumerable<PlanDetailResource> planDetails = _service.GetByPlan(planId);

            if (planDetails == null || !planDetails.Any())
            {
                return NotFound("No entities found for that plan");
            }

            return Ok(planDetails);
        }

        /// <summary>
        /// Get completed plan-details.
        /// </summary>
        /// <param name="planDetails"> The list of all plan-details. </param>
        /// <returns> The list of completed plan-details. </returns>
        [HttpGet("getCompleted")]
        [ProducesResponseType(typeof(PlanDetail), StatusCodes.Status200OK)]
        public IActionResult GetCompleted([FromBody] IEnumerable<PlanDetail> planDetails)
        {
            IEnumerable<PlanDetailResource> completed = _service.GetCompleted(planDetails);

            if (completed == null || !completed.Any())
            {
                return NotFound("No completed entities");
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
