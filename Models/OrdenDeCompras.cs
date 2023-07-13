
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrdenDeCompras
{

    [Key]
    public int OrdenDeCompraId { get; set; }
    public string? Concepto { get; set; }
    public int CantidadTotal { get; set; }
    public double CostoTotal { get; set; }
    public string? Detalle { get; set; }
    public bool Eliminado { get; set; } = false;
    public bool filtrado { get; set; } = false;
    public DateTime Fecha { get; set; }

     public virtual List<DetalleOrdenDeCompras> DetalleOrdenDeCompras { get; set; } = new List<DetalleOrdenDeCompras>();

}