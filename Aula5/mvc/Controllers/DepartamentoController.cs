using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio.Entities;
using data;

namespace mvc.Controllers {
    public class DepartamentoController : Controller {
        ApplicationDbContext _contexto;

        public DepartamentoController(ApplicationDbContext contexto) {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Salvar() {
            return View();
        }

        public IActionResult Editar(int id) {
            var dpto = _contexto.Departamento.First(d => d.Id == id);
            
            return View("Salvar", dpto);
        } 
        
        public async Task<ActionResult> Deletar(int id) {
            var dpto = _contexto.Departamento.First(d => d.Id == id);
            _contexto.Departamento.Remove(dpto);
            await _contexto.SaveChangesAsync();

            return RedirectToAction("Mostrar");
        }
        
        [HttpPost]
        public async Task<IActionResult> Salvar(Departamento d) {
            if (d.Id == 0)
                _contexto.Departamento.Add(d);
            else{
                var dpto = _contexto.Departamento.First(dep => dep.Id == d.Id);
                dpto.Nome = d.Nome;
            }
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Mostrar");
        }

        public IActionResult Mostrar() {
            var departamentos = _contexto.Departamento.Where(d => d.Ativo).OrderBy(d => d.Nome);

            return departamentos.Any()? View(departamentos.ToList()) : View(new List<Departamento>()); 
        }
    }
}
