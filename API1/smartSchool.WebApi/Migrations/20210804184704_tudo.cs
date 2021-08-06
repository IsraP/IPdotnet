using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace smartSchool.WebApi.Migrations
{
    public partial class tudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registration = table.Column<int>(type: "INTEGER", nullable: false),
                    BornAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    Registration = table.Column<int>(type: "INTEGER", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    IniDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Worlkoad = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    PreRequisiteId = table.Column<int>(type: "INTEGER", nullable: true),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "StudentDisciplines",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false),
                    IniDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: true)
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
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tecnologia da Informação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Sistemas de Informação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ciência da Computação" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 1, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marta", "33225555", 1, new DateTime(2021, 8, 4, 15, 47, 3, 629, DateTimeKind.Local).AddTicks(7177), "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 2, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paula", "3354288", 2, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(101), "Isabela" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 3, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", "55668899", 3, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(120), "Antonia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 4, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luiza", "6565659", 4, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(126), "Maria" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 5, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucas", "565685415", 5, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(132), "Machado" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 6, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pedro", "456454545", 6, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(143), "Alvares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BornAt", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 7, true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paulo", "9874512", 7, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(149), "José" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 1, null, "Lauro", null, 1, new DateTime(2021, 8, 4, 15, 47, 3, 620, DateTimeKind.Local).AddTicks(3460), "Oliveira" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 2, null, "Roberto", null, 2, new DateTime(2021, 8, 4, 15, 47, 3, 624, DateTimeKind.Local).AddTicks(9354), "Soares" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 3, null, "Ronaldo", null, 3, new DateTime(2021, 8, 4, 15, 47, 3, 624, DateTimeKind.Local).AddTicks(9377), "Marconi" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 4, null, "Rodrigo", null, 4, new DateTime(2021, 8, 4, 15, 47, 3, 624, DateTimeKind.Local).AddTicks(9381), "Carvalho" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "GraduationDate", "Name", "Phone", "Registration", "RegistrationDate", "SecondName" },
                values: new object[] { 5, null, "Alexandre", null, 5, new DateTime(2021, 8, 4, 15, 47, 3, 624, DateTimeKind.Local).AddTicks(9383), "Montanha" });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 1, 1, "Matemática", null, 1, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 2, 3, "Matemática", null, 1, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 3, 3, "Física", null, 2, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 4, 1, "Português", null, 3, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 5, 1, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 6, 2, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 7, 3, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 8, 1, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 9, 2, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Worlkoad" },
                values: new object[] { 10, 3, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 1, 2, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 5, 4, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 5, 2, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 5, 1, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 4, 7, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 4, 6, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 4, 5, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 4, 4, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 4, 1, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 3, 7, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 5, 5, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 3, 6, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 2, 7, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 2, 6, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 2, 3, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 2, 2, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 2, 1, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 1, 7, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 1, 6, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 1, 4, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 1, 3, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 3, 3, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "IniDate" },
                values: new object[] { 5, 7, null, null, new DateTime(2021, 8, 4, 15, 47, 3, 630, DateTimeKind.Local).AddTicks(2366) });

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
