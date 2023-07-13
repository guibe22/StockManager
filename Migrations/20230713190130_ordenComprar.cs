using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class ordenComprar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "costo",
                table: "RelacionProductoProveedor",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "CostoTotal",
                table: "OrdenDeCompras",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadTotal",
                table: "OrdenDeCompras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "OrdenDeCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<double>(
                name: "CostoTotal",
                table: "DetalleOrdenDeCompras",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "Costo",
                table: "DetalleOrdenDeCompras",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

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
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 13, 15, 1, 30, 481, DateTimeKind.Local).AddTicks(4186));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "OrdenDeCompras");

            migrationBuilder.AlterColumn<decimal>(
                name: "costo",
                table: "RelacionProductoProveedor",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostoTotal",
                table: "OrdenDeCompras",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "CantidadTotal",
                table: "OrdenDeCompras",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostoTotal",
                table: "DetalleOrdenDeCompras",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "Costo",
                table: "DetalleOrdenDeCompras",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 11,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 12,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 13,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 14,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 15,
                column: "Fecha",
                value: new DateTime(2023, 7, 10, 20, 31, 59, 263, DateTimeKind.Local).AddTicks(6382));
        }
    }
}
