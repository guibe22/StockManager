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
        _Contexto.Inventarios.Add(Inventario);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Inventario).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Inventarios Inventario)
    {
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
        _Contexto.Entry(Inventario).State = EntityState.Deleted;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Inventario).State = EntityState.Detached;
        return save;
    }
    public List<Inventarios> GetList(Expression<Func<Inventarios, bool>> criterio)
    {
        return _Contexto.Inventarios.AsNoTracking().Where(criterio).ToList();
    }
}