using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImobiliariaWebView.Migrations
{
    public partial class MapeandoTabelaBancoImobiliaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "imagem_imovel",
                columns: table => new
                {
                    id_imagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_imovel = table.Column<int>(type: "int", nullable: false),
                    ordem_imagem = table.Column<int>(type: "int", nullable: false),
                    imagem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem_imovel", x => x.id_imagem);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "imovel",
                columns: table => new
                {
                    id_imovel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_locador = table.Column<int>(type: "int", nullable: false),
                    id_tipo_imovel = table.Column<int>(type: "int", nullable: false),
                    titulo_anuncio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao_imovel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logradouro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complemento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bairro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    area_aproximada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quartos = table.Column<int>(type: "int", nullable: false),
                    banheiros = table.Column<int>(type: "int", nullable: false),
                    suite = table.Column<int>(type: "int", nullable: false),
                    vaga_coberta = table.Column<int>(type: "int", nullable: false),
                    vaga_descoberta = table.Column<int>(type: "int", nullable: false),
                    elevador = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    valor_aluguel_proprietario = table.Column<float>(type: "float", nullable: false),
                    taxa_imobiliaria = table.Column<float>(type: "float", nullable: false),
                    valor_condominio = table.Column<float>(type: "float", nullable: false),
                    valor_iptu = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imovel", x => x.id_imovel);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "locacao_imovel",
                columns: table => new
                {
                    id_locacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_imovel = table.Column<int>(type: "int", nullable: false),
                    id_locatario = table.Column<int>(type: "int", nullable: false),
                    data_locacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    periodo_minino_locacao = table.Column<int>(type: "int", nullable: false),
                    data_inicio_vigencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_fim_vigencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    valor_aluguel = table.Column<float>(type: "float", nullable: false),
                    taxa_administracao = table.Column<float>(type: "float", nullable: false),
                    finalidade_locacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locacao_imovel", x => x.id_locacao);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_imovel",
                columns: table => new
                {
                    id_tipo_imovel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_imovel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_imovel", x => x.id_tipo_imovel);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imagem_imovel");

            migrationBuilder.DropTable(
                name: "imovel");

            migrationBuilder.DropTable(
                name: "locacao_imovel");

            migrationBuilder.DropTable(
                name: "tipo_imovel");
        }
    }
}
