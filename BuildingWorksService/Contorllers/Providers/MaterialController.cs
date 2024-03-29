﻿using BuildingWorks.Models;
using BuildingWorks.Models.Overview;
using BuildingWorks.Models.Resources.Providers;
using BuildingWorks.Services.Interfaces.Providers;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWorksService.Contorllers.Providers
{
    [ApiController]
    [Route("/api/v1/materials")]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _service;

        public MaterialController(IMaterialService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get material by id.
        /// </summary>
        /// <param name="id"> Id to get material. </param>
        /// <returns> Single material. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            MaterialResource material = await _service.GetById(id);

            if (material == null)
            {
                return NotFound(ExceptionMessages.EntityByIdNotExists);
            }

            return Ok(material);
        }

        /// <summary>
        /// Get all materials.
        /// </summary>
        /// <returns> The list of materials. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MaterialResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromRoute] PaginationParameters pagination)
        {
            IEnumerable<MaterialResource> materials = await _service.GetAll(pagination);

            if (materials == null || !materials.Any())
            {
                return NotFound(ExceptionMessages.NoEntitiesInDb);
            }

            return Ok(materials);
        }

        /// <summary>
        /// Get all materials overview.
        /// </summary>
        /// <returns> The list of materials. </returns>
        [HttpGet("overview")]
        [ProducesResponseType(typeof(IEnumerable<MaterialOverivew>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOverview([FromQuery] PaginationParameters pagination)
        {
            IEnumerable<MaterialOverivew> materials = await _service.GetAllOverview(pagination);

            if (materials == null || !materials.Any())
            {
                return NotFound(ExceptionMessages.NoEntitiesInDb);
            }

            return Ok(materials);
        }

        /// <summary>
        /// Create material.
        /// </summary>
        /// <param name="form"> Form to create material. </param>
        /// <returns> Created material. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] MaterialForm form)
        {
            MaterialResource material = await _service.Create(form);

            return Ok(material);
        }

        /// <summary>
        /// Delete material by id.
        /// </summary>
        /// <param name="id"> Id to delete form. </param>
        /// <returns> Deleted material. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            MaterialResource material = await _service.Delete(id);

            return Ok(material);
        }

        /// <summary>
        /// Update material.
        /// </summary>
        /// <param name="resource"> Resource to update material. </param>
        /// <returns> Updated form. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(MaterialResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] MaterialResource resource)
        {
            MaterialResource material = await _service.Update(resource);

            return Ok(material);
        }
    }
}
