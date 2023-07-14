using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

class OrdenComprasBLL
{
    private readonly Contexto _Contexto;

    public OrdenComprasBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }
    public bool Existe(int OrdenDeCompraId)
    {
        return _Contexto.OrdenDeCompras.Any(o => o.OrdenDeCompraId == OrdenDeCompraId);

    }
    public bool Insertar(OrdenDeCompras ordenCompra)
    {

        _Contexto.OrdenDeCompras.Add(ordenCompra);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(ordenCompra).State = EntityState.Detached;
        return save;
    }

    public bool Modificar(OrdenDeCompras ordenCompra)
    {
        var DetalleEliminar = _Contexto.Set<DetalleOrdenDeCompras>().Where(o => o.OrdenDeCompraId == ordenCompra.OrdenDeCompraId).AsNoTracking();
        _Contexto.Set<DetalleOrdenDeCompras>().RemoveRange(DetalleEliminar);
        _Contexto.Set<DetalleOrdenDeCompras>().AddRange(ordenCompra.DetalleOrdenDeCompras);
        _Contexto.Entry(ordenCompra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(ordenCompra).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(OrdenDeCompras ordenCompra)
    {
        if (!Existe(ordenCompra.OrdenDeCompraId))
        {
            return this.Insertar(ordenCompra);
        }
        else
        {
            return this.Modificar(ordenCompra);
        }
    }

    public bool Eliminar(OrdenDeCompras ordenCompra)
    {

        ordenCompra.Eliminado = true;
        _Contexto.Entry(ordenCompra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(ordenCompra).State = EntityState.Detached;
        return save;
    }

    public OrdenDeCompras? Buscar(int OrdenDeCompraId)
    {
        return _Contexto.OrdenDeCompras
              .Where(o => o.OrdenDeCompraId == OrdenDeCompraId && o.Eliminado == false)
              .Include(o => o.DetalleOrdenDeCompras)
              .AsNoTracking()
              .SingleOrDefault();
    }

    public List<OrdenDeCompras> GetList(Expression<Func<OrdenDeCompras, bool>> criterio)
    {
        return _Contexto.OrdenDeCompras
              .Where(criterio)
              .Include(o => o.DetalleOrdenDeCompras)
              .AsNoTracking()
              .ToList();
    }

    public bool Filtrar(OrdenDeCompras ordenCompra)
    {
        if (ordenCompra.filtrado == true)
        {
            return InsertarFiltrado(ordenCompra);
        }
        else
        {
            return ModificarFiltrado(ordenCompra);
        }

    }

    private bool InsertarFiltrado(OrdenDeCompras ordenCompra)
    {
        foreach (var detalle in ordenCompra.DetalleOrdenDeCompras)
        {
            if (detalle.Aprobado == true)
            {

                var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
                var Producto = _Contexto.Productos.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
                var ProductoProveedor = _Contexto.RelacionProductoProveedor.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId && o.ProveedorId == detalle.ProveedorId);
                if (inventario != null && Producto != null && ProductoProveedor != null)
                {
                    inventario.Cantidad += detalle.Cantidad;
                    Producto.Precio = ProductoProveedor.costo * (1 + Producto.margen);

                    _Contexto.Entry(inventario).State = EntityState.Modified;
                    _Contexto.Entry(Producto).State = EntityState.Modified;
                    _Contexto.Entry(detalle).State = EntityState.Modified;

                    _Contexto.SaveChanges();
                    _Contexto.Entry(inventario).State = EntityState.Detached;
                    _Contexto.Entry(Producto).State = EntityState.Detached;
                    _Contexto.Entry(detalle).State = EntityState.Detached;

                }
            }
        }

        _Contexto.Entry(ordenCompra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(ordenCompra).State = EntityState.Detached;
        return save;
    }

    private bool ModificarFiltrado(OrdenDeCompras ordenCompra)
    {
        var ordenCompraAnterior = _Contexto.OrdenDeCompras
               .Where(o => o.OrdenDeCompraId == ordenCompra.OrdenDeCompraId)
               .Include(o => o.DetalleOrdenDeCompras)
               .AsNoTracking()
               .SingleOrDefault();
        if (ordenCompraAnterior != null)
        {
            foreach (var detalle in ordenCompraAnterior.DetalleOrdenDeCompras)
            {
                if (detalle.Aprobado == true)
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
            }

        }

        foreach (var detalle in ordenCompra.DetalleOrdenDeCompras)
        {
            if (detalle.Aprobado == true)
            {

                var inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
                var Producto = _Contexto.Productos.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId);
                var ProductoProveedor = _Contexto.RelacionProductoProveedor.AsNoTracking().FirstOrDefault(o => o.ProductoId == detalle.ProductoId && o.ProveedorId == detalle.ProveedorId);
                if (inventario != null && Producto != null && ProductoProveedor != null)
                {
                    inventario.Cantidad += detalle.Cantidad;
                    Producto.Precio = ProductoProveedor.costo * (1 + Producto.margen);

                    _Contexto.Entry(inventario).State = EntityState.Modified;
                    _Contexto.Entry(Producto).State = EntityState.Modified;
                    _Contexto.Entry(detalle).State = EntityState.Modified;


                    _Contexto.SaveChanges();
                    _Contexto.Entry(inventario).State = EntityState.Detached;
                    _Contexto.Entry(Producto).State = EntityState.Detached;
                     _Contexto.Entry(detalle).State = EntityState.Detached;

                }
            }
        }


        _Contexto.Entry(ordenCompra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(ordenCompra).State = EntityState.Detached;
        return save;
    }
}