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
    public decimal Precio { get; set; }
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "Campo obligatorio.")]
    public int CategoriaId { get; set; }
    public decimal margen { get; set; }

    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}