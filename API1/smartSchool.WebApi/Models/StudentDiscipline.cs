namespace smartSchool.WebApi.Models
{
    public class StudentDiscipline
    {

        public StudentDiscipline()
        {

        }

        public StudentDiscipline(int idStudent, int idDiscipline)
        {
            this.IdStudent = idStudent;
            this.IdDiscipline = idDiscipline;

        }

        public int IdStudent { get; set; }
        public Student Student { get; set;}
        public int IdDiscipline { get; set; }
        public Discipline Discipline { get; set; }
    }
}