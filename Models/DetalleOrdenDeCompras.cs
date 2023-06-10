
using System.ComponentModel.DataAnnotations;

public class DetalleOrdenDeCompras
{
    [Key]
    public int DetalleOrdenDeCompraId { get; set; }
    public int OrdenDeCompraId { get; set; }
    [Required]
    public int ProductoId { get; set; }
    [Required]
    public int CategoriaId { get; set; }
    public int ProveedorId { get; set; }
    [Required]
    public String? Solicitante { get; set; }
    public int Cantidad { get; set; }
 

}