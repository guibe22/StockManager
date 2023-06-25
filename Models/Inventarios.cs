using System.ComponentModel.DataAnnotations;

public class Inventarios
{
    [Key]
    public int InventarioId { get; set; }
    [Required]
    
    public int ProductoId { get; set; }
    [Required(ErrorMessage = "El concepto es requerido")]
    public String? Concepto { get; set; }
    [Required(ErrorMessage = "Especifique la cantidad")]
    public int Cantidad { get; set; }
    public int UbicacionId { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}