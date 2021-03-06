using System;

namespace smartSchool.WebApi.Models
{
    public class StudentDiscipline
    {

        public StudentDiscipline()
        {

        }

        public StudentDiscipline(int StudentId, int DisciplineId)
        {
            this.StudentId = StudentId;
            this.DisciplineId = DisciplineId;
        }

        public DateTime IniDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public int? Grade { get; set; } = null;
        public int StudentId { get; set; }
        public Student Student { get; set;}
        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }
    }
}