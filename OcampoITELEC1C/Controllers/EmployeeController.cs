using Microsoft.AspNetCore.Mvc;

namespace OcampoITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
