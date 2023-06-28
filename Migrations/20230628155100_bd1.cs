using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class bd1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturacion_Facturacion_FacturacionId",
                table: "DetalleFacturacion");

            migrationBuilder.DropTable(
                name: "Facturacion");

            migrationBuilder.AddColumn<double>(
                name: "Cantidad",
                table: "DetalleFacturacion",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 28, 11, 50, 59, 805, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturacion_Facturaciones_FacturacionId",
                table: "DetalleFacturacion",
                column: "FacturacionId",
                principalTable: "Facturaciones",
                principalColumn: "FacturacionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturacion_Facturaciones_FacturacionId",
                table: "DetalleFacturacion");

            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "DetalleFacturacion");

            migrationBuilder.CreateTable(
                name: "Facturacion",
                columns: table => new
                {
                    FacturacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturacion", x => x.FacturacionId);
                });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturacion_Facturacion_FacturacionId",
                table: "DetalleFacturacion",
                column: "FacturacionId",
                principalTable: "Facturacion",
                principalColumn: "FacturacionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
