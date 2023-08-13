using MealVoterMVC.Data;
using MealVoterMVC.Models;

namespace MealVoterMVC.Services
{
    public class MealService
    {
        private readonly MealContext _context = default!;//Hold instance of MealContext (Database Connection)

        public MealService(MealContext context)//Retrive an instance of MealContext on Instantation
        {
            _context = context;
        }


        //Method to retrive all meals from DB
        public IList<Meal> GetMeals()
        {
            if (_context.Meals != null) //If there are meals in DB
            {
                return _context.Meals.ToList();//Convert to List and return
            }
            return new List<Meal>();//Else, return an empty List of type Meal
        }

        //Method to get a meal by its id
        public Meal GetMealById(int id)
        {
            if (_context.Meals != null)
            {
                return _context.Meals.Find(id);
            }
            return new Meal();
        }

        //Method to add a new meal to the DB
        public void AddMeal(Meal meal)
        {
            if (_context.Meals != null)
            {
                _context.Meals.Add(meal);
                _context.SaveChanges();
            }
        }


        //Method to delete a meal from DB by id
        public void DeleteMeal(int id)
        {
            if (_context.Meals != null)
            {
                var meal = _context.Meals.Find(id);
                if (meal != null) 
                {
                    _context.Meals.Remove(meal);
                    _context.SaveChanges();
                }
            }
        }
    }
}
