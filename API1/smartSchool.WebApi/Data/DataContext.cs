using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;

namespace Data
{
    public class DataContext : DbContext{
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<StudentDiscipline> StudentDisciplines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<StudentDiscipline>().HasKey(SD => new {SD.IdStudent, SD.IdDiscipline});

            builder.Entity<Teacher>()
            .HasData(new List<Teacher> {
                new Teacher(1, "Claudin"),
                new Teacher(2, "Robertin"),
                new Teacher(3, "Clebin"),
                new Teacher(4, "Rogerin"),
                new Teacher(5, "Gaulesin"),
            });

                        builder.Entity<Discipline>()
                .HasData(new List<Discipline>{
                    new Discipline(1, "Maths", 1),
                    new Discipline(2, "Physics", 2),
                    new Discipline(3, "Portuguese", 3),
                    new Discipline(4, "English", 4),
                    new Discipline(5, "Programming", 5)
                });
            
            builder.Entity<Student>()
                .HasData(new List<Student>(){
                    new Student(1, "Isra", "Peres", "33225555"),
                    new Student(2, "Ra", "Lopes", "3354288"),
                    new Student(3, "Samuel", "Influentes", "55668899"),
                    new Student(4, "Coz", "Godz", "6565659"),
                    new Student(5, "Luiza", "Ribeiro", "565685415"),
                    new Student(6, "Leo", "Lol", "456454545"),
                    new Student(7, "Rubens", "J", "9874512")
                });

            builder.Entity<StudentDiscipline>()
                .HasData(new List<StudentDiscipline>() {
                    new StudentDiscipline() {IdStudent = 1, IdDiscipline = 2 },
                    new StudentDiscipline() {IdStudent = 1, IdDiscipline = 4 },
                    new StudentDiscipline() {IdStudent = 1, IdDiscipline = 5 },
                    new StudentDiscipline() {IdStudent = 2, IdDiscipline = 1 },
                    new StudentDiscipline() {IdStudent = 2, IdDiscipline = 2 },
                    new StudentDiscipline() {IdStudent = 2, IdDiscipline = 5 },
                    new StudentDiscipline() {IdStudent = 3, IdDiscipline = 1 },
                    new StudentDiscipline() {IdStudent = 3, IdDiscipline = 2 },
                    new StudentDiscipline() {IdStudent = 3, IdDiscipline = 3 },
                    new StudentDiscipline() {IdStudent = 4, IdDiscipline = 1 },
                    new StudentDiscipline() {IdStudent = 4, IdDiscipline = 4 },
                    new StudentDiscipline() {IdStudent = 4, IdDiscipline = 5 },
                    new StudentDiscipline() {IdStudent = 5, IdDiscipline = 4 },
                    new StudentDiscipline() {IdStudent = 5, IdDiscipline = 5 },
                    new StudentDiscipline() {IdStudent = 6, IdDiscipline = 1 },
                    new StudentDiscipline() {IdStudent = 6, IdDiscipline = 2 },
                    new StudentDiscipline() {IdStudent = 6, IdDiscipline = 3 },
                    new StudentDiscipline() {IdStudent = 6, IdDiscipline = 4 },
                    new StudentDiscipline() {IdStudent = 7, IdDiscipline = 1 },
                    new StudentDiscipline() {IdStudent = 7, IdDiscipline = 2 },
                    new StudentDiscipline() {IdStudent = 7, IdDiscipline = 3 },
                    new StudentDiscipline() {IdStudent = 7, IdDiscipline = 4 },
                    new StudentDiscipline() {IdStudent = 7, IdDiscipline = 5 }
                });
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}