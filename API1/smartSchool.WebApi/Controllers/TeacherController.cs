using System.Linq;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;

namespace smartSchool.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly DataContext _context;

        public TeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Teachers);
        }

        [HttpGet("byId/{id:int}")]
        public IActionResult GetById(int id)
        {
            Teacher tResp = _context.Teachers.FirstOrDefault(t => t.Id == id);

            if (tResp == null)
                return BadRequest("Teacher not found");

            return Ok(tResp);
        }

        [HttpGet("byName/{name}")]
        public IActionResult GetByName(string name)
        {
            Teacher tResp = _context.Teachers.FirstOrDefault(t => t.Name.Contains(name));

            if (tResp == null)
                return BadRequest("Teacher not found");

            return Ok(tResp);
        }

        [HttpPost]
        public IActionResult Post(Teacher t)
        {
            _context.Add(t);
            _context.SaveChanges();

            return Ok(t);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(Teacher t, int id)
        {
            var teacherOld = _context.Students.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (teacherOld == null)
                return BadRequest("Teacher not found");

            _context.Update(t);
            _context.SaveChanges();

            return Ok(t);
        }

        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, Teacher t)
        {
            var teacherOld = _context.Students.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (teacherOld == null)
                return BadRequest("Teacher not found");

            _context.Update(t);
            _context.SaveChanges();

            return Ok(t);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);

            if (teacher == null)
                return BadRequest("Teacher not found");

            _context.Remove(teacher);
            _context.SaveChanges();
            return Ok(teacher);
        }
    }
}