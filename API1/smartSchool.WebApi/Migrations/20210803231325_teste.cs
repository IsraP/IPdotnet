using Microsoft.EntityFrameworkCore.Migrations;

namespace smartSchool.WebApi.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDisciplines",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDisciplines", x => new { x.StudentId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_StudentDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDisciplines_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 1, "Isra", "33225555", "Peres" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 2, "Ra", "3354288", "Lopes" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 3, "Samuel", "55668899", "Influentes" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 4, "Coz", "6565659", "Godz" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 5, "Luiza", "565685415", "Ribeiro" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 6, "Leo", "456454545", "Lol" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 7, "Rubens", "9874512", "J" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Claudin" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Robertin" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Clebin" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Rogerin" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Gaulesin" });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Maths", 1 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Physics", 2 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Portuguese", 3 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "English", 4 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Programming", 5 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 2 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 7 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 6 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 7 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId" },
                values: new object[] { 5, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDisciplines_DisciplineId",
                table: "StudentDisciplines",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDisciplines");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
