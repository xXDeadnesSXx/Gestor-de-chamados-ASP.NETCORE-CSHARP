using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleChamadosRedeSuporte.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rg = table.Column<int>(nullable: false),
                    GraduacaoId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UnidadeId = table.Column<int>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Graduacao_GraduacaoId",
                        column: x => x.GraduacaoId,
                        principalTable: "Graduacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Unidade_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoProblema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Problema = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProblema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FuncionarioId = table.Column<int>(nullable: true),
                    SolicitanteId = table.Column<int>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    TipoProblemaId = table.Column<int>(nullable: true),
                    DescProblema = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamado_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamado_Funcionario_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamado_TipoProblema_TipoProblemaId",
                        column: x => x.TipoProblemaId,
                        principalTable: "TipoProblema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_FuncionarioId",
                table: "Chamado",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_SolicitanteId",
                table: "Chamado",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_TipoProblemaId",
                table: "Chamado",
                column: "TipoProblemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_GraduacaoId",
                table: "Funcionario",
                column: "GraduacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_UnidadeId",
                table: "Funcionario",
                column: "UnidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "TipoProblema");
        }
    }
}
