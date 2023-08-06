using System.ComponentModel.DataAnnotations;

namespace MealVoterMVC.Models
{
    public class Meal
    {
        
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public MealType Type { get; set; }
    }

    public enum MealType { Breakfast, Lunch, Dinner}
}
