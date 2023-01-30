using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Services.Interfaces.Plans;
using Microsoft.AspNetCore.Mvc;
using Models.Resources.Plans;

namespace BuildingWorksService.Contorllers.Plans
{
    [ApiController]
    [Route("api/plan-details")]
    public class PlanDetailsController : ControllerBase
    {
        private readonly IPlanDetailsService _service;

        public PlanDetailsController(IPlanDetailsService service)
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
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var activity = await _service.GetById(id);
            return Ok(activity);
        }

        /// <summary>
        /// Get all plan-details.
        /// </summary>
        /// <returns> The list of all plan-details. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PlanDetailResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();
            return Ok(response);
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
            var response = _service.CountDonePercent(planId);
            return Ok(response);
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
            var response = _service.GetByPlan(planId);
            return Ok(response);
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
            var response = _service.GetCompleted(planDetails);
            return Ok(response);
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
            var response = await _service.Create(form);
            return Ok(response);
        }

        /// <summary>
        /// Delete plan-detail by id.
        /// </summary>
        /// <param name="id"> Id to delete plan-detail. </param>
        /// <returns> Deleted plan-detail. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(PlanDetailResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
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
            var response = await _service.Update(resource.Id, resource);
            return Ok(response);
        }
    }
}
