using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImobiliariaWebView.Migrations
{
    public partial class AtualizandoForeignKeyImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_cliente",
                table: "imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_tipo_imovel1",
                table: "imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_imovel_id_cliente",
                table: "imovel",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_id_tipo_imovel1",
                table: "imovel",
                column: "id_tipo_imovel1");

            migrationBuilder.AddForeignKey(
                name: "FK_imovel_cliente_id_cliente",
                table: "imovel",
                column: "id_cliente",
                principalTable: "cliente",
                principalColumn: "id_cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_imovel_tipo_imovel_id_tipo_imovel1",
                table: "imovel",
                column: "id_tipo_imovel1",
                principalTable: "tipo_imovel",
                principalColumn: "id_tipo_imovel",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imovel_cliente_id_cliente",
                table: "imovel");

            migrationBuilder.DropForeignKey(
                name: "FK_imovel_tipo_imovel_id_tipo_imovel1",
                table: "imovel");

            migrationBuilder.DropIndex(
                name: "IX_imovel_id_cliente",
                table: "imovel");

            migrationBuilder.DropIndex(
                name: "IX_imovel_id_tipo_imovel1",
                table: "imovel");

            migrationBuilder.DropColumn(
                name: "id_cliente",
                table: "imovel");

            migrationBuilder.DropColumn(
                name: "id_tipo_imovel1",
                table: "imovel");
        }
    }
}
