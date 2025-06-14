using FinanzasApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using FinanzasApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanzasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FinanzasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movimientos = await _context.Movimientos.ToListAsync();
            return Ok(movimientos);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movimiento movimiento)
        {
            if (movimiento == null)
                return BadRequest();

            _context.Movimientos.Add(movimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = movimiento.Id }, movimiento);
        }
    }
}