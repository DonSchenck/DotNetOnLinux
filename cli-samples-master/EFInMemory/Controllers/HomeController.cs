using Microsoft.AspNetCore.Mvc;

namespace EFInMemory
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
    }
}
