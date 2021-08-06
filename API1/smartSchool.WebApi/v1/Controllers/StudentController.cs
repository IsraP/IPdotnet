using System.Collections.Generic;
using System.Linq;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;
using smartSchool.WebApi.v1.DTOs;
using AutoMapper;

namespace smartSchool.WebApi.v1.Controllers
{
    ///
    /// 
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")] // api/nomedacontroler
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public StudentController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        /// <summary>
        /// Retorna todos os alunos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.getAllStudents(true);

            return Ok(_mapper.Map<IEnumerable<StudentDTO>>(result));
        }


        // /// <summary>
        // /// Retorna apenas um registro de aluno DTO
        // /// </summary>
        // /// <returns></returns>
        // [HttpGet("getRegister")]
        // public IActionResult GetRegister()
        // {
        //     return Ok(new StudentRegisterDTO());
        // }


        /// <summary>
        /// Retorna um aluno por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var student = _repo.getStudentById(id, false);
            if (student == null) return BadRequest("Student not found");

            return Ok(_mapper.Map<StudentDTO>(student));
        }

        // [HttpGet("byName")]
        // public IActionResult GetByName(string name, string secondname)
        // {
        //     var student = _context.Students.FirstOrDefault(a => a.Name.Contains(name) &&
        //                       a.SecondName.Contains(secondname));

        //     if (student == null) return BadRequest("Student not found");

        //     return Ok(student);
        // }

        /// <summary>
        /// Adiciona um aluno
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(StudentRegisterDTO model)
        {
            var student = _mapper.Map<Student>(model);

            _repo.Add(student);
            if (_repo.SaveChanges())
                return Created($"/api/Student{model.Id}", _mapper.Map<StudentDTO>(model));

            return BadRequest("Student not created");
        }

        /// <summary>
        /// Atualiza um aluno por put
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, StudentRegisterDTO model)
        {
            var studentOld = _repo.getStudentById(id, false);

            if (studentOld == null)
                return BadRequest("Student not found");

            _mapper.Map(model, studentOld);

            _repo.Update(studentOld);
            if (_repo.SaveChanges())
                return Created($"/api/Student{model.Id}", _mapper.Map<StudentDTO>(model));

            return BadRequest("Student not updated");
        }

        /// <summary>
        /// Atualiza um aluno por patch
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, StudentRegisterDTO model)
        {
            var studentOld = _repo.getStudentById(id, false);

            if (studentOld == null)
                return BadRequest("Student not found");

            _mapper.Map(model, studentOld);

            _repo.Update(studentOld);
            if (_repo.SaveChanges())
                return Created($"/api/Student{model.Id}", _mapper.Map<StudentDTO>(model));

            return BadRequest("Student not updated");
        }

        /// <summary>
        /// Deleta um aluno
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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