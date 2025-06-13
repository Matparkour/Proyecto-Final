using FinanzasApp.API.Interfaces;
using FinanzasApp.API.Models;
using System.Collections.Generic;

namespace FinanzasApp.API.Services
{
    public class MovimientoService : IMovimientoService
    {
        private readonly IMovimientoRepository _repo;

        public MovimientoService(IMovimientoRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Movimiento> ObtenerTodos() => _repo.ObtenerTodos();

        public Movimiento ObtenerPorId(int id) => _repo.ObtenerPorId(id);

        public void Crear(Movimiento movimiento) => _repo.Crear(movimiento);
    }
}
