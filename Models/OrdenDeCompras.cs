
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrdenDeCompras
{

    [Key]
    public int OrdenDeCompraId { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public DateTime Fecha { get; set; }

    public double CostoTotal { get; set; }

    [ForeignKey("OrdenDeCompraId")]
    public virtual List<DetalleOrdenDeCompras> DetalleOrdenDeCompras { get; set; } = new List<DetalleOrdenDeCompras>();
    public bool Eliminado { get; set; } = false;

}