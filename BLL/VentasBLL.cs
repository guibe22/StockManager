using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class VentasBLL
{
    private readonly Contexto _Contexto;

    public VentasBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int VentaId)
    {
        return _Contexto.Ventas.Any(o => o.VentaId == VentaId);

    }

    private bool Insertar(Ventas venta)
    {
        foreach (var detalle in venta.detallesVentas)
        {
            var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
            if (inventario != null)
            {
                inventario.Cantidad -= detalle.Cantidad;
                _Contexto.Entry(inventario).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(inventario).State = EntityState.Detached;

            }
        }
        if (venta.Tipo == "Credito")
        {
            var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == venta.ClienteId);
            if (cliente != null)
            {

                cliente.Balance += venta.Total;
                _Contexto.Entry(cliente).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(cliente).State = EntityState.Detached;
            }
        }

        _Contexto.Ventas.Add(venta);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(venta).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Ventas venta)
    {
        var VentaAnterior = _Contexto.Ventas
               .Where(o => o.VentaId == venta.VentaId)
               .Include(o => o.detallesVentas)
               .AsNoTracking()
               .SingleOrDefault();
        if (VentaAnterior != null)
        {
            foreach (var detalle in VentaAnterior.detallesVentas)
            {
                var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
                if (inventario != null)
                {
                    inventario.Cantidad += detalle.Cantidad;
                    _Contexto.Entry(inventario).State = EntityState.Modified;
                    _Contexto.SaveChanges();
                    _Contexto.Entry(inventario).State = EntityState.Detached;

                }
            }
            if (VentaAnterior.Tipo == "Credito")
            {
                var clienteAnterior = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == venta.ClienteId);
                if (clienteAnterior != null)
                {
                    clienteAnterior.Balance -= VentaAnterior.Total;
                    _Contexto.Entry(clienteAnterior).State = EntityState.Modified;
                    _Contexto.SaveChanges();
                    _Contexto.Entry(clienteAnterior).State = EntityState.Detached;
                }
            }
            _Contexto.Entry(VentaAnterior).State = EntityState.Detached;


        }

        foreach (var detalle in venta.detallesVentas)
        {
            var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
            if (inventario != null)
            {
                inventario.Cantidad -= detalle.Cantidad;
                _Contexto.Entry(inventario).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(inventario).State = EntityState.Detached;

            }
        }
        if (venta.Tipo == "Credito")
        {
            var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == venta.ClienteId);
            if (cliente != null)
            {
                cliente.Balance += venta.Total;
                _Contexto.Entry(cliente).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(cliente).State = EntityState.Detached;
            }
        }

        var DetalleEliminar = _Contexto.Set<DetallesVenta>().Where(o => o.VentaId == venta.VentaId).AsNoTracking();
        _Contexto.Set<DetallesVenta>().RemoveRange(DetalleEliminar);
        _Contexto.Set<DetallesVenta>().AddRange(venta.detallesVentas);

        _Contexto.Entry(venta).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(venta).State = EntityState.Detached;
        return save;



    }
    public bool Guardar(Ventas venta)
    {
        if (!Existe(venta.VentaId))
        {
            return this.Insertar(venta);
        }
        else
        {
            return this.Modificar(venta);
        }
    }

    public bool Eliminar(Ventas venta)
    {
        foreach (var detalle in venta.detallesVentas)
        {
            var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
            if (inventario != null)
            {
                inventario.Cantidad += detalle.Cantidad;
                _Contexto.Entry(inventario).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(inventario).State = EntityState.Detached;

            }
        }
        if (venta.Tipo == "Credito")
        {
            var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == venta.ClienteId);
            if (cliente != null)
            {
                cliente.Balance -= venta.Total;
                _Contexto.Entry(cliente).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(cliente).State = EntityState.Detached;

            }
        }
        venta.Eliminado = true;
        _Contexto.Entry(venta).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(venta).State = EntityState.Detached;
        return save;
    }

    public Ventas? Buscar(int VentaId){
     return _Contexto.Ventas
           .Where(o => o.VentaId== VentaId)
           .Include(o =>  o.detallesVentas)
           .AsNoTracking()
           .SingleOrDefault();
   }

   public List<Ventas> GetList(Expression<Func<Ventas,bool>>criterio){
        return _Contexto.Ventas.AsNoTracking().Where(criterio).Include(o =>  o.detallesVentas).ToList();
   }

}
