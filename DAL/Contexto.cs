using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<OrdenDeCompras> OrdenDeCompras { get; set; }

    public DbSet<Ubicaciones> Ubicaciones { get; set; }
    public DbSet<Inventarios> Inventarios { get; set; }
    public DbSet<RelacionProductoProveedor> RelacionProductoProveedor { get; set; }
    public DbSet<Facturaciones> Facturaciones { get; set; }




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
           new Categorias { CategoriaId = 40, Nombre = "Herramientas de jardín eléctricas", Descripcion = "Herramientas eléctricas para el cuidado del jardín, como cortasetos y sopladores." }
       );

       modelBuilder.Entity<Productos>().HasData(
      new Productos { ProductoId = 1, CodigoBarra = "123456789", CodigoProducto = "ABC123", Nombre = "Martillo", CategoriaId = 1, Fecha = DateTime.Now, Eliminado = false, margen = 30 },
      new Productos { ProductoId = 2, CodigoBarra = "987654321", CodigoProducto = "XYZ789", Nombre = "Taladro", CategoriaId = 2, Fecha = DateTime.Now, Eliminado = false, margen = 25 },
      new Productos { ProductoId = 3, CodigoBarra = "789123456", CodigoProducto = "DEF456", Nombre = "Destornillador", CategoriaId = 1, Fecha = DateTime.Now, Eliminado = false, margen = 40 },
      new Productos { ProductoId = 4, CodigoBarra = "654789123", CodigoProducto = "GHI789", Nombre = "Sierra Circular", CategoriaId = 2, Fecha = DateTime.Now, Eliminado = false, margen = 20 },
      new Productos { ProductoId = 5, CodigoBarra = "246813579", CodigoProducto = "JKL321", Nombre = "Cinta Métrica", CategoriaId = 20, Fecha = DateTime.Now, Eliminado = false, margen = 15 },
      new Productos { ProductoId = 6, CodigoBarra = "135792468", CodigoProducto = "MNO987", Nombre = "Pintura Blanca", CategoriaId = 4, Fecha = DateTime.Now, Eliminado = false, margen = 35 },
      new Productos { ProductoId = 7, CodigoBarra = "369258147", CodigoProducto = "PQR654", Nombre = "Llave Ajustable", CategoriaId = 9, Fecha = DateTime.Now, Eliminado = false, margen = 30 },
      new Productos { ProductoId = 8, CodigoBarra = "258741369", CodigoProducto = "STU321", Nombre = "Broca para Madera", CategoriaId = 2, Fecha = DateTime.Now, Eliminado = false, margen = 25 },
      new Productos { ProductoId = 9, CodigoBarra = "987123654", CodigoProducto = "VWX987", Nombre = "Guantes de Trabajo", CategoriaId = 10, Fecha = DateTime.Now, Eliminado = false, margen = 20 },
      new Productos { ProductoId = 10, CodigoBarra = "741852963", CodigoProducto = "XYZ123", Nombre = "Aspiradora Robot", CategoriaId = 28, Fecha = DateTime.Now, Eliminado = false, margen = 30 },
      new Productos { ProductoId = 11, CodigoBarra = "369852147", CodigoProducto = "BCD789", Nombre = "Pistola de Calor", CategoriaId = 6, Fecha = DateTime.Now, Eliminado = false, margen = 25 },
      new Productos { ProductoId = 12, CodigoBarra = "147852369", CodigoProducto = "EFG987", Nombre = "Cerradura de Seguridad", CategoriaId = 7, Fecha = DateTime.Now, Eliminado = false, margen = 20 },
      new Productos { ProductoId = 13, CodigoBarra = "369741852", CodigoProducto = "HIJ321", Nombre = "Tubería de PVC", CategoriaId = 5, Fecha = DateTime.Now, Eliminado = false, margen = 15 },
      new Productos { ProductoId = 14, CodigoBarra = "852963741", CodigoProducto = "KLM654", Nombre = "Rodillo de Pintura", CategoriaId = 21, Fecha = DateTime.Now, Eliminado = false, margen = 30 },
      new Productos { ProductoId = 15, CodigoBarra = "963741852", CodigoProducto = "NOP789", Nombre = "Cinta de Doble Cara", CategoriaId = 3, Fecha = DateTime.Now, Eliminado = false, margen = 25 },
      new Productos { ProductoId = 16, CodigoBarra = "741258963", CodigoProducto = "QRS987", Nombre = "Escalera de Aluminio", CategoriaId = 11, Fecha = DateTime.Now, Eliminado = false, margen = 20 },
      new Productos { ProductoId = 17, CodigoBarra = "963258741", CodigoProducto = "TUV321", Nombre = "Destornillador de Precisión", CategoriaId = 1, Fecha = DateTime.Now, Eliminado = false, margen = 30 },
      new Productos { ProductoId = 18, CodigoBarra = "852741963", CodigoProducto = "WXY987", Nombre = "Candado de Acero", CategoriaId = 7, Fecha = DateTime.Now, Eliminado = false, margen = 25 },
      new Productos { ProductoId = 19, CodigoBarra = "369147852", CodigoProducto = "ZAB321", Nombre = "Llave Inglesa", CategoriaId = 9, Fecha = DateTime.Now, Eliminado = false, margen = 20 },
      new Productos { ProductoId = 20, CodigoBarra = "741963852", CodigoProducto = "CDE789", Nombre = "Pala de Jardín", CategoriaId = 12, Fecha = DateTime.Now, Eliminado = false, margen = 30 }
  );

        modelBuilder.Entity<Clientes>().HasData(
            new Clientes { ClienteId = 1, Nombre = "John", Apellido = "Doe", Direccion = "123 Main St", Telefono = "555-1234", Cedula = "1234567890", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 2, Nombre = "Jane", Apellido = "Smith", Direccion = "456 Elm St", Telefono = "555-5678", Cedula = "0987654321", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 3, Nombre = "Michael", Apellido = "Johnson", Direccion = "789 Oak St", Telefono = "555-9012", Cedula = "9876543210", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 4, Nombre = "Emily", Apellido = "Brown", Direccion = "321 Pine St", Telefono = "555-3456", Cedula = "0123456789", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 5, Nombre = "David", Apellido = "Miller", Direccion = "654 Cedar St", Telefono = "555-7890", Cedula = "4567890123", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 6, Nombre = "Sarah", Apellido = "Davis", Direccion = "987 Maple Ave", Telefono = "555-2345", Cedula = "3210987654", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 7, Nombre = "Christopher", Apellido = "Wilson", Direccion = "654 Oakwood Dr", Telefono = "555-6789", Cedula = "6789012345", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 8, Nombre = "Jessica", Apellido = "Taylor", Direccion = "321 Elmwood Ln", Telefono = "555-0123", Cedula = "3456789012", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 9, Nombre = "Matthew", Apellido = "Anderson", Direccion = "789 Birchwood Rd", Telefono = "555-4567", Cedula = "8901234567", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 10, Nombre = "Olivia", Apellido = "Thompson", Direccion = "123 Cedarwood Ave", Telefono = "555-8901", Cedula = "5678901234", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 11, Nombre = "Daniel", Apellido = "Martinez", Direccion = "456 Pine Lane", Telefono = "555-3456", Cedula = "4321098765", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 12, Nombre = "Sophia", Apellido = "Garcia", Direccion = "789 Maple Rd", Telefono = "555-7890", Cedula = "5678901234", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 13, Nombre = "Ethan", Apellido = "Lopez", Direccion = "321 Oakwood Dr", Telefono = "555-0123", Cedula = "8901234567", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 14, Nombre = "Ava", Apellido = "Rodriguez", Direccion = "654 Elmwood Ln", Telefono = "555-4567", Cedula = "6789012345", Fecha = DateTime.Now, Eliminado = false },
            new Clientes { ClienteId = 15, Nombre = "Benjamin", Apellido = "Hernandez", Direccion = "987 Birchwood Ave", Telefono = "555-8901", Cedula = "3210987654", Fecha = DateTime.Now, Eliminado = false }
      );

        modelBuilder.Entity<Proveedores>().HasData(
          new Proveedores { ProveedorId = 1, Nombre = "ElectroSuministros S.A.", Telefono = "555-1234", Direccion = "123 Main Street", RNC = "123456789", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 2, Nombre = "ConstruMateriales C. por A.", Telefono = "555-5678", Direccion = "456 Oak Avenue", RNC = "987654321", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 3, Nombre = "Herramientas Profesionales SRL", Telefono = "555-9012", Direccion = "789 Pine Lane", RNC = "456789123", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 4, Nombre = "Productos Químicos Industriales SA", Telefono = "555-3456", Direccion = "987 Elmwood Drive", RNC = "321098765", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 5, Nombre = "Suministros Industriales del Este", Telefono = "555-7890", Direccion = "543 Maple Avenue", RNC = "654321098", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 6, Nombre = "Ferretería La Construcción", Telefono = "555-2345", Direccion = "321 Cedar Street", RNC = "876543210", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 7, Nombre = "Suministros Eléctricos García", Telefono = "555-6789", Direccion = "654 Oakwood Avenue", RNC = "210987654", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 8, Nombre = "Herramientas Martínez", Telefono = "555-0123", Direccion = "987 Elm Street", RNC = "543210987", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 9, Nombre = "Materiales y Acabados Modernos", Telefono = "555-4567", Direccion = "123 Pine Avenue", RNC = "876543219", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 10, Nombre = "Suministros Industriales del Oeste", Telefono = "555-8901", Direccion = "543 Maple Street", RNC = "219876543", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 11, Nombre = "Ferretería González", Telefono = "555-1234", Direccion = "789 Oakwood Avenue", RNC = "765432109", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 12, Nombre = "Distribuidora Industrial Rodríguez", Telefono = "555-5678", Direccion = "987 Cedar Street", RNC = "109876543", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 13, Nombre = "Materiales de Construcción Hernández", Telefono = "555-9012", Direccion = "456 Elm Street", RNC = "432109876", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 14, Nombre = "Suministros Eléctricos Sánchez", Telefono = "555-3456", Direccion = "210 Maple Avenue", RNC = "321098765", Fecha = DateTime.Now, Eliminado = false },
          new Proveedores { ProveedorId = 15, Nombre = "Herramientas y Equipos Jiménez", Telefono = "555-7890", Direccion = "654 Pine Street", RNC = "654321098", Fecha = DateTime.Now, Eliminado = false }

        );



        modelBuilder.Entity<Ubicaciones>().HasData(
            new Ubicaciones { UbicacionId = 1, Pasillo = "A", Estante = "E1", Nivel = 1, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 2, Pasillo = "B", Estante = "E2", Nivel = 2, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 3, Pasillo = "C", Estante = "E3", Nivel = 1, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 4, Pasillo = "A", Estante = "E1", Nivel = 2, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 5, Pasillo = "B", Estante = "E2", Nivel = 1, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 6, Pasillo = "D", Estante = "E4", Nivel = 3, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 7, Pasillo = "A", Estante = "E3", Nivel = 2, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 8, Pasillo = "C", Estante = "E2", Nivel = 1, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 9, Pasillo = "B", Estante = "E4", Nivel = 2, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 10, Pasillo = "D", Estante = "E1", Nivel = 3, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 11, Pasillo = "B", Estante = "E2", Nivel = 4, Ocupado = true, Eliminado = false },
            new Ubicaciones { UbicacionId = 12, Pasillo = "C", Estante = "E3", Nivel = 2, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 13, Pasillo = "A", Estante = "E1", Nivel = 1, Ocupado = true, Eliminado = false },
            new Ubicaciones { UbicacionId = 14, Pasillo = "D", Estante = "E4", Nivel = 3, Ocupado = false, Eliminado = false },
            new Ubicaciones { UbicacionId = 15, Pasillo = "B", Estante = "E3", Nivel = 2, Ocupado = true, Eliminado = false }

        );

    }
}




