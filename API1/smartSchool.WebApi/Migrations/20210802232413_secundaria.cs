using Microsoft.EntityFrameworkCore.Migrations;

namespace smartSchool.WebApi.Migrations
{
    public partial class secundaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "IdTeacher", "Name", "StudentId", "TeacherId" },
                values: new object[] { 1, 1, "Maths", null, null });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "IdTeacher", "Name", "StudentId", "TeacherId" },
                values: new object[] { 2, 2, "Physics", null, null });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "IdTeacher", "Name", "StudentId", "TeacherId" },
                values: new object[] { 3, 3, "Portuguese", null, null });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "IdTeacher", "Name", "StudentId", "TeacherId" },
                values: new object[] { 4, 4, "English", null, null });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "IdTeacher", "Name", "StudentId", "TeacherId" },
                values: new object[] { 5, 5, "Programming", null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 4, 4, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 5, 4, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 4, 5, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 5, 5, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 1, 6, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 2, 6, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 1, 7, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 4, 6, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 1, 4, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 2, 7, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 3, 7, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 4, 7, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 5, 7, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 3, 6, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 3, 3, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 2, 3, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 1, 3, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 5, 2, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 2, 2, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 1, 2, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 5, 1, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 4, 1, null, null });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "IdDiscipline", "IdStudent", "DisciplineId", "StudentId" },
                values: new object[] { 2, 1, null, null });

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
                table: "Students",
                columns: new[] { "Id", "Name", "Phone", "SecondName" },
                values: new object[] { 4, "Coz", "6565659", "Godz" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Rogerin" });

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
                values: new object[] { 5, "Gaulesin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumns: new[] { "IdDiscipline", "IdStudent" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
