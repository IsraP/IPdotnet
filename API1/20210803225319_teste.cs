using Microsoft.EntityFrameworkCore.Migrations;

namespace smartSchool.WebApi.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Students_StudentId",
                table: "Disciplines");

            migrationBuilder.DropIndex(
                name: "IX_Disciplines_StudentId",
                table: "Disciplines");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Disciplines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Disciplines",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_StudentId",
                table: "Disciplines",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Students_StudentId",
                table: "Disciplines",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
