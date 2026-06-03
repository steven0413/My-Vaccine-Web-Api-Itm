using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVac.WebApi.Data;
using MyVac.WebApi.Models;

namespace MyVac.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosVacunasController : ControllerBase
    {
        private readonly MyVaccineAppDbContext _context;
        public RegistrosVacunasController(MyVaccineAppDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroVacuna>>> Get() =>
            await _context.RegistrosVacunas.Include(r => r.Persona).Include(r => r.Vacuna).ToListAsync();

        [HttpPost]
        public async Task<ActionResult<RegistroVacuna>> Create(RegistroVacuna registro)
        {
            _context.RegistrosVacunas.Add(registro);
            await _context.SaveChangesAsync();
            return Ok(registro);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.RegistrosVacunas.FindAsync(id);
            if (item == null) return NotFound();
            _context.RegistrosVacunas.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}