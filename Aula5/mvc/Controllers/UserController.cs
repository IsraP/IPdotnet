using data;
using dominio.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Controllers
{
    public class UserController : Controller{

        ApplicationDbContext _contexto;

        public UserController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Salvar(){
            ViewBag.Departamentos = _contexto.Departamento.ToList();

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Salvar(User u){
            if (u.Id == 0)
                _contexto.Add(u);
            else{
                var user = _contexto.User.First(user => user.Id == u.Id);
                user.Update(u);
            }

            await _contexto.SaveChangesAsync();
            return RedirectToAction("Mostrar");
        }

        public async Task<IActionResult> Deletar(int id){
            var user = _contexto.User.First(u => u.Id == id);
            _contexto.User.Remove(user);

            await _contexto.SaveChangesAsync();

            return RedirectToAction("Mostrar");
        }

        public IActionResult Mostrar()
        {
            var users = _contexto.User.ToList();

            return View(users);
        }

        public IActionResult Editar(int id){
            var user = _contexto.User.First(u => u.Id == id);

            ViewBag.Departamentos = _contexto.Departamento.ToList();

            return View("Salvar", user);
        }

    }
}
