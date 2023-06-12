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
                    Subcategoria = table.Column<string>(type: "TEXT", nullable: false),
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
                table: "Categorias",
                columns: new[] { "CategoriaId", "Descripcion", "Eliminado", "Nombre", "Subcategoria" },
                values: new object[,]
                {
                    { 1, "Productos relacionados con herramientas manuales y eléctricas.", false, "Herramientas", "Herramientas de mano" },
                    { 2, "Materiales necesarios para proyectos de construcción y remodelación.", false, "Materiales de construcción", "Cemento y hormigón" },
                    { 3, "Productos para fijar y pegar materiales, como tornillos, clavos y adhesivos.", false, "Fijaciones y adhesivos", "Tornillos y clavos" },
                    { 4, "Productos para pintar y embellecer superficies, incluyendo pinturas y barnices.", false, "Pinturas y acabados", "Pinturas al óleo" },
                    { 5, "Productos para sistemas de plomería, como tuberías, grifos y accesorios.", false, "Fontanería", "Tuberías de PVC" },
                    { 6, "Productos relacionados con iluminación, cableado eléctrico y accesorios.", false, "Iluminación y electricidad", "Bombillas LED" },
                    { 7, "Productos para la seguridad del hogar y protección personal, como cerraduras y cascos.", false, "Seguridad y protección", "Cámaras de seguridad" },
                    { 8, "Herramientas y productos para el cuidado y mantenimiento de jardines y áreas verdes.", false, "Ferretería de jardín", "Mangueras y rociadores" },
                    { 9, "Productos para puertas, ventanas y muebles, como manijas, bisagras y cierres.", false, "Herrajes y accesorios", "Manijas para puertas" },
                    { 10, "Equipos de protección personal para trabajos industriales y de construcción.", false, "Protección laboral", "Casco de seguridad" },
                    { 11, "Máquinas y equipos para soldadura y trabajos de metal.", false, "Equipos de soldadura", "Soldadora eléctrica" },
                    { 12, "Productos químicos y utensilios para la limpieza y mantenimiento del hogar y oficina.", false, "Productos de limpieza", "Detergentes y desinfectantes" },
                    { 13, "Productos y herramientas para el mantenimiento y reparación de vehículos.", false, "Ferretería automotriz", "Aceites y lubricantes" },
                    { 14, "Productos para proteger y asegurar puertas y ventanas.", false, "Cerraduras y sistemas de seguridad", "Cerraduras digitales" },
                    { 15, "Herramientas para corte y precisión, como sierras y cuchillas.", false, "Herramientas de corte", "Sierras circulares" },
                    { 16, "Productos y componentes eléctricos, como cables, interruptores y enchufes.", false, "Suministros eléctricos", "Cables eléctricos" },
                    { 17, "Materiales para pisos y revestimientos, como baldosas y laminados.", false, "Pisos y revestimientos", "Pisos de madera" },
                    { 18, "Herramientas para el cuidado y mantenimiento del jardín, como podadoras y cortacéspedes.", false, "Herramientas de jardín", "Podadoras de césped" },
                    { 19, "Tornillos de diferentes tipos y tamaños para diversas aplicaciones.", false, "Tornillería", "Tornillos autorroscantes" },
                    { 20, "Instrumentos para medir longitudes, ángulos y dimensiones.", false, "Herramientas de medición", "Cintas métricas" },
                    { 21, "Accesorios y suministros para pintar, como rodillos y brochas.", false, "Suministros de pintura", "Rodillos de pintura" },
                    { 22, "Suministros para sistemas de plomería, como tuberías y accesorios de conexión.", false, "Plomería y accesorios", "Válvulas de agua" },
                    { 23, "Equipos y máscaras para proteger la respiración en entornos contaminados.", false, "Protección respiratoria", "Máscaras de filtro" },
                    { 24, "Herramientas para trabajos de carpintería, como sierras y cepillos.", false, "Herramientas de carpintería", "Cepillos de carpintero" },
                    { 25, "Productos para lijar y pulir superficies, como papel de lija y discos abrasivos.", false, "Abrasivos y lijado", "Papel de lija" },
                    { 26, "Productos para mejorar y complementar ventanas, como persianas y mosquiteros.", false, "Accesorios para ventanas", "Persianas enrollables" },
                    { 27, "Productos y equipos para actividades náuticas y marítimas.", false, "Ferretería marina", "Anclas y cadenas" },
                    { 28, "Herramientas para trabajos de albañilería, como llanas y paletas.", false, "Herramientas de albañilería", "Llanas de albañil" },
                    { 29, "Accesorios y suministros para trabajos de soldadura, como electrodos y soldaduras.", false, "Suministros de soldadura", "Electrodos de soldadura" },
                    { 30, "Equipos y dispositivos para la seguridad personal y en el lugar de trabajo.", false, "Productos de seguridad", "Chalecos reflectantes" },
                    { 31, "Herramientas que funcionan con aire comprimido, como pistolas de aire y compresores.", false, "Herramientas de aire comprimido", "Pistolas de aire" },
                    { 32, "Productos y suministros para el cuidado de jardines y plantas.", false, "Suministros de jardinería", "Abono orgánico" },
                    { 33, "Productos y accesorios para puertas, como cerraduras y bisagras.", false, "Ferretería para puertas", "Bisagras para puertas" },
                    { 34, "Herramientas especializadas para trabajos eléctricos, como alicates y pelacables.", false, "Herramientas de electricista", "Pelacables" },
                    { 35, "Productos y sistemas para el riego de jardines y áreas verdes.", false, "Sistemas de riego", "Aspersores de riego" },
                    { 36, "Herramientas para demolición y trabajos pesados, como martillos y cinceles.", false, "Herramientas de demolición", "Martillos demoledores" },
                    { 37, "Productos y utensilios para la limpieza y mantenimiento de espacios.", false, "Suministros de limpieza", "Escobas y recogedores" },
                    { 38, "Herramientas especializadas para cortar azulejos y cerámicas.", false, "Herramientas de corte de azulejos", "Cortadoras de azulejos" },
                    { 39, "Suministros generales para proyectos de construcción y remodelación.", false, "Suministros de construcción", "Varillas de refuerzo" },
                    { 40, "Herramientas eléctricas para el cuidado del jardín, como cortasetos y sopladores.", false, "Herramientas de jardín eléctricas", "Cortasetos eléctrico" }
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
