using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Compras> Compras { get; set; }
    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<OrdenDeCompras> OrdenDeCompras { get; set; }
    public DbSet<Catalogos> Catalogos { get; set; }
    public DbSet<Ubicaciones> Ubicaciones { get; set; }
    public DbSet<Inventarios> Inventarios { get; set; }



    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Categorias>().HasData(
        new Categorias { CategoriaId = 1, Nombre = "Herramientas", Descripcion = "Productos relacionados con herramientas manuales y eléctricas." },
        new Categorias { CategoriaId = 2, Nombre = "Materiales de construcción", Descripcion = "Materiales necesarios para proyectos de construcción y remodelación." },
        new Categorias { CategoriaId = 3, Nombre = "Fijaciones y adhesivos", Descripcion = "Productos para fijar y pegar materiales, como tornillos, clavos y adhesivos." },
        new Categorias { CategoriaId = 4, Nombre = "Pinturas y acabados", Descripcion = "Productos para pintar y embellecer superficies, incluyendo pinturas y barnices." },
        new Categorias { CategoriaId = 5, Nombre = "Fontanería", Descripcion = "Productos para sistemas de plomería, como tuberías, grifos y accesorios." },
        new Categorias { CategoriaId = 6, Nombre = "Iluminación y electricidad", Descripcion = "Productos relacionados con iluminación, cableado eléctrico y accesorios." },
        new Categorias { CategoriaId = 7, Nombre = "Seguridad y protección", Descripcion = "Productos para la seguridad del hogar y protección personal, como cerraduras y cascos." },
        new Categorias { CategoriaId = 8, Nombre = "Ferretería de jardín", Descripcion = "Herramientas y productos para el cuidado y mantenimiento de jardines y áreas verdes." },
        new Categorias { CategoriaId = 9, Nombre = "Herrajes y accesorios", Descripcion = "Productos para puertas, ventanas y muebles, como manijas, bisagras y cierres." },
        new Categorias { CategoriaId = 10, Nombre = "Protección laboral", Descripcion = "Equipos de protección personal para trabajos industriales y de construcción." },
        new Categorias { CategoriaId = 11, Nombre = "Equipos de soldadura", Descripcion = "Máquinas y equipos para soldadura y trabajos de metal." },
        new Categorias { CategoriaId = 12, Nombre = "Productos de limpieza", Descripcion = "Productos químicos y utensilios para la limpieza y mantenimiento del hogar y oficina." },
        new Categorias { CategoriaId = 13, Nombre = "Ferretería automotriz", Descripcion = "Productos y herramientas para el mantenimiento y reparación de vehículos." },
        new Categorias { CategoriaId = 14, Nombre = "Cerraduras y sistemas de seguridad", Descripcion = "Productos para proteger y asegurar puertas y ventanas." },
        new Categorias { CategoriaId = 15, Nombre = "Herramientas de corte", Descripcion = "Herramientas para corte y precisión, como sierras y cuchillas." },
        new Categorias { CategoriaId = 16, Nombre = "Suministros eléctricos", Descripcion = "Productos y componentes eléctricos, como cables, interruptores y enchufes." },
        new Categorias { CategoriaId = 17, Nombre = "Pisos y revestimientos", Descripcion = "Materiales para pisos y revestimientos, como baldosas y laminados." },
        new Categorias { CategoriaId = 18, Nombre = "Herramientas de jardín", Descripcion = "Herramientas para el cuidado y mantenimiento del jardín, como podadoras y cortacéspedes." },
        new Categorias { CategoriaId = 19, Nombre = "Tornillería", Descripcion = "Tornillos de diferentes tipos y tamaños para diversas aplicaciones." },
        new Categorias { CategoriaId = 20, Nombre = "Herramientas de medición", Descripcion = "Instrumentos para medir longitudes, ángulos y dimensiones." },
        new Categorias { CategoriaId = 21, Nombre = "Suministros de pintura", Descripcion = "Accesorios y suministros para pintar, como rodillos y brochas." },
        new Categorias { CategoriaId = 22, Nombre = "Plomería y accesorios", Descripcion = "Suministros para sistemas de plomería, como tuberías y accesorios de conexión." },
        new Categorias { CategoriaId = 23, Nombre = "Protección respiratoria", Descripcion = "Equipos y máscaras para proteger la respiración en entornos contaminados." },
        new Categorias { CategoriaId = 24, Nombre = "Herramientas de carpintería", Descripcion = "Herramientas para trabajos de carpintería, como sierras y cepillos." },
        new Categorias { CategoriaId = 25, Nombre = "Abrasivos y lijado", Descripcion = "Productos para lijar y pulir superficies, como papel de lija y discos abrasivos." },
        new Categorias { CategoriaId = 26, Nombre = "Accesorios para ventanas", Descripcion = "Productos para mejorar y complementar ventanas, como persianas y mosquiteros." },
        new Categorias { CategoriaId = 27, Nombre = "Ferretería marina", Descripcion = "Productos y equipos para actividades náuticas y marítimas." },
        new Categorias { CategoriaId = 28, Nombre = "Herramientas de albañilería", Descripcion = "Herramientas para trabajos de albañilería, como llanas y paletas." },
        new Categorias { CategoriaId = 29, Nombre = "Suministros de soldadura", Descripcion = "Accesorios y suministros para trabajos de soldadura, como electrodos y soldaduras." },
        new Categorias { CategoriaId = 30, Nombre = "Productos de seguridad", Descripcion = "Equipos y dispositivos para la seguridad personal y en el lugar de trabajo." },
        new Categorias { CategoriaId = 31, Nombre = "Herramientas de aire comprimido", Descripcion = "Herramientas que funcionan con aire comprimido, como pistolas de aire y compresores." },
        new Categorias { CategoriaId = 32, Nombre = "Suministros de jardinería", Descripcion = "Productos y suministros para el cuidado de jardines y plantas." },
        new Categorias { CategoriaId = 33, Nombre = "Ferretería para puertas", Descripcion = "Productos y accesorios para puertas, como cerraduras y bisagras." },
        new Categorias { CategoriaId = 34, Nombre = "Herramientas de electricista", Descripcion = "Herramientas especializadas para trabajos eléctricos, como alicates y pelacables." },
        new Categorias { CategoriaId = 35, Nombre = "Sistemas de riego", Descripcion = "Productos y sistemas para el riego de jardines y áreas verdes." },
        new Categorias { CategoriaId = 36, Nombre = "Herramientas de demolición", Descripcion = "Herramientas para demolición y trabajos pesados, como martillos y cinceles." },
        new Categorias { CategoriaId = 37, Nombre = "Suministros de limpieza", Descripcion = "Productos y utensilios para la limpieza y mantenimiento de espacios." },
        new Categorias { CategoriaId = 38, Nombre = "Herramientas de corte de azulejos", Descripcion = "Herramientas especializadas para cortar azulejos y cerámicas." },
        new Categorias { CategoriaId = 39, Nombre = "Suministros de construcción", Descripcion = "Suministros generales para proyectos de construcción y remodelación." },
        new Categorias { CategoriaId = 40, Nombre = "Herramientas de jardín eléctricas", Descripcion = "Herramientas eléctricas para el cuidado del jardín, como cortasetos y sopladores." });
    }
}