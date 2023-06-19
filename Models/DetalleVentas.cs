using System.ComponentModel.DataAnnotations;

public class DetallesVenta
{
    [Key]
    public int DetalleVentaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal SubTotal { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}