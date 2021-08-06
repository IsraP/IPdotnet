using System.Linq;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;

namespace smartSchool.WebApi.v2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repo;

        public TeacherController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.getAllTeachers(true));
        }

        [HttpGet("byId/{id:int}")]
        public IActionResult GetById(int id)
        {
            Teacher tResp = _repo.getTeacherById(id, false);

            if (tResp == null)
                return BadRequest("Teacher not found");

            return Ok(tResp);
        }

        // [HttpGet("byName/{name}")]
        // public IActionResult GetByName(string name)
        // {
        //     Teacher tResp = _context.Teachers.FirstOrDefault(t => t.Name.Contains(name));

        //     if (tResp == null)
        //         return BadRequest("Teacher not found");

        //     return Ok(tResp);
        // }

        [HttpPost]
        public IActionResult Post(Teacher teacher)
        {
            _repo.Add(teacher);
            if (_repo.SaveChanges())
                return Ok(teacher);

            return BadRequest("Teacher not found");
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(Teacher t, int id)
        {
            var teacherOld = _repo.getTeacherById(id, false);

            if (teacherOld == null)
                return BadRequest("Teacher not found");

            _repo.Update(t);
            if (_repo.SaveChanges())
                return Ok(t);

            return BadRequest("Teacher not updated");
        }

        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, Teacher t)
        {
            var teacherOld = _repo.getTeacherById(id, false);

            if (teacherOld == null)
                return BadRequest("Teacher not found");

            _repo.Update(t);
            if (_repo.SaveChanges())
                return Ok(t);

            return BadRequest("Teacher not updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _repo.getTeacherById(id, false);

            if (teacher == null)
                return BadRequest("Teacher not found");

            _repo.Remove(teacher);
            if (_repo.SaveChanges())
                return Ok(teacher);

            return BadRequest("Teacher not deleted");
        }
    }
}