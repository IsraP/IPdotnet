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
    public class StudentController : ControllerBase{
        private readonly DataContext _context;

        public StudentController(DataContext context) {
            _context = context;
        }  

      [HttpGet]
      public IActionResult Get(){
          return Ok(_context.Students);
      }

      [HttpGet("byId/{id}")]
      public IActionResult GetById(int id){
        var student = _context.Students.FirstOrDefault(a => a.Id == id);
        if(student == null) return BadRequest("Student not found");

        return Ok(student);
      }

      [HttpGet("byName")]
      public IActionResult GetByName(string name, string secondname){
        var student = _context.Students.FirstOrDefault(a => a.Name.Contains(name) && 
                          a.SecondName.Contains(secondname));
                          
        if(student == null) return BadRequest("Student not found");

        return Ok(student);
      }

      [HttpPost]
      public IActionResult Post(Student student){
        _context.Add(student);
        _context.SaveChanges();
        return Ok(student);
      }

      [HttpPut("{id}")]
      public IActionResult Put(int id, Student student){
        var studentOld = _context.Students.AsNoTracking().FirstOrDefault(a => a.Id == id);

        if(studentOld == null)
          return BadRequest("Student not found");

        _context.Update(student);
        _context.SaveChanges();
        return Ok(student);
      }

      [HttpPatch("{id}")]
      public IActionResult Patch(int id, Student student){
        var studentOld = _context.Students.AsNoTracking().FirstOrDefault(a => a.Id == id);

        if(studentOld == null)
          return BadRequest("Student not found");

        _context.Update(student);
        _context.SaveChanges();
        return Ok(student);
      }

      [HttpDelete("{id}")]
      public IActionResult Delete(int id){
        var student = _context.Students.FirstOrDefault(a => a.Id == id);

        if(student == null)
          return BadRequest("Student not found");

        _context.Remove(student);
        _context.SaveChanges();
        return Ok();
      }
    }
}