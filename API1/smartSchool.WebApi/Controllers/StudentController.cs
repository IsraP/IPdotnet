using System.Collections.Generic;
using System.Linq;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;

namespace smartSchool.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")] // api/nomedacontroler
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repo;

        public StudentController(IRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.getAllStudents(true));
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var student = _repo.getStudentById(id, false);
            if (student == null) return BadRequest("Student not found");

            return Ok(student);
        }

        // [HttpGet("byName")]
        // public IActionResult GetByName(string name, string secondname)
        // {
        //     var student = _context.Students.FirstOrDefault(a => a.Name.Contains(name) &&
        //                       a.SecondName.Contains(secondname));

        //     if (student == null) return BadRequest("Student not found");

        //     return Ok(student);
        // }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _repo.Add(student);
            if (_repo.SaveChanges())
                return Ok(student);

            return BadRequest("Student not created");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            var studentOld = _repo.getStudentById(id, false);

            if (studentOld == null)
                return BadRequest("Student not found");

            _repo.Update(student);
            if (_repo.SaveChanges())
                return Ok(student);

            return BadRequest("Student not updated");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            var studentOld = _repo.getStudentById(id, false);

            if (studentOld == null)
                return BadRequest("Student not found");

            _repo.Update(student);
            if (_repo.SaveChanges())
                return Ok(student);

            return BadRequest("Student not updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _repo.getStudentById(id, false);

            if (student == null)
                return BadRequest("Student not found");

            _repo.Remove(student);
            if (_repo.SaveChanges())
                return Ok(student);

            return BadRequest("Student not removed");
        }
    }
}