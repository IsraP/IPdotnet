using System.Collections.Generic;

namespace smartSchool.WebApi.Models{
    public class Student{
        public Student(){

        }

        public Student(int id, string name, string sname, string phone){
            this.Id = id;
            this.Name = name;
            this.SecondName = sname;
            this.Phone = phone;
        }

        public int Id {get; set;}
        public string Name {get; set;}
        public string SecondName {get; set;}
        public string Phone {get; set;}
        public IEnumerable<StudentDiscipline> Disciplines { get; set; }
    }
}