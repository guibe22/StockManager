
using System.ComponentModel.DataAnnotations;

public class DetalleFacturacion
{
    [Key]
    public int DetalleFacturacionId { get; set; }
    public int FacturacionId { get; set; }
    public string? Descripcion { get; set; }
    public double SubTotal { get; set; }
    public double Precio { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}