using System;
using smartSchool.WebApi.Models;

namespace smartSchool.WebApi.v1.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public int Registration { get; set; }
        public int Age { get; set; }
        public DateTime BornAt { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
    }
}