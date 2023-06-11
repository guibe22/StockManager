using System.ComponentModel.DataAnnotations;

class Inventarios
{
    [Key]
    public int InventarioId { get; set; }
    [Required]
    public int CatalogoId { get; set; }
    [Required(ErrorMessage = "El Producto es requerido")]
    
    public int ProductoId { get; set; }
    [Required(ErrorMessage = "El Proveedor es requerido")]
    public int ProveedorId { get; set; }
    [Required(ErrorMessage = "El Concepto es requerido")]
    public String? Concepto { get; set; }
    [Required(ErrorMessage = "Especifique la cantidad")]
    public int Cantidad { get; set; }
     [Required(ErrorMessage = "Especifique la cantidad Minima")]
    public int CantidadMinima { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaActualizado { get; set; }
    public int UbicacionId { get; set; }
    public bool Eliminado { get; set; } = false;
}