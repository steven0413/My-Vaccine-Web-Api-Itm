using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVac.WebApi.Data;
using MyVac.WebApi.Models;

namespace MyVac.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly MyVaccineAppDbContext _context;
        public PersonasController(MyVaccineAppDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> Get() => await _context.Personas.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetById(int id)
        {
            var item = await _context.Personas.FindAsync(id);
            return item == null ? NotFound() : item;
        }

        [HttpPost]
        public async Task<ActionResult<Persona>> Create(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = persona.Id }, persona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Persona persona)
        {
            if (id != persona.Id) return BadRequest();
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Personas.FindAsync(id);
            if (item == null) return NotFound();
            _context.Personas.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}