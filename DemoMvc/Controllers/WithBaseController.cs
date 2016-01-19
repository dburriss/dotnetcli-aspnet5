using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvc.Controllers
{
    [Route("[controller]")]
    public class WithBaseController : Controller
    {
        public IActionResult Index() => RedirectToAction("Show");

        [HttpGet("show")]
        public IActionResult Show()
        {
            var url = HttpContext.Request.Path;

            return View("Show", url.Value);
        }

        [HttpGet("tags")]
        public IActionResult Tags() => new ViewResult();


        [HttpGet("id")]
        public IActionResult Identity()
        {
            return View(User.Claims);
        }
    }
}
