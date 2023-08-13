using Microsoft.EntityFrameworkCore;

namespace MealVoterMVC.Data
{
    //Define a class that inherits from DBContext
    //DB context represents a session with the DB
    //It provides methods for quering the database
    public class MealContext : DbContext
    {
        //Constructor for MealContext class
        //Takes a configouration object as input
        //'base' invokes the constructor of the base class DbContext
        //and passes in the configuration object
        public MealContext(DbContextOptions<MealContext> options)
            : base(options) 
        {
        }

        //Property of MealContext class
        //Represents a collection of entities/meals
        public DbSet<MealVoterMVC.Models.Meal>? Meals { get; set; }
    }
}
