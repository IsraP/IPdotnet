using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula4.Models;

namespace Aula4.Controllers {
    public class UserController : Controller{
        [HttpGet]
        public IActionResult Cadastro() {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Cadastro(User u) {
            if (!ModelState.IsValid || (!u.Email.Contains("@"))) {
                ViewBag.valid = "invalido";
            }
            return View(u);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
