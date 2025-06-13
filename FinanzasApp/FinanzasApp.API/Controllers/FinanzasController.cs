using FinanzasApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using FinanzasApp.API.Interfaces;

namespace FinanzasApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanzasController : ControllerBase
    {
        private static List<Movimiento> _movimientos = new List<Movimiento>();
        private static int _nextId = 1;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_movimientos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movimiento movimiento)
        {
            if (movimiento == null)
                return BadRequest();

            movimiento.Id = _nextId++;
            _movimientos.Add(movimiento);
            return CreatedAtAction(nameof(Get), new { id = movimiento.Id }, movimiento);
        }
    }
}
