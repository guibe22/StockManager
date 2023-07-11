using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class addFActutacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Balance = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones",
                columns: table => new
                {
                    FacturacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturaciones", x => x.FacturacionId);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    UbicacionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadTotal = table.Column<int>(type: "INTEGER", nullable: true),
                    CostoTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Detalle = table.Column<string>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    filtrado = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    margen = table.Column<double>(type: "REAL", nullable: false),
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
                name: "RelacionProductoProveedor",
                columns: table => new
                {
                    RelacionProductoProveedorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionProductoProveedor", x => x.RelacionProductoProveedorId);
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
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFacturacion",
                columns: table => new
                {
                    DetalleFacturacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacturacionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad = table.Column<double>(type: "REAL", nullable: false),
                    SubTotal = table.Column<double>(type: "REAL", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturacion", x => x.DetalleFacturacionId);
                    table.ForeignKey(
                        name: "FK_DetalleFacturacion_Facturaciones_FacturacionId",
                        column: x => x.FacturacionId,
                        principalTable: "Facturaciones",
                        principalColumn: "FacturacionId",
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
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    CostoTotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    Aprobado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrdenDeComprasOrdenDeCompraId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrdenDeCompras", x => x.DetalleOrdenDeCompraId);
                    table.ForeignKey(
                        name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                        column: x => x.OrdenDeComprasOrdenDeCompraId,
                        principalTable: "OrdenDeCompras",
                        principalColumn: "OrdenDeCompraId");
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
                    SubTotal = table.Column<double>(type: "REAL", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
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
                columns: new[] { "ClienteId", "Apellido", "Balance", "Cedula", "Direccion", "Eliminado", "Fecha", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Doe", 0.0, "1234567890", "123 Main St", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6289), "John", "555-1234" },
                    { 2, "Smith", 0.0, "0987654321", "456 Elm St", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6292), "Jane", "555-5678" },
                    { 3, "Johnson", 0.0, "9876543210", "789 Oak St", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6294), "Michael", "555-9012" },
                    { 4, "Brown", 0.0, "0123456789", "321 Pine St", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6297), "Emily", "555-3456" },
                    { 5, "Miller", 0.0, "4567890123", "654 Cedar St", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6301), "David", "555-7890" },
                    { 6, "Davis", 0.0, "3210987654", "987 Maple Ave", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6303), "Sarah", "555-2345" },
                    { 7, "Wilson", 0.0, "6789012345", "654 Oakwood Dr", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6305), "Christopher", "555-6789" },
                    { 8, "Taylor", 0.0, "3456789012", "321 Elmwood Ln", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6307), "Jessica", "555-0123" },
                    { 9, "Anderson", 0.0, "8901234567", "789 Birchwood Rd", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6309), "Matthew", "555-4567" },
                    { 10, "Thompson", 0.0, "5678901234", "123 Cedarwood Ave", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6311), "Olivia", "555-8901" },
                    { 11, "Martinez", 0.0, "4321098765", "456 Pine Lane", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6313), "Daniel", "555-3456" },
                    { 12, "Garcia", 0.0, "5678901234", "789 Maple Rd", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6315), "Sophia", "555-7890" },
                    { 13, "Lopez", 0.0, "8901234567", "321 Oakwood Dr", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6317), "Ethan", "555-0123" },
                    { 14, "Rodriguez", 0.0, "6789012345", "654 Elmwood Ln", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6318), "Ava", "555-4567" },
                    { 15, "Hernandez", 0.0, "3210987654", "987 Birchwood Ave", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6320), "Benjamin", "555-8901" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "CodigoBarra", "CodigoProducto", "Descripcion", "Eliminado", "Fecha", "Nombre", "Precio", "margen" },
                values: new object[,]
                {
                    { 1, 1, "123456789", "ABC123", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6105), "Martillo", 10.99, 0.0 },
                    { 2, 2, "987654321", "XYZ789", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6127), "Taladro", 99.989999999999995, 0.0 },
                    { 3, 1, "789123456", "DEF456", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6175), "Destornillador", 5.9900000000000002, 0.0 },
                    { 4, 2, "654789123", "GHI789", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6178), "Sierra Circular", 79.989999999999995, 0.0 },
                    { 5, 20, "246813579", "JKL321", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6180), "Cinta Métrica", 7.9900000000000002, 0.0 },
                    { 6, 4, "135792468", "MNO987", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6182), "Pintura Blanca", 19.989999999999998, 0.0 },
                    { 7, 9, "369258147", "PQR654", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6184), "Llave Ajustable", 12.99, 0.0 },
                    { 8, 2, "258741369", "STU321", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6186), "Broca para Madera", 6.9900000000000002, 0.0 },
                    { 9, 10, "987123654", "VWX987", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6188), "Guantes de Trabajo", 9.9900000000000002, 0.0 },
                    { 10, 28, "741852963", "XYZ123", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6190), "Aspiradora Robot", 149.99000000000001, 0.0 },
                    { 11, 6, "963258741", "BCD789", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6192), "Pistola de Calor", 39.990000000000002, 0.0 },
                    { 12, 7, "147852369", "EFG987", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6193), "Cerradura de Seguridad", 29.989999999999998, 0.0 },
                    { 13, 5, "369741852", "HIJ321", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6196), "Tubería de PVC", 3.9900000000000002, 0.0 },
                    { 14, 21, "852963741", "KLM654", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6198), "Rodillo de Pintura", 14.99, 0.0 },
                    { 15, 3, "963741852", "NOP789", null, false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6200), "Cinta de Doble Cara", 2.9900000000000002, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Direccion", "Eliminado", "Fecha", "Nombre", "RNC", "Telefono" },
                values: new object[,]
                {
                    { 1, "123 Main Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6351), "ElectroSuministros S.A.", "123456789", "555-1234" },
                    { 2, "456 Oak Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6355), "ConstruMateriales C. por A.", "987654321", "555-5678" },
                    { 3, "789 Pine Lane", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6357), "Herramientas Profesionales SRL", "456789123", "555-9012" },
                    { 4, "987 Elmwood Drive", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6359), "Productos Químicos Industriales SA", "321098765", "555-3456" },
                    { 5, "543 Maple Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6362), "Suministros Industriales del Este", "654321098", "555-7890" },
                    { 6, "321 Cedar Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6364), "Ferretería La Construcción", "876543210", "555-2345" },
                    { 7, "654 Oakwood Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6366), "Suministros Eléctricos García", "210987654", "555-6789" },
                    { 8, "987 Elm Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6368), "Herramientas Martínez", "543210987", "555-0123" },
                    { 9, "123 Pine Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6370), "Materiales y Acabados Modernos", "876543219", "555-4567" },
                    { 10, "543 Maple Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6372), "Suministros Industriales del Oeste", "219876543", "555-8901" },
                    { 11, "789 Oakwood Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6374), "Ferretería González", "765432109", "555-1234" },
                    { 12, "987 Cedar Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6376), "Distribuidora Industrial Rodríguez", "109876543", "555-5678" },
                    { 13, "456 Elm Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6378), "Materiales de Construcción Hernández", "432109876", "555-9012" },
                    { 14, "210 Maple Avenue", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6380), "Suministros Eléctricos Sánchez", "321098765", "555-3456" },
                    { 15, "654 Pine Street", false, new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6382), "Herramientas y Equipos Jiménez", "654321098", "555-7890" }
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
                name: "IX_DetalleFacturacion_FacturacionId",
                table: "DetalleFacturacion",
                column: "FacturacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeComprasOrdenDeCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_VentaId",
                table: "DetallesVenta",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DetalleFacturacion");

            migrationBuilder.DropTable(
                name: "DetalleOrdenDeCompras");

            migrationBuilder.DropTable(
                name: "DetallesVenta");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "RelacionProductoProveedor");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.DropTable(
                name: "OrdenDeCompras");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
