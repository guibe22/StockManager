using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class InventariosBLL
{
    private readonly Contexto _Contexto;

    public InventariosBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int InventarioId)
    {
        return _Contexto.Inventarios.Any(o => o.InventarioId == InventarioId);
    }

    private bool Insertar(Inventarios Inventario)
    {
        Inventario.FechaActualizado = DateTime.Now;
        Ubicaciones? ubicacion= _Contexto.Ubicaciones.AsNoTracking().FirstOrDefault(o => o.UbicacionId == Inventario.InventarioId);
        
        if(ubicacion!=null){
             ubicacion.Ocupado = true;
            _Contexto.Entry(ubicacion).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(ubicacion).State = EntityState.Detached;
        }

        _Contexto.Inventarios.Add(Inventario);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Inventario).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Inventarios Inventario)
    {
        Inventario.FechaActualizado = DateTime.Now;
        Inventarios? InventarioAnterior = _Contexto.Inventarios
               .Where(o => o.InventarioId == Inventario.InventarioId)
               .AsNoTracking()
               .SingleOrDefault();
        if (InventarioAnterior != null)
        {
            Ubicaciones? ubicacionAnterior= _Contexto.Ubicaciones.AsNoTracking().FirstOrDefault(o => o.UbicacionId == InventarioAnterior.InventarioId);
        
            if(ubicacionAnterior!=null){
                ubicacionAnterior.Ocupado = false;
                _Contexto.Entry(ubicacionAnterior).State = EntityState.Modified;
                _Contexto.SaveChanges();
                _Contexto.Entry(ubicacionAnterior).State = EntityState.Detached;
            }
        }

        Ubicaciones? ubicacion= _Contexto.Ubicaciones.AsNoTracking().FirstOrDefault(o => o.UbicacionId == Inventario.InventarioId);
        
        if(ubicacion!=null){
             ubicacion.Ocupado = true;
            _Contexto.Entry(ubicacion).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(ubicacion).State = EntityState.Detached;
        }

        _Contexto.Entry(Inventario).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;

        _Contexto.Entry(Inventario).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Inventarios Inventario)
    {
        if (!Existe(Inventario.InventarioId))
        {
            return this.Insertar(Inventario);
        }
        else
        {
            return this.Modificar(Inventario);
        }
    }

    public Inventarios? Buscar(int InventarioId)
    {
        return _Contexto.Inventarios.AsNoTracking().FirstOrDefault(o => o.InventarioId == InventarioId);

    }

    public bool Eliminar(Inventarios Inventario)
    {
         Ubicaciones? ubicacion= _Contexto.Ubicaciones.AsNoTracking().FirstOrDefault(o => o.UbicacionId == Inventario.InventarioId);
        
        if(ubicacion!=null){
             ubicacion.Ocupado = false;
            _Contexto.Entry(ubicacion).State = EntityState.Modified;
            _Contexto.SaveChanges();
            _Contexto.Entry(ubicacion).State = EntityState.Detached;
        }

        Inventario.Eliminado = true;
        _Contexto.Entry(Inventario).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Inventario).State = EntityState.Detached;
        return save;
    }
    public List<Inventarios> GetList(Expression<Func<Inventarios, bool>> criterio)
    {
        return _Contexto.Inventarios.AsNoTracking().Where(criterio).ToList();
    }
}