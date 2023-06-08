using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Compras
{
    [Key]
    public int CompraId { get; set; }
    
    [Required(ErrorMessage = "El Cliente es requerido")]
    [Range(1, int.MaxValue, ErrorMessage = "El Cliente es requerido")]
    public int ClienteId { get; set; }
    
    [Required(ErrorMessage = "El Producto es requerido")]
    public int ProductoId { get; set; }
    
    [Required(ErrorMessage = "El Concepto es requerido")]
    public string? Concepto { get; set; }
    
    [Required(ErrorMessage = "Especifique la cantidad")]
    public int Cantidad { get; set; }
    
    [Required(ErrorMessage = "El Proveedor es requerido")]
    public int ProveedorId { get; set; }
    
    public DateTime Fecha { get; set; }

    [ForeignKey("CompraId")]
    public virtual List<DetalleCompras> detallescompras { get; set; } = new List<DetalleCompras>();
}
