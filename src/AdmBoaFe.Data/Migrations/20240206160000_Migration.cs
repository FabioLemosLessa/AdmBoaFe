using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdmBoaFe.Data.Migrations
{
    public partial class MinhaPrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logradouro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogradouroNome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(5)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(9)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logradouro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Condominios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "date", nullable: false),
                    NumeroBlocos = table.Column<int>(type: "int", nullable: false),
                    NumeroTotalUnidades = table.Column<int>(type: "int", nullable: false),
                    AreaTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxaCondominioMensal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContatoSindico = table.Column<string>(type: "varchar(50)", nullable: false),
                    ContatoAdministracao = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoCondominio = table.Column<int>(type: "int", nullable: false),
                    LogradouroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Condominios_Logradouro_LogradouroId",
                        column: x => x.LogradouroId,
                        principalTable: "Logradouro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inquilinos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Documento = table.Column<string>(type: "varchar(20)", nullable: false),
                    TipoInquilino = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    LogradouroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inquilinos_Logradouro_LogradouroId",
                        column: x => x.LogradouroId,
                        principalTable: "Logradouro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Proprietarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoProprietario = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "varchar(20)", nullable: false),
                    LogradouroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proprietarios_Logradouro_LogradouroId",
                        column: x => x.LogradouroId,
                        principalTable: "Logradouro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(500)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(255)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CondominioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogradouroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProprietarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquilinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquilinoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imoveis_Condominios_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Imoveis_Inquilinos_InquilinoId",
                        column: x => x.InquilinoId,
                        principalTable: "Inquilinos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Imoveis_Inquilinos_InquilinoId1",
                        column: x => x.InquilinoId1,
                        principalTable: "Inquilinos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Imoveis_Logradouro_LogradouroId",
                        column: x => x.LogradouroId,
                        principalTable: "Logradouro",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Imoveis_Proprietarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "Proprietarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Condominios_LogradouroId",
                table: "Condominios",
                column: "LogradouroId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_CondominioId",
                table: "Imoveis",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_InquilinoId",
                table: "Imoveis",
                column: "InquilinoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_InquilinoId1",
                table: "Imoveis",
                column: "InquilinoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_LogradouroId",
                table: "Imoveis",
                column: "LogradouroId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_ProprietarioId",
                table: "Imoveis",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquilinos_LogradouroId",
                table: "Inquilinos",
                column: "LogradouroId");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietarios_LogradouroId",
                table: "Proprietarios",
                column: "LogradouroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Condominios");

            migrationBuilder.DropTable(
                name: "Inquilinos");

            migrationBuilder.DropTable(
                name: "Proprietarios");

            migrationBuilder.DropTable(
                name: "Logradouro");
        }
    }
}
