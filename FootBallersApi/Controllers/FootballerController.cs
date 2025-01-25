using Microsoft.AspNetCore.Mvc;

namespace FootBallersApi.Controllers
{
    public class FootballerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
