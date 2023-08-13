using MealVoterMVC.Data;
using MealVoterMVC.Models;

namespace MealVoterMVC.Services
{
    public class MealService
    {
        private readonly MealContext _context = default!;

        public MealService(MealContext context)
        {
            _context = context;
        }

        public IList<Meal> GetMeals()
        {
            if (_context.Meals != null) 
            {
                return _context.Meals.ToList();
            }
            return new List<Meal>();
        }

        public Meal GetMealById(int id)
        {
            if (_context.Meals != null)
            {
                return _context.Meals.Find(id);
            }
            return new Meal();
        }

        public void AddMeal(Meal meal)
        {
            if (_context.Meals != null)
            {
                _context.Meals.Add(meal);
                _context.SaveChanges();
            }
        }

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
