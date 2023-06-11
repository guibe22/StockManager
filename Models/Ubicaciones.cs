using System.ComponentModel.DataAnnotations;

public class Ubicaciones
{
    [Key]
    public int UbicacionId { get; set; }
    public string? Pasillo { get; set; }
    public string? Estante { get; set; }
    public int Nivel { get; set; }
}