using Microsoft.AspNetCore.Mvc;
using MealVoterMVC.Models;

namespace MealVoterMVC.Controllers
{
    public class ManageMealsController : Controller
    {
        public static List<Meal> Meals = new List<Meal>();

        //Get: "/ManageMeals"
        public IActionResult Index()
        {
            return View(Meals);//Returns View /ManageMeals/Index.cshtml
        }

        public IActionResult Create()
        {
            return View();//Returns View /ManageMeals/Create.cshtml
        }
    }
}
