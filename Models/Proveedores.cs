using System.ComponentModel.DataAnnotations;

public class Proveedores
{
    [Key]
    public int ProveedorId { get; set; }

    [Required(ErrorMessage = "Se debe agregar nombre del proveedor.")]
    [MinLength(2)]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Campo obligatorio.")]
    public string? Descripcion { get; set; }
    [Required(ErrorMessage = "El proveedor requiere un Telefono.")]
    public string? Telefono { get; set; }
    [Required(ErrorMessage = "El proveedor requiere una direccion.")]
    public string? Direccion { get; set; }
    [Required(ErrorMessage = "El proveedor requiere un RNC.")]
    public string? RNC { get; set; }
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }

    public bool Eliminado { get; set; } = false;
}