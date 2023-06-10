using System.ComponentModel.DataAnnotations;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }
    public string? CodigoBarra { get; set; }
    public string? CodigoProducto { get; set; }

    [Required(ErrorMessage = "Se debe agregar nombre al producto.")]
    [MinLength(2)]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Se debe agregar una descripcion al producto.")]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "Campo obligatorio.")]
    public int CategoriaId { get; set; } 

    [Required(ErrorMessage = "El producto requiere un Precio.")]
    public double Precio { get; set; }

    [Required(ErrorMessage = "El producto requiere un Costo.")]
    public double Costo { get; set; }
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; } 
   
    public bool Eliminado { get; set; } = false;
}