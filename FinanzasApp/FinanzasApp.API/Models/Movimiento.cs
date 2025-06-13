namespace FinanzasApp.API.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public required string Tipo { get; set; } = string.Empty;  
        public string Descripcion { get; set; } = string.Empty;

    }
}
