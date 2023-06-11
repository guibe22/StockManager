using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class CategoriasBLL
{
    private readonly Contexto _Contexto;

    public CategoriasBLL(Contexto Contexto)
    {
        _Contexto = Contexto;
    }

    public bool Existe(int CategoriaId)
    {
        return _Contexto.Categorias.Any(o => o.CategoriaId == CategoriaId);
    }

    private bool Insertar(Categorias Categoria)
    {
        _Contexto.Categorias.Add(Categoria);
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Categoria).State = EntityState.Detached;
        return save;
    }

    private bool Modificar(Categorias Categoria)
    {
        _Contexto.Entry(Categoria).State = EntityState.Modified;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Categoria).State = EntityState.Detached;
        return save;
    }

    public bool Guardar(Categorias Categoria)
    {
        if (!Existe(Categoria.CategoriaId))
        {
            return this.Insertar(Categoria);
        }
        else
        {
            return this.Modificar(Categoria);
        }
    }

    public Categorias? Buscar(int CategoriaId)
    {
        return _Contexto.Categorias.AsNoTracking().FirstOrDefault(o => o.CategoriaId == CategoriaId);

    }

    public bool Eliminar(Categorias Categoria)
    {
        _Contexto.Entry(Categoria).State = EntityState.Deleted;
        bool save = _Contexto.SaveChanges() > 0;
        _Contexto.Entry(Categoria).State = EntityState.Detached;
        return save;
    }
    public List<Categorias> GetList(Expression<Func<Categorias, bool>> criterio)
    {
        return _Contexto.Categorias.AsNoTracking().Where(criterio).ToList();
    }
}