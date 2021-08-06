using System;
using System.Collections.Generic;
using smartSchool.WebApi.Models;

namespace smartSchool.WebApi.v1.DTOs
{
    public class StudentRegisterDTO
    {
        
        public int Id { get; set; }
        public int Registration { get; set; }
        public DateTime BornAt { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? GraduationDate { get; set; } = null;
        public bool Active { get; set; } = true;
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
    }
}