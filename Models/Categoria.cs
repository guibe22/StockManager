using System.ComponentModel.DataAnnotations;

public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "Se debe agregar el nombre de la categoría.")]
    [MinLength(2)]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Se debe agregar la descripción de la categoría.")]
    public string? Descripcion { get; set; }
    
    public bool Eliminado { get; set; } = false;
}
