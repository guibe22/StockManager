
using System.ComponentModel.DataAnnotations;

public class DetalleOrdenDeCompras
{
    [Key]
    public int DetalleOrdenDeCompraId { get; set; }
    public int OrdenDeCompraId { get; set; }
    [Required]
    public int ProductoId { get; set; }
    [Required]
    public int ProveedorId { get; set; }
    [Required(ErrorMessage = "Campo obligatorio.")]
    public int Cantidad { get; set; }
    public double Costo { get; set; }
    public double CostoTotal { get; set; }
    public bool Aprobado { get; set; } = false;
    public bool Eliminado { get; set; } = false;
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }
}