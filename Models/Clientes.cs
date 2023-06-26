using System.ComponentModel.DataAnnotations;

public class Clientes
{
    [Key]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "Se debe agregar nombre del cliente.")]
    [MinLength(2)]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "se debe agregar apellido del cliente.")]
    [MinLength(2)]
    public string? Apellido { get; set; }
    [Required(ErrorMessage = "Campo obligatorio.")]
    public string? Direccion { get; set; }
    [Required(ErrorMessage = "El cliente requiere un Telefono.")]
    public string? Telefono { get; set; }
    [Required(ErrorMessage = "El cliente requiere un Cedula.")]
    public string? Cedula { get; set; }
    [Required(ErrorMessage = "Debe especificar la decha.")]
    public double Balance { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}