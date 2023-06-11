using System.ComponentModel.DataAnnotations;

public class Catalogos
{
    [Key]
    public int CatalogoId { get; set; }
    [Required]
  public int ProductoId { get; set; }
    [Required]
    public int ProveedorId { get; set; }
    [Required(ErrorMessage = "Debe especificar la  fecha.")]
    public DateTime Fecha { get; set; }
}