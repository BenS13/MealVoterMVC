using Microsoft.AspNetCore.Mvc;

namespace MealVoterMVC.Controllers
{
    public class ManageMealsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
