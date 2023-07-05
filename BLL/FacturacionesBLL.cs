using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

class FacturacionesBLL
{
    private readonly Contexto _Contexto;

    public FacturacionesBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int FacturacionId)
    {
        return _Contexto.Facturaciones.Any(o => o.FacturacionId == FacturacionId);

    }

    public bool Insertar(Facturaciones facturacion)
    {
        var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == facturacion.ClienteId);
        if (cliente != null)
        {

            cliente.Balance += facturacion.Total;
            _Contexto.Entry(cliente).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(cliente).State = EntityState.Detached;
        }
        _Contexto.Facturaciones.Add(facturacion);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(facturacion).State = EntityState.Detached;
        return save;
    }

    public bool Modificar(Facturaciones facturacion)
    {
        var facturacionAnterior = _Contexto.Facturaciones
               .Where(o => o.FacturacionId == facturacion.FacturacionId)
               .Include(o => o.detalleFacturaciones)
               .AsNoTracking()
               .SingleOrDefault();
        if (facturacionAnterior != null)
        {
            var clienteAnterior = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == facturacion.ClienteId);
            if (clienteAnterior != null)
            {
                clienteAnterior.Balance -= facturacionAnterior.Total;
                _Contexto.Entry(clienteAnterior).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(clienteAnterior).State = EntityState.Detached;
            }
        }

        var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == facturacion.ClienteId);
        if (cliente != null)
        {

            cliente.Balance += facturacion.Total;
            _Contexto.Entry(cliente).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(cliente).State = EntityState.Detached;
        }



        var DetalleEliminar = _Contexto.Set<DetalleFacturacion>().Where(o => o.FacturacionId == facturacion.FacturacionId).AsNoTracking();
        _Contexto.Set<DetalleFacturacion>().RemoveRange(DetalleEliminar);
        _Contexto.Set<DetalleFacturacion>().AddRange(facturacion.detalleFacturaciones);
        _Contexto.Entry(facturacion).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(facturacion).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Facturaciones facturacion)
    {
        if (!Existe(facturacion.FacturacionId))
        {
            return this.Insertar(facturacion);
        }
        else
        {
            return this.Modificar(facturacion);
        }
    }

    public bool Eliminar(Facturaciones facturacion)
    {
        var cliente = _Contexto.Clientes.AsNoTracking().FirstOrDefault(o => o.ClienteId == facturacion.ClienteId);
        if (cliente != null)
        {
            cliente.Balance -= facturacion.Total;
            _Contexto.Entry(cliente).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(cliente).State = EntityState.Detached;

        }

        facturacion.Eliminado = true;
        _Contexto.Entry(facturacion).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(facturacion).State = EntityState.Detached;
        return save;
    }

    public Facturaciones? Buscar(int FacturacionId)
    {
        return _Contexto.Facturaciones
              .Where(o => o.FacturacionId == FacturacionId && o.Eliminado == false)
              .Include(o => o.detalleFacturaciones)
              .AsNoTracking()
              .SingleOrDefault();
    }

    public List<Facturaciones> GetList(Expression<Func<Facturaciones, bool>> criterio)
    {
        return _Contexto.Facturaciones.AsNoTracking().Where(criterio).Include(o => o.detalleFacturaciones).ToList();
    }

}