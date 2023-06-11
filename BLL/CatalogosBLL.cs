using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class CatalogosBLL
{
    private readonly Contexto _Contexto;

    public CatalogosBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int CatalogoId)
    {
        return _Contexto.Catalogos.Any(o => o.CatalogoId == CatalogoId);
    }

    private bool Insertar(Catalogos Catalogo)
    {
        _Contexto.Catalogos.Add(Catalogo);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Catalogo).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Catalogos Catalogo)
    {
        _Contexto.Entry(Catalogo).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Catalogo).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Catalogos Catalogo)
    {
        if (!Existe(Catalogo.CatalogoId))
        {
            return this.Insertar(Catalogo);
        }
        else
        {
            return this.Modificar(Catalogo);
        }
    }

    public Catalogos? Buscar(int CatalogoId)
    {
        return _Contexto.Catalogos.AsNoTracking().FirstOrDefault(o => o.CatalogoId == CatalogoId);

    }

    public bool Eliminar(Catalogos Catalogo)
    {
        Catalogo.Eliminado = true;
        _Contexto.Entry(Catalogo).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Catalogo).State = EntityState.Detached;
        return save;
    }
    public List<Catalogos> GetList(Expression<Func<Catalogos, bool>> criterio)
    {
        return _Contexto.Catalogos.AsNoTracking().Where(criterio).ToList();
    }
}