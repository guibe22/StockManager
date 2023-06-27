using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Facturaciones
{
    [Key]
    public int FacturacionId { get; set; }
    [Required(ErrorMessage = "El Cliente es requerido")]
    [Range(1, int.MaxValue, ErrorMessage = "El Cliente es Requerido")]
    public int ClienteId { get; set; }
    [Required]
    public double Total { get; set; }
    [Required]
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
    [ForeignKey("FacturacionId")]
    public virtual List<DetalleFacturacion> detalleFacturaciones { get; set; } = new List<DetalleFacturacion>();
}