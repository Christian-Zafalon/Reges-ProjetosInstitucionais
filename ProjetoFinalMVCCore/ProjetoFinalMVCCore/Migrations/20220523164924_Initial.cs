using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalMVCCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cursoId = table.Column<int>(type: "int", nullable: false),
                    materia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargaHoraria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Curso_cursoId",
                        column: x => x.cursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_professor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    formacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_cursoId",
                table: "Curso",
                column: "cursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
