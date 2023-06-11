using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DetallesCompras
{
    [Key]
    public int DetalleCompraId { get; set; }
    public int CompraId { get; set; }
    public int InventarioId { get; set; }
    public int ProveedorId { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public double SubTotal { get; set; }

}
