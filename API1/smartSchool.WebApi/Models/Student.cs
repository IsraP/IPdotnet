using System;
using System.Collections.Generic;

namespace smartSchool.WebApi.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, int registration, string name, string secondName, string phone, DateTime bornAt)
        {
            this.Id = id;
            this.Registration = registration;
            this.BornAt = bornAt;
            this.Name = name;
            this.SecondName = secondName;
            this.Phone = phone;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Registration { get; set; }
        public bool Active { get; set; } = true;
        public DateTime BornAt { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? GraduationDate { get; set; } = null;
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public IEnumerable<StudentDiscipline> Disciplines { get; set; }
    }
}