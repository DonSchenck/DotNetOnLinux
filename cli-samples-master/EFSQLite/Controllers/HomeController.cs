using Microsoft.AspNetCore.Mvc;

namespace EFSQLite
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
    }
}
