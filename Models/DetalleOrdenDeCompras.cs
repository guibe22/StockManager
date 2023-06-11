
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
    [Required (ErrorMessage = "El campo {0} es obligatorio")]
    public String? Solicitante { get; set; }
    [Required (ErrorMessage = "El campo {0} es obligatorio")]
    public int Cantidad { get; set; }
 

}