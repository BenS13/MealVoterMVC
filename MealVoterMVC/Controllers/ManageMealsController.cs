using Microsoft.AspNetCore.Mvc;
using MealVoterMVC.Models;
using MealVoterMVC.Services;

namespace MealVoterMVC.Controllers
{
    public class ManageMealsController : Controller
    {
        private readonly MealService _mealService;//Attribute to store an instance of the MealService

        
        public static IList<Meal> Meals { get; set; } = default!;//IList to hold List of meal objects returned from database

        //Inject the MealService into this controller on Ininiation
        public ManageMealsController(MealService mealService)
        {
            _mealService = mealService;
        }


        //GET: "/ManageMeals"
        //Passes List<Meal> Meals list into View
        public IActionResult Index()
        {
            Meals = _mealService.GetMeals();//Get all meals from DB
            return View(Meals);//Returns View /ManageMeals/Index.cshtml
        }

        
        //GET: "/ManageMeals/Create"
        //Renders form to add a new meal
        [HttpGet]
        public IActionResult Create()
        {
            return View();//Returns View /ManageMeals/Create.cshtml
        }

        
        //POST: "/ManageMeals/CreateNew"
        //Takes new Meal object as input parameter from View
        //Adds Meal object to list of Meal objects
        //Will connect DB soon
        [HttpPost]
        public IActionResult CreateNew([Bind("Id", "Name", "Type")] Meal _newMeal)
        {
            if (!ModelState.IsValid || _newMeal == null)//If model passed from Form is not valid or newMeal object is null
            {
                return View("Create");//Return View contaning form
            }
            _mealService.AddMeal(_newMeal);//Call addmeal method in mealService with newmeal to add as input
            return RedirectToAction("Index");//Redirect to index page where List(Meals) displayed
        }

        
        //POST: "/ManageMeals/Delete/{id}"
        //Takes Id of Meal object as parameter input
        //Calls delete method in MealService.cs to delete selected meal from DB
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _mealService.DeleteMeal(id);//Call DeleteMeal method from MealService.cs with id of meal to delete as input
            return RedirectToAction("Index");//Redirect to Index which returns View containing List of meals
        }
    }
}
