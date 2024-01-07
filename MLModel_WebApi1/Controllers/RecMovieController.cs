using Microsoft.AspNetCore.Mvc;

namespace MLModel_WebApi1.Controllers
{
    public class RecMovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
