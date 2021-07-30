using IsraConstruct.domain.DTOs;
using IsraConstruct.domain.Products;
using IsraConstruct.mvc.ViewModels;
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
        public IActionResult CreateOrEdit(CategoryViewModel viewModel/*int id*/){
            _categoryStorage.Store(viewModel.Id, viewModel.Name);
            return View();
        }
    }
}