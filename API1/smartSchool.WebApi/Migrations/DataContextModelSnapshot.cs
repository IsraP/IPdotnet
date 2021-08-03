﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace smartSchool.WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("smartSchool.WebApi.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Maths",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physics",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Portuguese",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "English",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Programming",
                            TeacherId = 5
                        });
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Isra",
                            Phone = "33225555",
                            SecondName = "Peres"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ra",
                            Phone = "3354288",
                            SecondName = "Lopes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Samuel",
                            Phone = "55668899",
                            SecondName = "Influentes"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Coz",
                            Phone = "6565659",
                            SecondName = "Godz"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Luiza",
                            Phone = "565685415",
                            SecondName = "Ribeiro"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Leo",
                            Phone = "456454545",
                            SecondName = "Lol"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Rubens",
                            Phone = "9874512",
                            SecondName = "J"
                        });
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.StudentDiscipline", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("StudentDisciplines");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 5
                        });
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Claudin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Robertin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clebin"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rogerin"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gaulesin"
                        });
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Discipline", b =>
                {
                    b.HasOne("smartSchool.WebApi.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.StudentDiscipline", b =>
                {
                    b.HasOne("smartSchool.WebApi.Models.Discipline", "Discipline")
                        .WithMany("StudentsDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smartSchool.WebApi.Models.Student", "Student")
                        .WithMany("Disciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Discipline", b =>
                {
                    b.Navigation("StudentsDisciplines");
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Student", b =>
                {
                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("smartSchool.WebApi.Models.Teacher", b =>
                {
                    b.Navigation("Disciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
