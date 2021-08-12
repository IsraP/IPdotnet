using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace smartSchool.WebApi.Migrations
{
    public partial class initMySQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registration = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BornAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SecondName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecondName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registration = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    IniDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Worlkoad = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    PreRequisiteId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplines_Disciplines_PreRequisiteId",
                        column: x => x.PreRequisiteId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentDisciplines",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    IniDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marta", "33225555", 1, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(6898), "Kent" },
                    { 2, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paula", "3354288", 2, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9231), "Isabela" },
                    { 3, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", "55668899", 3, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9253), "Antonia" },
                    { 4, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luiza", "6565659", 4, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9276), "Maria" },
                    { 5, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucas", "565685415", 5, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9283), "Machado" },
                    { 6, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pedro", "456454545", 6, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9294), "Alvares" },
                    { 7, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paulo", "9874512", 7, new DateTime(2021, 8, 11, 16, 31, 0, 140, DateTimeKind.Local).AddTicks(9300), "José" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[,]
                {
                    { 1, null, "Lauro", null, 1, new DateTime(2021, 8, 11, 16, 31, 0, 132, DateTimeKind.Local).AddTicks(3604), "Oliveira" },
                    { 2, null, "Roberto", null, 2, new DateTime(2021, 8, 11, 16, 31, 0, 136, DateTimeKind.Local).AddTicks(2024), "Soares" },
                    { 3, null, "Ronaldo", null, 3, new DateTime(2021, 8, 11, 16, 31, 0, 136, DateTimeKind.Local).AddTicks(2047), "Marconi" },
                    { 4, null, "Rodrigo", null, 4, new DateTime(2021, 8, 11, 16, 31, 0, 136, DateTimeKind.Local).AddTicks(2050), "Carvalho" },
                    { 5, null, "Alexandre", null, 5, new DateTime(2021, 8, 11, 16, 31, 0, 136, DateTimeKind.Local).AddTicks(2053), "Montanha" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[,]
                {
                    { 1, 1, "Matemática", null, 1, 0 },
                    { 2, 3, "Matemática", null, 1, 0 },
                    { 3, 3, "Física", null, 2, 0 },
                    { 4, 1, "Português", null, 3, 0 },
                    { 5, 1, "Inglês", null, 4, 0 },
                    { 6, 2, "Inglês", null, 4, 0 },
                    { 7, 3, "Inglês", null, 4, 0 },
                    { 8, 1, "Programação", null, 5, 0 },
                    { 9, 2, "Programação", null, 5, 0 },
                    { 10, 3, "Programação", null, 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[,]
                {
                    { 1, 2, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1730) },
                    { 5, 4, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1751) },
                    { 5, 2, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1738) },
                    { 5, 1, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1728) },
                    { 4, 7, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1772) },
                    { 4, 6, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1765) },
                    { 4, 5, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1753) },
                    { 4, 4, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1749) },
                    { 4, 1, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1718) },
                    { 3, 7, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1770) },
                    { 5, 5, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1755) },
                    { 3, 6, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1761) },
                    { 2, 7, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1769) },
                    { 2, 6, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1759) },
                    { 2, 3, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1742) },
                    { 2, 2, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1732) },
                    { 2, 1, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(864) },
                    { 1, 7, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1767) },
                    { 1, 6, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1757) },
                    { 1, 4, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1747) },
                    { 1, 3, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1740) },
                    { 3, 3, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1744) },
                    { 5, 7, null, null, new DateTime(2021, 8, 11, 16, 31, 0, 141, DateTimeKind.Local).AddTicks(1774) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_PreRequisiteId",
                table: "Disciplines",
                column: "PreRequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDisciplines_DisciplineId",
                table: "StudentDisciplines",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "StudentDisciplines");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
