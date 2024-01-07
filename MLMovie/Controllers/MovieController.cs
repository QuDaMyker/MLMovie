using Microsoft.AspNetCore.Mvc;

namespace MLMovie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
