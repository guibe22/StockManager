using System.ComponentModel.DataAnnotations;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "Se debe agregar nombre al producto.")]
    [MinLength(2)]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Campo obligatorio.")]
    public string? Categoria { get; set; } 
    [Required(ErrorMessage = "El producto requiere un Precio.")]
    public double Precio { get; set; }

    
    [Required(ErrorMessage = "El producto requiere un Costo.")]
    public double Costo { get; set; }
    
    [Required(ErrorMessage = "El producto requiere una Cantidad Minima.")]
    public int CantidaMinima { get; set; }

    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; } 
    public int Existencia { get; set; }
  public bool Eliminado { get; set; } = false;
}