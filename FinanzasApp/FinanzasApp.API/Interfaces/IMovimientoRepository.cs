using FinanzasApp.API.Models;
using System.Collections.Generic;

namespace FinanzasApp.API.Interfaces
{
    public interface IMovimientoRepository
    {
        IEnumerable<Movimiento> ObtenerTodos();
        Movimiento ObtenerPorId(int id);
        void Crear(Movimiento movimiento);

    }
}
