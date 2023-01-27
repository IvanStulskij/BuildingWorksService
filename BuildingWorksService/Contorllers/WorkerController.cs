using Microsoft.AspNetCore.Mvc;
using Models.Services.Interfaces;

namespace BuildingWorksService.Contorllers
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

        
    }
}
