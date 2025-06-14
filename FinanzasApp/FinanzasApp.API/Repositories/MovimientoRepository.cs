using FinanzasApp.API.Interfaces;
using FinanzasApp.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace FinanzasApp.API.Repositories
{
    public class MovimientoRepository : IMovimientoRepository
    {
        private readonly List<Movimiento> _movimientos = new();
        private int _nextId = 1;

        public IEnumerable<Movimiento> ObtenerTodos() => _movimientos;

        public Movimiento ObtenerPorId(int id) =>
            _movimientos.FirstOrDefault(m => m.Id == id);

        public void Crear(Movimiento movimiento)
        {
            movimiento.Id = _nextId++;
            _movimientos.Add(movimiento);
        }

    }
}
