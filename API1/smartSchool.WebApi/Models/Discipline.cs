using System.Collections.Generic;

namespace smartSchool.WebApi.Models
{
    public class Discipline
    {
        public Discipline()
        {

        }
        public Discipline(int id, string name, int TeacherId){
            this.Id = id;
            this.Name = name;
            this.TeacherId = TeacherId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<StudentDiscipline> StudentsDisciplines {get;set;}

    }
}