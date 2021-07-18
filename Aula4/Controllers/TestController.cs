using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula4.Controllers {
    public class TestController : Controller {
        [Route("api/noclue")]

        public string Get() {
            return HttpContext.Request.Path;
        }
    }
}
