using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class ProveedoresBLL
{
    private readonly Contexto _Contexto;

    public ProveedoresBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int ProveedorId)
    {
        return _Contexto.Proveedores.Any(o => o.ProveedorId == ProveedorId);
    }

    private bool Insertar(Proveedores Proveedor)
    {
        _Contexto.Proveedores.Add(Proveedor);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Proveedor).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Proveedores Proveedor)
    {
        _Contexto.Entry(Proveedor).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Proveedor).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Proveedores Proveedor)
    {
        if (!Existe(Proveedor.ProveedorId))
        {
            return this.Insertar(Proveedor);
        }
        else
        {
            return this.Modificar(Proveedor);
        }
    }

    public Proveedores? Buscar(int ProveedorId)
    {
        return _Contexto.Proveedores.AsNoTracking().FirstOrDefault(o => o.ProveedorId == ProveedorId);

    }

    public bool Eliminar(Proveedores Proveedor)
    {
        _Contexto.Entry(Proveedor).State = EntityState.Deleted;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Proveedor).State = EntityState.Detached;
        return save;
    }
    public List<Proveedores> GetList(Expression<Func<Proveedores, bool>> criterio)
    {
        return _Contexto.Proveedores.AsNoTracking().Where(criterio).ToList();
    }
}