using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogos",
                columns: table => new
                {
                    CatalogoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogos", x => x.CatalogoId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    InventarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatalogoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadMinima = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaActualizado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UbicacionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Costo = table.Column<double>(type: "REAL", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.InventarioId);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeCompras",
                columns: table => new
                {
                    OrdenDeCompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CostoTotal = table.Column<double>(type: "REAL", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeCompras", x => x.OrdenDeCompraId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoBarra = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoProducto = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    RNC = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    UbicacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pasillo = table.Column<string>(type: "TEXT", nullable: true),
                    Estante = table.Column<string>(type: "TEXT", nullable: true),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocupado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.UbicacionId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "DetallesCompras",
                columns: table => new
                {
                    DetalleCompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    InventarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    SubTotal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesCompras", x => x.DetalleCompraId);
                    table.ForeignKey(
                        name: "FK_DetallesCompras_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleOrdenDeCompras",
                columns: table => new
                {
                    DetalleOrdenDeCompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrdenDeCompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Solicitante = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrdenDeCompras", x => x.DetalleOrdenDeCompraId);
                    table.ForeignKey(
                        name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeCompraId",
                        column: x => x.OrdenDeCompraId,
                        principalTable: "OrdenDeCompras",
                        principalColumn: "OrdenDeCompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesVenta",
                columns: table => new
                {
                    DetalleVentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    SubTotal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesVenta", x => x.DetalleVentaId);
                    table.ForeignKey(
                        name: "FK_DetallesVenta_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catalogos",
                columns: new[] { "CatalogoId", "Descripcion", "Eliminado", "Fecha", "Nombre" },
                values: new object[,]
                {
                    { 1, "Productos destacados para la temporada de verano", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9838), "Catálogo de Verano" },
                    { 2, "Grandes descuentos en productos de invierno", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9841), "Ofertas de Invierno" },
                    { 3, "Los últimos dispositivos electrónicos y gadgets", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9844), "Catálogo de Electrónicos" },
                    { 4, "Promociones especiales para la temporada de primavera", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9847), "Promociones de Primavera" },
                    { 5, "Tendencias de moda para hombres y mujeres", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9850), "Catálogo de Moda" },
                    { 6, "Ideas y productos para decorar tu hogar", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9852), "Catálogo de Decoración" },
                    { 7, "Descuentos especiales en productos de temporada", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9855), "Promociones de Otoño" },
                    { 8, "Los juguetes más populares para todas las edades", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9858), "Catálogo de Juguetes" },
                    { 9, "Grandes descuentos en el día de Black Friday", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9860), "Ofertas de Black Friday" },
                    { 10, "Los últimos avances en tecnología y electrónica", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9863), "Catálogo de Tecnología" },
                    { 11, "Las últimas tendencias en moda para la temporada primavera-verano", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9866), "Catálogo de Moda Primavera-Verano" },
                    { 12, "Amplia selección de electrodomésticos para el hogar", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9869), "Catálogo de Electrodomésticos" },
                    { 13, "Descuentos especiales para cerrar el año con grandes ahorros", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9872), "Ofertas de Fin de Año" },
                    { 14, "Los mejores libros para disfrutar y ampliar tu biblioteca", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9874), "Catálogo de Libros" },
                    { 15, "Ofertas irresistibles para disfrutar del verano al máximo", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9877), "Promociones de Verano" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Descripcion", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, "Productos relacionados con herramientas manuales y eléctricas.", false, "Herramientas" },
                    { 2, "Materiales necesarios para proyectos de construcción y remodelación.", false, "Materiales de construcción" },
                    { 3, "Productos para fijar y pegar materiales, como tornillos, clavos y adhesivos.", false, "Fijaciones y adhesivos" },
                    { 4, "Productos para pintar y embellecer superficies, incluyendo pinturas y barnices.", false, "Pinturas y acabados" },
                    { 5, "Productos para sistemas de plomería, como tuberías, grifos y accesorios.", false, "Fontanería" },
                    { 6, "Productos relacionados con iluminación, cableado eléctrico y accesorios.", false, "Iluminación y electricidad" },
                    { 7, "Productos para la seguridad del hogar y protección personal, como cerraduras y cascos.", false, "Seguridad y protección" },
                    { 8, "Herramientas y productos para el cuidado y mantenimiento de jardines y áreas verdes.", false, "Ferretería de jardín" },
                    { 9, "Productos para puertas, ventanas y muebles, como manijas, bisagras y cierres.", false, "Herrajes y accesorios" },
                    { 10, "Equipos de protección personal para trabajos industriales y de construcción.", false, "Protección laboral" },
                    { 11, "Máquinas y equipos para soldadura y trabajos de metal.", false, "Equipos de soldadura" },
                    { 12, "Productos químicos y utensilios para la limpieza y mantenimiento del hogar y oficina.", false, "Productos de limpieza" },
                    { 13, "Productos y herramientas para el mantenimiento y reparación de vehículos.", false, "Ferretería automotriz" },
                    { 14, "Productos para proteger y asegurar puertas y ventanas.", false, "Cerraduras y sistemas de seguridad" },
                    { 15, "Herramientas para corte y precisión, como sierras y cuchillas.", false, "Herramientas de corte" },
                    { 16, "Productos y componentes eléctricos, como cables, interruptores y enchufes.", false, "Suministros eléctricos" },
                    { 17, "Materiales para pisos y revestimientos, como baldosas y laminados.", false, "Pisos y revestimientos" },
                    { 18, "Herramientas para el cuidado y mantenimiento del jardín, como podadoras y cortacéspedes.", false, "Herramientas de jardín" },
                    { 19, "Tornillos de diferentes tipos y tamaños para diversas aplicaciones.", false, "Tornillería" },
                    { 20, "Instrumentos para medir longitudes, ángulos y dimensiones.", false, "Herramientas de medición" },
                    { 21, "Accesorios y suministros para pintar, como rodillos y brochas.", false, "Suministros de pintura" },
                    { 22, "Suministros para sistemas de plomería, como tuberías y accesorios de conexión.", false, "Plomería y accesorios" },
                    { 23, "Equipos y máscaras para proteger la respiración en entornos contaminados.", false, "Protección respiratoria" },
                    { 24, "Herramientas para trabajos de carpintería, como sierras y cepillos.", false, "Herramientas de carpintería" },
                    { 25, "Productos para lijar y pulir superficies, como papel de lija y discos abrasivos.", false, "Abrasivos y lijado" },
                    { 26, "Productos para mejorar y complementar ventanas, como persianas y mosquiteros.", false, "Accesorios para ventanas" },
                    { 27, "Productos y equipos para actividades náuticas y marítimas.", false, "Ferretería marina" },
                    { 28, "Herramientas para trabajos de albañilería, como llanas y paletas.", false, "Herramientas de albañilería" },
                    { 29, "Accesorios y suministros para trabajos de soldadura, como electrodos y soldaduras.", false, "Suministros de soldadura" },
                    { 30, "Equipos y dispositivos para la seguridad personal y en el lugar de trabajo.", false, "Productos de seguridad" },
                    { 31, "Herramientas que funcionan con aire comprimido, como pistolas de aire y compresores.", false, "Herramientas de aire comprimido" },
                    { 32, "Productos y suministros para el cuidado de jardines y plantas.", false, "Suministros de jardinería" },
                    { 33, "Productos y accesorios para puertas, como cerraduras y bisagras.", false, "Ferretería para puertas" },
                    { 34, "Herramientas especializadas para trabajos eléctricos, como alicates y pelacables.", false, "Herramientas de electricista" },
                    { 35, "Productos y sistemas para el riego de jardines y áreas verdes.", false, "Sistemas de riego" },
                    { 36, "Herramientas para demolición y trabajos pesados, como martillos y cinceles.", false, "Herramientas de demolición" },
                    { 37, "Productos y utensilios para la limpieza y mantenimiento de espacios.", false, "Suministros de limpieza" },
                    { 38, "Herramientas especializadas para cortar azulejos y cerámicas.", false, "Herramientas de corte de azulejos" },
                    { 39, "Suministros generales para proyectos de construcción y remodelación.", false, "Suministros de construcción" },
                    { 40, "Herramientas eléctricas para el cuidado del jardín, como cortasetos y sopladores.", false, "Herramientas de jardín eléctricas" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Apellido", "Cedula", "Direccion", "Eliminado", "Fecha", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Doe", "1234567890", "123 Main St", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9614), "John", "555-1234" },
                    { 2, "Smith", "0987654321", "456 Elm St", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9621), "Jane", "555-5678" },
                    { 3, "Johnson", "9876543210", "789 Oak St", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9625), "Michael", "555-9012" },
                    { 4, "Brown", "0123456789", "321 Pine St", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9628), "Emily", "555-3456" },
                    { 5, "Miller", "4567890123", "654 Cedar St", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9631), "David", "555-7890" },
                    { 6, "Davis", "3210987654", "987 Maple Ave", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9635), "Sarah", "555-2345" },
                    { 7, "Wilson", "6789012345", "654 Oakwood Dr", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9638), "Christopher", "555-6789" },
                    { 8, "Taylor", "3456789012", "321 Elmwood Ln", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9642), "Jessica", "555-0123" },
                    { 9, "Anderson", "8901234567", "789 Birchwood Rd", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9645), "Matthew", "555-4567" },
                    { 10, "Thompson", "5678901234", "123 Cedarwood Ave", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9649), "Olivia", "555-8901" },
                    { 11, "Martinez", "4321098765", "456 Pine Lane", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9652), "Daniel", "555-3456" },
                    { 12, "Garcia", "5678901234", "789 Maple Rd", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9658), "Sophia", "555-7890" },
                    { 13, "Lopez", "8901234567", "321 Oakwood Dr", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9661), "Ethan", "555-0123" },
                    { 14, "Rodriguez", "6789012345", "654 Elmwood Ln", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9664), "Ava", "555-4567" },
                    { 15, "Hernandez", "3210987654", "987 Birchwood Ave", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9668), "Benjamin", "555-8901" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "CodigoBarra", "CodigoProducto", "Descripcion", "Eliminado", "Fecha", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "123456789", "ABC123", "Martillo de acero con mango de madera", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9480), "Martillo" },
                    { 2, 2, "987654321", "XYZ789", "Taladro eléctrico de alta potencia", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9500), "Taladro" },
                    { 3, 1, "789123456", "DEF456", "Destornillador magnético con puntas intercambiables", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9504), "Destornillador" },
                    { 4, 2, "654789123", "GHI789", "Sierra circular de alta velocidad para cortes precisos", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9507), "Sierra Circular" },
                    { 5, 20, "246813579", "JKL321", "Cinta métrica retráctil de 5 metros", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9511), "Cinta Métrica" },
                    { 6, 4, "135792468", "MNO987", "Pintura blanca mate para interiores", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9514), "Pintura Blanca" },
                    { 7, 9, "369258147", "PQR654", "Llave ajustable de 10 pulgadas", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9519), "Llave Ajustable" },
                    { 8, 2, "258741369", "STU321", "Broca de 8 mm para perforar madera", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9522), "Broca para Madera" },
                    { 9, 10, "987123654", "VWX987", "Guantes de trabajo resistentes al corte, talla L", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9526), "Guantes de Trabajo" },
                    { 10, 28, "741852963", "XYZ123", "Aspiradora robot inteligente con función de mapeo y limpieza programada", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9529), "Aspiradora Robot" },
                    { 11, 6, "963258741", "BCD789", "Pistola de calor de 2000W para trabajos de secado y desoldado", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9532), "Pistola de Calor" },
                    { 12, 7, "147852369", "EFG987", "Cerradura de seguridad para puertas con sistema de doble cerrojo", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9535), "Cerradura de Seguridad" },
                    { 13, 5, "369741852", "HIJ321", "Tubería de PVC de 2 pulgadas, resistente a la corrosión", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9538), "Tubería de PVC" },
                    { 14, 21, "852963741", "KLM654", "Rodillo de pintura de 9 pulgadas con mango ergonómico", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9542), "Rodillo de Pintura" },
                    { 15, 3, "963741852", "NOP789", "Cinta adhesiva de doble cara de alta resistencia, 5 metros", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9545), "Cinta de Doble Cara" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Descripcion", "Direccion", "Eliminado", "Fecha", "Nombre", "RNC", "Telefono" },
                values: new object[,]
                {
                    { 1, "Proveedor de productos eléctricos", "123 Main Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9733), "ElectroSuministros S.A.", "123456789", "555-1234" },
                    { 2, "Proveedor de materiales de construcción", "456 Oak Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9738), "ConstruMateriales C. por A.", "987654321", "555-5678" },
                    { 3, "Proveedor de herramientas", "789 Pine Lane", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9742), "Herramientas Profesionales SRL", "456789123", "555-9012" },
                    { 4, "Proveedor de productos químicos", "987 Elmwood Drive", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9746), "Productos Químicos Industriales SA", "321098765", "555-3456" },
                    { 5, "Proveedor de suministros industriales", "543 Maple Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9749), "Suministros Industriales del Este", "654321098", "555-7890" },
                    { 6, "Proveedor de productos de ferretería", "321 Cedar Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9752), "Ferretería La Construcción", "876543210", "555-2345" },
                    { 7, "Proveedor de suministros eléctricos", "654 Oakwood Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9756), "Suministros Eléctricos García", "210987654", "555-6789" },
                    { 8, "Proveedor de herramientas de mano", "987 Elm Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9759), "Herramientas Martínez", "543210987", "555-0123" },
                    { 9, "Proveedor de materiales de construcción y acabados", "123 Pine Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9763), "Materiales y Acabados Modernos", "876543219", "555-4567" },
                    { 10, "Proveedor de suministros industriales y herramientas", "543 Maple Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9767), "Suministros Industriales del Oeste", "219876543", "555-8901" },
                    { 11, "Proveedor de productos de ferretería y herramientas", "789 Oakwood Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9771), "Ferretería González", "765432109", "555-1234" },
                    { 12, "Proveedor de suministros industriales y equipos", "987 Cedar Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9774), "Distribuidora Industrial Rodríguez", "109876543", "555-5678" },
                    { 13, "Proveedor de materiales de construcción y acabados", "456 Elm Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9777), "Materiales de Construcción Hernández", "432109876", "555-9012" },
                    { 14, "Proveedor de suministros eléctricos y equipos", "210 Maple Avenue", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9780), "Suministros Eléctricos Sánchez", "321098765", "555-3456" },
                    { 15, "Proveedor de herramientas y equipos industriales", "654 Pine Street", false, new DateTime(2023, 6, 14, 9, 25, 51, 890, DateTimeKind.Local).AddTicks(9784), "Herramientas y Equipos Jiménez", "654321098", "555-7890" }
                });

            migrationBuilder.InsertData(
                table: "Ubicaciones",
                columns: new[] { "UbicacionId", "Eliminado", "Estante", "Nivel", "Ocupado", "Pasillo" },
                values: new object[,]
                {
                    { 1, false, "E1", 1, false, "A" },
                    { 2, false, "E2", 2, false, "B" },
                    { 3, false, "E3", 1, false, "C" },
                    { 4, false, "E1", 2, false, "A" },
                    { 5, false, "E2", 1, false, "B" },
                    { 6, false, "E4", 3, false, "D" },
                    { 7, false, "E3", 2, false, "A" },
                    { 8, false, "E2", 1, false, "C" },
                    { 9, false, "E4", 2, false, "B" },
                    { 10, false, "E1", 3, false, "D" },
                    { 11, false, "E2", 4, true, "B" },
                    { 12, false, "E3", 2, false, "C" },
                    { 13, false, "E1", 1, true, "A" },
                    { 14, false, "E4", 3, false, "D" },
                    { 15, false, "E3", 2, true, "B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesCompras_CompraId",
                table: "DetallesCompras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_VentaId",
                table: "DetallesVenta",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DetalleOrdenDeCompras");

            migrationBuilder.DropTable(
                name: "DetallesCompras");

            migrationBuilder.DropTable(
                name: "DetallesVenta");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "OrdenDeCompras");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
