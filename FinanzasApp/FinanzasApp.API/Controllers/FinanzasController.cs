﻿using FinanzasApp.API.Models;
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimiento(int id)
        {
            var movimiento = await _context.Movimientos.FindAsync(id);
            if (movimiento == null)
            {
                return NotFound();
            }

            _context.Movimientos.Remove(movimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Movimiento movimiento)
        {
            var existente = await _context.Movimientos.FindAsync(id);
            if (existente == null)
                return NotFound();

            existente.Descripcion = movimiento.Descripcion;
            existente.Monto = movimiento.Monto;
            existente.Tipo = movimiento.Tipo;
            // Se puede mantener la fecha o permitir actualizarla también
            existente.Fecha = movimiento.Fecha;

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}