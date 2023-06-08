using Microsoft.EntityFrameworkCore;

public class Contexto:DbContext
{
    public DbSet<Clientes> Clientes {get; set;}
    public DbSet<Productos> Productos {get; set;}
    public DbSet<Proveedores> Proveedores {get; set;}
    public DbSet<Ventas> Ventas {get; set;}
    public DbSet<Compras> Compras {get; set;}

    public Contexto(DbContextOptions<Contexto>options) :base(options)
    {
        
    }
}