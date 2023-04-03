using BuildingWorks.Models.Resources;
using BuildingWorks.Models.Resources.Workers;
using BuildingWorks.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers
{
    [ApiController]
    [Route("/api/v1/login")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly ILogger _logger;

        public AuthController(IAuthService service, ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Sign up user.
        /// </summary>
        /// <param name="form"> User form to sign up. </param>
        /// <returns> Signed up user. </returns>
        [HttpPost("/signUp")]
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Authentificate([FromBody] UserForm form)
        {
            UserResource user = await _service.Authentificate(form);

            if (user == null)
            {
                _logger.LogWarning("User code not exists in unregistered user codes");

                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Sign in user.
        /// </summary>
        /// <param name="form"> User form to sign in. </param>
        /// <returns> Signed in user. </returns>
        [HttpPost("/signUp")]
        [ProducesResponseType(typeof(WorkerResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Authorize([FromBody] UserForm form)
        {
            UserResource user = await _service.Authentificate(form);

            if (user == null)
            {
                _logger.LogWarning("User not exists in collection of users");

                return NotFound();
            }

            return Ok(user);
        }
    }
} 