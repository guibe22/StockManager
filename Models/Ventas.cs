

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ventas
{
    [Key]
    public int VentaId { get; set; }
    [Required(ErrorMessage = "El Cliente es requerido")]
    [Range(1, int.MaxValue, ErrorMessage = "El Cliente es Requerido")]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "Campo requerido")]
    public String? Tipo { get; set; }
    [Required]
    public int Total { get; set; }
 
    public DateTime Fecha { get; set; }
 public bool Eliminado { get; set; } = false;
    [ForeignKey("VentaId")]
    public virtual List<DetallesVenta> detallesVentas { get; set; } = new List<DetallesVenta>();
   
}