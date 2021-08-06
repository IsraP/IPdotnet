using System;
using System.Collections.Generic;

namespace smartSchool.WebApi.Models
{
    public class Teacher
    {
        public Teacher()
        {

        }

        public Teacher(int id, int registration, string name, string secondName)
        {
            this.Id = id;
            this.Name = name;
            this.SecondName = secondName;
            this.Registration = registration;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Registration { get; set; }
        public string Phone { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? GraduationDate { get; set; } = null;
    }
}