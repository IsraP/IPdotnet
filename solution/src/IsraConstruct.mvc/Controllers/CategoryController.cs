using IsraConstruct.domain.DTOs;
using IsraConstruct.domain.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsraConstruct.mvc.Controllers
{
    public class CategoryController : Controller{
        private readonly CategoryStorage _categoryStorage;

        public CategoryController(CategoryStorage categoryStorage){
            _categoryStorage = categoryStorage;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrEdit(){
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDTO dto){
            _categoryStorage.Store(dto);
            return View();
        }
    }
}