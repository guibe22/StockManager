using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class forr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras");

            migrationBuilder.DropIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras");

            migrationBuilder.DropColumn(
                name: "OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "CodigoBarra", "CodigoProducto", "Descripcion", "Eliminado", "Fecha", "Nombre", "Precio", "margen" },
                values: new object[,]
                {
                    { 1, 1, "123456789", "ABC123", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6032), "Martillo", 0.0, 30.0 },
                    { 2, 2, "987654321", "XYZ789", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6054), "Taladro", 0.0, 25.0 },
                    { 3, 1, "789123456", "DEF456", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6058), "Destornillador", 0.0, 40.0 },
                    { 4, 2, "654789123", "GHI789", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6061), "Sierra Circular", 0.0, 20.0 },
                    { 5, 20, "246813579", "JKL321", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6064), "Cinta Métrica", 0.0, 15.0 },
                    { 6, 4, "135792468", "MNO987", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6067), "Pintura Blanca", 0.0, 35.0 },
                    { 7, 9, "369258147", "PQR654", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6073), "Llave Ajustable", 0.0, 30.0 },
                    { 8, 2, "258741369", "STU321", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6076), "Broca para Madera", 0.0, 25.0 },
                    { 9, 10, "987123654", "VWX987", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6079), "Guantes de Trabajo", 0.0, 20.0 },
                    { 10, 28, "741852963", "XYZ123", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6085), "Aspiradora Robot", 0.0, 30.0 },
                    { 11, 6, "369852147", "BCD789", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6088), "Pistola de Calor", 0.0, 25.0 },
                    { 12, 7, "147852369", "EFG987", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6091), "Cerradura de Seguridad", 0.0, 20.0 },
                    { 13, 5, "369741852", "HIJ321", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6097), "Tubería de PVC", 0.0, 15.0 },
                    { 14, 21, "852963741", "KLM654", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6100), "Rodillo de Pintura", 0.0, 30.0 },
                    { 15, 3, "963741852", "NOP789", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6104), "Cinta de Doble Cara", 0.0, 25.0 },
                    { 16, 11, "741258963", "QRS987", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6109), "Escalera de Aluminio", 0.0, 20.0 },
                    { 17, 1, "963258741", "TUV321", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6112), "Destornillador de Precisión", 0.0, 30.0 },
                    { 18, 7, "852741963", "WXY987", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6115), "Candado de Acero", 0.0, 25.0 },
                    { 19, 9, "369147852", "ZAB321", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6121), "Llave Inglesa", 0.0, 20.0 },
                    { 20, 12, "741963852", "CDE789", null, false, new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6124), "Pala de Jardín", 0.0, 30.0 }
                });

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 28, 25, 339, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeCompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeCompraId",
                principalTable: "OrdenDeCompras",
                principalColumn: "OrdenDeCompraId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeCompraId",
                table: "DetalleOrdenDeCompras");

            migrationBuilder.DropIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeCompraId",
                table: "DetalleOrdenDeCompras");

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15);

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

            migrationBuilder.AddColumn<int>(
                name: "OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 18, 14, 26, 24, 252, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeComprasOrdenDeCompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrdenDeCompras_OrdenDeCompras_OrdenDeComprasOrdenDeCompraId",
                table: "DetalleOrdenDeCompras",
                column: "OrdenDeComprasOrdenDeCompraId",
                principalTable: "OrdenDeCompras",
                principalColumn: "OrdenDeCompraId");
        }
    }
}
