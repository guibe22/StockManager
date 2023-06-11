using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

class ComprasBLL
{
    private readonly Contexto _Contexto;

    public ComprasBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int CompraId)
    {
        return _Contexto.Compras.Any(o => o.CompraId == CompraId);

    }

    private bool Insertar(Compras Compra)
    {

        foreach (var detalle in Compra.DetallesCompras)
        {
            var Inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.InventarioId == detalle.InventarioId);
            if (Inventario != null)
            {
                Inventario.Cantidad -= detalle.Cantidad;
                _Contexto.Entry(Inventario).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(Inventario).State = EntityState.Detached;

            }
        }

        _Contexto.Compras.Add(Compra);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Compra).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Compras Compra)
    {
        var CompraAnterior = _Contexto.Compras
               .Where(o => o.CompraId == Compra.CompraId)
               .Include(o => o.DetallesCompras)
               .AsNoTracking()
               .SingleOrDefault();
        if (CompraAnterior != null)
        {
            foreach (var detalle in CompraAnterior.DetallesCompras)
            {
                var Inventario = _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.InventarioId == detalle.InventarioId);
                if (Inventario != null)
                {
                    Inventario.Cantidad += detalle.Cantidad;
                    _Contexto.Entry(Inventario).State = EntityState.Modified;
                    _Contexto.SaveChanges();
                    _Contexto.Entry(Inventario).State = EntityState.Detached;

                }
            }

        }

        foreach (var detalle in Compra.DetallesCompras)
        {
            var Inventario = _Contexto.Inventarios.Find(detalle.InventarioId);
            if (Inventario != null)
            {
                Inventario.Cantidad -= detalle.Cantidad;
                _Contexto.Entry(Inventario).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(Inventario).State = EntityState.Detached;

            }
        }



        var DetalleEliminar = _Contexto.Set<DetallesCompras>().Where(o => o.CompraId == Compra.CompraId).AsNoTracking();
        _Contexto.Set<DetallesCompras>().RemoveRange(DetalleEliminar);
        _Contexto.Set<DetallesCompras>().AddRange(Compra.DetallesCompras);

        _Contexto.Entry(Compra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Compra).State = EntityState.Detached;
        return save;



    }

    public bool Guardar(Compras Compra)
    {
        if (!Existe(Compra.CompraId))
        {
            return this.Insertar(Compra);
        }
        else
        {
            return this.Modificar(Compra);
        }
    }

    public bool Eliminar(Compras Compra)
    {
        Compra.Eliminado = true;
        _Contexto.Entry(Compra).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Compra).State = EntityState.Detached;
        return save;

    }

    public Compras? Buscar(int CompraId)
    {
        return _Contexto.Compras
              .Where(o => o.CompraId == CompraId)
              .Include(o => o.DetallesCompras)
              .AsNoTracking()
              .SingleOrDefault();
    }

    public List<Compras> GetList(Expression<Func<Compras, bool>> criterio)
    {
        return _Contexto.Compras.AsNoTracking().Where(criterio).Include(o => o.DetallesCompras).ToList();
    }



}