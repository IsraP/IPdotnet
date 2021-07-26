namespace IsraConstruct.mvc.Controllers
{
    public class CategoryController : Controller{
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrEdit(){
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(){
            return View();
        }
    }
}