using System.ComponentModel.DataAnnotations;

public class Catalogos
{
    [Key]
    public int CatalogoId { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}