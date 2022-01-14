using System.Collections.Generic;

namespace CakesMarket.Models.Model
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Photo { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
