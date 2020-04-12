using Microsoft.AspNetCore.Mvc;

namespace Dab_aflevering_2.Controllers
{
    public class TeacherController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}