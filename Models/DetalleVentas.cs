using System.ComponentModel.DataAnnotations;

public class DetallesVenta
{
    [Key]
    public int DetalleVentaId { get; set; }
    public int VentaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public Double Precio { get; set; }
    public Double SubTotal { get; set; }
}