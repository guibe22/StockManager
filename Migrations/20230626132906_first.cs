using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta");

            migrationBuilder.AlterColumn<double>(
                name: "margen",
                table: "Productos",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Productos",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "DetallesVenta",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1806), 10.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1828), 99.989999999999995, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1832), 5.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1835), 79.989999999999995, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1841), 7.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1845), 19.989999999999998, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1848), 12.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1851), 6.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1855), 9.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1857), 149.99000000000001, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1860), 39.990000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1863), 29.989999999999998, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1867), 3.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1870), 14.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 9, 29, 5, 654, DateTimeKind.Local).AddTicks(1872), 2.9900000000000002, 0.0 });

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
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta");

            migrationBuilder.AlterColumn<decimal>(
                name: "margen",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "DetallesVenta",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4822), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4832), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4834), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4836), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4837), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4839), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4840), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4842), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4843), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4845), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4846), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4847), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4848), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4850), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4851), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 6, 26, 0, 0, 46, 399, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "VentaId");
        }
    }
}
