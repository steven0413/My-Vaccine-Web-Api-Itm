using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVac.WebApi.Data;
using MyVac.WebApi.Models;

namespace MyVac.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacunasController : ControllerBase
    {
        private readonly MyVaccineAppDbContext _context;
        public VacunasController(MyVaccineAppDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacuna>>> Get() => await _context.Vacunas.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Vacuna>> GetById(int id)
        {
            var item = await _context.Vacunas.FindAsync(id);
            return item == null ? NotFound() : item;
        }

        [HttpPost]
        public async Task<ActionResult<Vacuna>> Create(Vacuna vacuna)
        {
            _context.Vacunas.Add(vacuna);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = vacuna.Id }, vacuna);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Vacuna vacuna)
        {
            if (id != vacuna.Id) return BadRequest();
            _context.Entry(vacuna).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Vacunas.FindAsync(id);
            if (item == null) return NotFound();
            _context.Vacunas.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}