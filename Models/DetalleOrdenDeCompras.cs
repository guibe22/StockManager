
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
    [Required (ErrorMessage = "Campo obligatorio.")]
    public int Cantidad { get; set; }
    public decimal CostoTotal { get; set; }
    public bool Eliminado { get; set; } = false;
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }

    
    


}