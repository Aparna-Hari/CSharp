#pragma warning disable CS8618
namespace ChefsNDishes.Models;
using System.ComponentModel.DataAnnotations;

public class Dish
{
    [Key]
    public int DishId {get; set;}

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters ")]
    [Display(Name = "Name of Dish")]
    public string Name {get; set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, 2000, ErrorMessage = "must be greater than 0")]
    [Display(Name = "Number of Calories")]
    public int? Calories {get; set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, 5, ErrorMessage = "must be between 1 and 5")]
    [Display(Name = "Tastiness")]
    public int? Tastiness {get; set;}

    [Required(ErrorMessage = "is required")]
    [MinLength(5, ErrorMessage = "must be at least 5 characters ")]
    [Display(Name = "Description")]
    public string Description {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

    [Required(ErrorMessage = "is requried")]
    [Display(Name = "Chef")]
    public int ChefId {get; set;}

    public Chef? Chef {get; set;}

}