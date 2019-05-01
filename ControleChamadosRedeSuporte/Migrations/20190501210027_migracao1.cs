using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleChamadosRedeSuporte.Migrations
{
    public partial class migracao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Graduacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Grad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graduacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rg = table.Column<int>(nullable: false),
                    GraduacaoId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UnidadeId = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Unidade_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoProblema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Problema = table.Column<string>(nullable: true),
                    FuncionarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProblema", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoProblema_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FuncionarioId1 = table.Column<int>(nullable: true),
                    FuncionarioIdId = table.Column<int>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    TipoProblemaId = table.Column<int>(nullable: true),
                    DescProblema = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamado_Funcionario_FuncionarioId1",
                        column: x => x.FuncionarioId1,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamado_Funcionario_FuncionarioIdId",
                        column: x => x.FuncionarioIdId,
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
                name: "IX_Chamado_FuncionarioId1",
                table: "Chamado",
                column: "FuncionarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_FuncionarioIdId",
                table: "Chamado",
                column: "FuncionarioIdId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TipoProblema_FuncionarioId",
                table: "TipoProblema",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "TipoProblema");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Graduacao");

            migrationBuilder.DropTable(
                name: "Unidade");
        }
    }
}
