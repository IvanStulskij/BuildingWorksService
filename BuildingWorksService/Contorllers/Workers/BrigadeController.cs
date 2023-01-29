﻿using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Services.Interfaces.Workers;
using Microsoft.AspNetCore.Mvc;
using Models.Resources.Workers;

namespace BuildingWorksService.Contorllers.Workers
{
    [ApiController]
    [Route("api/brigades")]
    public class BrigadeController : ControllerBase
    {
        private readonly IBrigadeService _service;

        public BrigadeController(IBrigadeService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get brigade by id.
        /// </summary>
        /// <param name="id"> Id to get brigade. </param>
        /// <returns> Single brigade. </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var brigade = await _service.GetById(id);

            return Ok(brigade);
        }

        /// <summary>
        /// Get all brigades.
        /// </summary>
        /// <returns> The list of brigades. </returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var brigades = await _service.GetAll();

            return Ok(brigades);
        }

        /// <summary>
        /// Get brigades by building-object.
        /// </summary>
        /// <param name="objectId"> Object id to get brigades. </param>
        /// <returns> The list of brigades. </returns>
        [HttpGet("getByObject")]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public IActionResult GetByObject([FromQuery] int objectId)
        {
            var brigades = _service.GetByObject(objectId);

            return Ok(brigades);
        }

        /// <summary>
        /// Get brigades codes.
        /// </summary>
        /// <returns> The list of brigades codes. </returns>
        [HttpGet("getCodes")]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public IActionResult GetBrigadesCodes()
        {
            var codes = _service.GetBrigadesCodes();

            return Ok(codes);
        }

        /// <summary>
        /// Create brigade.
        /// </summary>
        /// <param name="form"> Brigade form to create brigade. </param>
        /// <returns> Created brigade. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] BrigadeForm form)
        {
            var response = await _service.Create(form);

            return Ok(response);
        }

        /// <summary>
        /// Delete brigade by id.
        /// </summary>
        /// <param name="id"> Id to delete brigade. </param>
        /// <returns> Deleted brigade. </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(IEnumerable<BrigadeResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        /// <summary>
        /// Updated brigade.
        /// </summary>
        /// <param name="brigade"> Resource to create brigade. </param>
        /// <returns> Updated brigade. </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BrigadeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] BrigadeResource brigade)
        {
            var response = await _service.Update(brigade.Id, brigade);
            return Ok(response);
        }
    }
}