using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoletimAPI.Migrations
{
    /// <inheritdoc />
    public partial class InicioDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false),
                    Teste1 = table.Column<int>(type: "int", nullable: false),
                    Teste2 = table.Column<int>(type: "int", nullable: false),
                    Prova2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunoDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplinaProfessor",
                columns: table => new
                {
                    Disciplinasid = table.Column<int>(type: "int", nullable: false),
                    Professoresid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinaProfessor", x => new { x.Disciplinasid, x.Professoresid });
                    table.ForeignKey(
                        name: "FK_DisciplinaProfessor_Disciplinas_Disciplinasid",
                        column: x => x.Disciplinasid,
                        principalTable: "Disciplinas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplinaProfessor_Professores_Professoresid",
                        column: x => x.Professoresid,
                        principalTable: "Professores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoDisciplinas_DisciplinaId",
                table: "AlunoDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaProfessor_Professoresid",
                table: "DisciplinaProfessor",
                column: "Professoresid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoDisciplinas");

            migrationBuilder.DropTable(
                name: "DisciplinaProfessor");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
