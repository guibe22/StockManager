using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "OrdenDeCompras");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5188), 0.0, 30.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5200), 0.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5203), 0.0, 40.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5205), 0.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5206), 0.0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5208), 0.0, 35.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5210), 0.0, 30.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5212), 0.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5214), 0.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5215), 0.0, 30.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "CodigoBarra", "Fecha", "Precio", "margen" },
                values: new object[] { "369852147", new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5217), 0.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5219), 0.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5220), 0.0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5225), 0.0, 30.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5227), 0.0, 25.0 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "CodigoBarra", "CodigoProducto", "Descripcion", "Eliminado", "Fecha", "Nombre", "Precio", "margen" },
                values: new object[,]
                {
                    { 16, 11, "741258963", "QRS987", null, false, new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5228), "Escalera de Aluminio", 0.0, 20.0 },
                    { 17, 1, "963258741", "TUV321", null, false, new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5230), "Destornillador de Precisión", 0.0, 30.0 },
                    { 18, 7, "852741963", "WXY987", null, false, new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5232), "Candado de Acero", 0.0, 25.0 },
                    { 19, 9, "369147852", "ZAB321", null, false, new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5233), "Llave Inglesa", 0.0, 20.0 },
                    { 20, 12, "741963852", "CDE789", null, false, new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5235), "Pala de Jardín", 0.0, 30.0 }
                });

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 14, 14, 50, 40, 217, DateTimeKind.Local).AddTicks(5359));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 20);

            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "OrdenDeCompras",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4124), 10.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4142), 99.989999999999995, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4146), 5.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4149), 79.989999999999995, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4153), 7.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4156), 19.989999999999998, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4160), 12.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4163), 6.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4166), 9.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4169), 149.99000000000001, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "CodigoBarra", "Fecha", "Precio", "margen" },
                values: new object[] { "963258741", new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4173), 39.990000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4176), 29.989999999999998, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4179), 3.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4182), 14.99, 0.0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "Fecha", "Precio", "margen" },
                values: new object[] { new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4186), 2.9900000000000002, 0.0 });

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4426));
        }
    }
}
