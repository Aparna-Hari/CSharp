#pragma warning disable CS8618
/* 
Disabled Warning: "Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable."
We can disable this safely because we know the framework will assign non-null values when it constructs this class for us.
*/
using Microsoft.EntityFrameworkCore;
namespace ChefsNDishes.Models;
// the MyContext class representing a session with our MySQL database, allowing us to query for or save data
public class ChefsNDishesContext : DbContext 
{ 
    public ChefsNDishesContext(DbContextOptions options) : base(options) { }
    // the "Dishes" table name will come from the DbSet property name
    public DbSet<Chef> Chefs { get; set; } 
    public DbSet<Dish> Dishes { get; set; } 
}
