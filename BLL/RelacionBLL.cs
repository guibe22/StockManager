using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class RelacionBLL
{
    private readonly Contexto _Contexto;

    public RelacionBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int RelacionProductoProveedorId)
    {
        return _Contexto.RelacionProductoProveedor.Any(o => o.RelacionProductoProveedorId == RelacionProductoProveedorId);
    }

    private bool Insertar(RelacionProductoProveedor relacionProductoProveedor)
    {
        _Contexto.RelacionProductoProveedor.Add(relacionProductoProveedor);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(relacionProductoProveedor).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(RelacionProductoProveedor relacionProductoProveedor)
    {
        _Contexto.Entry(relacionProductoProveedor).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(relacionProductoProveedor).State = EntityState.Detached;
        return save;
    }
   
    public bool Guardar(RelacionProductoProveedor relacionProductoProveedor)
    {
        if (!Existe(relacionProductoProveedor.RelacionProductoProveedorId))
        {
            return this.Insertar(relacionProductoProveedor);
        }
        else
        {
            return this.Modificar(relacionProductoProveedor);
        }
    }


    public RelacionProductoProveedor? Buscar(int relacionProductoProveedorId)
    {
        return _Contexto.RelacionProductoProveedor.AsNoTracking().FirstOrDefault(o => o.RelacionProductoProveedorId == relacionProductoProveedorId);
    }
  

    public bool Eliminar(RelacionProductoProveedor relacionProductoProveedor)
    {
        relacionProductoProveedor.Eliminado = true;
        _Contexto.Entry(relacionProductoProveedor).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(relacionProductoProveedor).State = EntityState.Detached;
        return save;
    }
    
    public List<RelacionProductoProveedor> GetList(Expression<Func<RelacionProductoProveedor, bool>> criterio)
    {
        return _Contexto.RelacionProductoProveedor.AsNoTracking().Where(criterio).ToList();
    }
}