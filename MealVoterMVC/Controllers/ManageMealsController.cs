using Microsoft.AspNetCore.Mvc;

namespace MealVoterMVC.Controllers
{
    public class ManageMealsController : Controller
    {
        //Get: "/ManageMeals"
        public IActionResult Index()
        {
            return View();//Returns View /ManageMeals/Index.cshtml
        }
    }
}
