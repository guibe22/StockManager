using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class UbicacionesBLL
{
    private readonly Contexto _Contexto;

    public UbicacionesBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int UbicacionId)
    {
        return _Contexto.Ubicaciones.Any(o => o.UbicacionId == UbicacionId);
    }

    private bool Insertar(Ubicaciones Ubicacion)
    {
        _Contexto.Ubicaciones.Add(Ubicacion);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Ubicacion).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Ubicaciones Ubicacion)
    {
        _Contexto.Entry(Ubicacion).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Ubicacion).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Ubicaciones Ubicacion)
    {
        if (!Existe(Ubicacion.UbicacionId))
        {
            return this.Insertar(Ubicacion);
        }
        else
        {
            return this.Modificar(Ubicacion);
        }
    }

    public Ubicaciones? Buscar(int UbicacionId)
    {
        return _Contexto.Ubicaciones.AsNoTracking().FirstOrDefault(o => o.UbicacionId == UbicacionId);

    }

    public bool Eliminar(Ubicaciones Ubicacion)
    {
        _Contexto.Entry(Ubicacion).State = EntityState.Deleted;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Ubicacion).State = EntityState.Detached;
        return save;
    }
    public List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> criterio)
    {
        return _Contexto.Ubicaciones.AsNoTracking().Where(criterio).ToList();
    }
}