using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailTrab.Migrations
{
    public partial class bug2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco");

            migrationBuilder.AlterColumn<long>(
                name: "AlunoId",
                table: "Endereco",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco");

            migrationBuilder.AlterColumn<long>(
                name: "AlunoId",
                table: "Endereco",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                unique: true,
                filter: "[AlunoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Aluno_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id");
        }
    }
}
