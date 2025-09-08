using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DomeController : ControllerBase
    {
        private readonly IDomeService _service;

        public DomeController(IDomeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Dome>> Create(Dome dome)
        {
            var created = await _service.CreateAsync(dome);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dome>> GetById(int id)
        {
            var dome = await _service.GetByIdAsync(id);
            if (dome == null) return NotFound();
            return Ok(dome);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dome>>> GetAll()
        {
            var domes = await _service.GetAllAsync();
            return Ok(domes);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Dome>> Update(int id, Dome dome)
        {
            if (id != dome.Id) return BadRequest();
            var updated = await _service.UpdateAsync(dome);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}