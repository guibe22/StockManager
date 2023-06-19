using System.ComponentModel.DataAnnotations;

public class RelacionProductoProveedor
{
    [Key]
    public int RelacionProductoProveedorId { get; set; }
    public int ProductoId { get; set; }
    public int ProveedorId { get; set; }
    public decimal costo { get; set; }
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}

