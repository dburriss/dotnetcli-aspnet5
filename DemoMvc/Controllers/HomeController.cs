using Microsoft.AspNet.Mvc;

namespace DemoMvc.Controllers
{
    public class HomeController
    {
        private const string email = "devon@chimplab.co";
        public IActionResult Index() => new ViewResult();

        [HttpGet("/contactaddress")]
        public string ContactAddress() => email;
    }
}
