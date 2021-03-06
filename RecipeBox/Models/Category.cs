using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Category
  {
    public Item()
    {
      this.Recipe = new HashSet<CategoryRecipe>();
    }
    public int CategoryId { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<CategoryRecipe> Recipes { get; }
  }
}