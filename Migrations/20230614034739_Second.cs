using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManager.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subcategoria",
                table: "Categorias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subcategoria",
                table: "Categorias",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "Subcategoria",
                value: "Herramientas de mano");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "Subcategoria",
                value: "Cemento y hormigón");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "Subcategoria",
                value: "Tornillos y clavos");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4,
                column: "Subcategoria",
                value: "Pinturas al óleo");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 5,
                column: "Subcategoria",
                value: "Tuberías de PVC");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 6,
                column: "Subcategoria",
                value: "Bombillas LED");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 7,
                column: "Subcategoria",
                value: "Cámaras de seguridad");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 8,
                column: "Subcategoria",
                value: "Mangueras y rociadores");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 9,
                column: "Subcategoria",
                value: "Manijas para puertas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 10,
                column: "Subcategoria",
                value: "Casco de seguridad");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 11,
                column: "Subcategoria",
                value: "Soldadora eléctrica");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 12,
                column: "Subcategoria",
                value: "Detergentes y desinfectantes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 13,
                column: "Subcategoria",
                value: "Aceites y lubricantes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 14,
                column: "Subcategoria",
                value: "Cerraduras digitales");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 15,
                column: "Subcategoria",
                value: "Sierras circulares");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 16,
                column: "Subcategoria",
                value: "Cables eléctricos");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 17,
                column: "Subcategoria",
                value: "Pisos de madera");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 18,
                column: "Subcategoria",
                value: "Podadoras de césped");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 19,
                column: "Subcategoria",
                value: "Tornillos autorroscantes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 20,
                column: "Subcategoria",
                value: "Cintas métricas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 21,
                column: "Subcategoria",
                value: "Rodillos de pintura");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 22,
                column: "Subcategoria",
                value: "Válvulas de agua");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 23,
                column: "Subcategoria",
                value: "Máscaras de filtro");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 24,
                column: "Subcategoria",
                value: "Cepillos de carpintero");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 25,
                column: "Subcategoria",
                value: "Papel de lija");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 26,
                column: "Subcategoria",
                value: "Persianas enrollables");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 27,
                column: "Subcategoria",
                value: "Anclas y cadenas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 28,
                column: "Subcategoria",
                value: "Llanas de albañil");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 29,
                column: "Subcategoria",
                value: "Electrodos de soldadura");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 30,
                column: "Subcategoria",
                value: "Chalecos reflectantes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 31,
                column: "Subcategoria",
                value: "Pistolas de aire");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 32,
                column: "Subcategoria",
                value: "Abono orgánico");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 33,
                column: "Subcategoria",
                value: "Bisagras para puertas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 34,
                column: "Subcategoria",
                value: "Pelacables");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 35,
                column: "Subcategoria",
                value: "Aspersores de riego");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 36,
                column: "Subcategoria",
                value: "Martillos demoledores");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 37,
                column: "Subcategoria",
                value: "Escobas y recogedores");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 38,
                column: "Subcategoria",
                value: "Cortadoras de azulejos");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 39,
                column: "Subcategoria",
                value: "Varillas de refuerzo");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 40,
                column: "Subcategoria",
                value: "Cortasetos eléctrico");
        }
    }
}
