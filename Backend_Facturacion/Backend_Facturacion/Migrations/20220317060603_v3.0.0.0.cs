using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Facturacion.Migrations
{
    public partial class v3000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClientesId_Cliente",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_ProductosId_Producto",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ClientesId_Cliente",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ProductosId_Producto",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ClientesId_Cliente",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ProductosId_Producto",
                table: "Ventas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientesId_Cliente",
                table: "Ventas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductosId_Producto",
                table: "Ventas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClientesId_Cliente",
                table: "Ventas",
                column: "ClientesId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductosId_Producto",
                table: "Ventas",
                column: "ProductosId_Producto");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_ClientesId_Cliente",
                table: "Ventas",
                column: "ClientesId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_ProductosId_Producto",
                table: "Ventas",
                column: "ProductosId_Producto",
                principalTable: "Productos",
                principalColumn: "Id_Producto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
