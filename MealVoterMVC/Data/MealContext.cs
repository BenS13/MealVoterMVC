using Microsoft.EntityFrameworkCore;

namespace MealVoterMVC.Data
{
    public class MealContext : DbContext
    {
        public MealContext(DbContextOptions<MealContext> options)
            : base(options) 
        {
        }

        public DbSet<MealVoterMVC.Models.Meal>? Meals { get; set; }
    }
}
