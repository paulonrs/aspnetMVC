using Microsoft.AspNetCore.Mvc;

namespace aspnetmvc.Controllers
{
    public class DepartamentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
