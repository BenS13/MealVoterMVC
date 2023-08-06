using Microsoft.AspNetCore.Mvc;
using MealVoterMVC.Models;

namespace MealVoterMVC.Controllers
{
    public class ManageMealsController : Controller
    {
        public static List<Meal> Meals = new List<Meal>();//Tempary List until DB connected

        //GET: "/ManageMeals"
        //Passes List<Meal> Meals list into View
        public IActionResult Index()
        {
            return View(Meals);//Returns View /ManageMeals/Index.cshtml
        }

        
        //GET: "/ManageMeals/Create
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
        public IActionResult CreateNew(Meal _newMeal)
        {
            Meals.Add(_newMeal);//Add new Meal object to List(Meals)
            return RedirectToAction("Index");//Redirect to index page where List(Meals) displayed
        }

        
        //POST: "/ManageMeals/Delete/{id}"
        //Takes Id of Meal object as parameter input
        //Finds the index of the Meal object in the Meals List where Id=id
        //Removes object from Meals List
        [HttpPost]
        public IActionResult Delete(int id)
        {
            //This will change to act on DB
            int index = Meals.FindIndex(p => p.Id == id);//Find the index of the Meal object that has property Id=id
            Meals.RemoveAt(index);
            return RedirectToAction("Index");//Redirect to Index which returns View containing List of meals
        }
    }
}
