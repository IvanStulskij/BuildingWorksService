﻿using BuildingWorks.Models.Resources.BuildingObject.Addresses;
using BuildingWorks.Services.Interfaces.BuildingObjects;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.BuildingObjects.Addresses
{
    [ApiController]
    [Route("/api/streets")]
    public class StreetController : ControllerBase
    {
        private readonly IStreetService _service;

        public StreetController(IStreetService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get street by id.
        /// </summary>
        /// <param name="id"> Id to get street. </param>
        /// <returns> Single street. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var street = await _service.GetById(id);

            return Ok(street);
        }

        /// <summary>
        /// Get all streets.
        /// </summary>
        /// <returns> The list of streets. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StreetResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var streets = await _service.GetAll();

            return Ok(streets);
        }

        /// <summary>
        /// Create street.
        /// </summary>
        /// <param name="form"> Form to create street. </param>
        /// <returns> Created street. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] StreetForm form)
        {
            var response = await _service.Create(form);

            if (response == null)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        /// <summary>
        /// Delete street by id.
        /// </summary>
        /// <param name="id"> Id to delete street. </param>
        /// <returns> Deleted street. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await _service.Delete(id);

            return Ok(response);
        }

        /// <summary>
        /// Update street.
        /// </summary>
        /// <param name="resource"> Resource to update street. </param>
        /// <returns> Updated street. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(StreetResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] StreetResource resource)
        {
            var response = await _service.Update(resource.Id, resource);

            return Ok(response);
        }
    }
}
