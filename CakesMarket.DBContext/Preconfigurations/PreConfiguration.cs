using CakesMarket.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.DBContext.Preconfigurations
{
    public static class PreConfiguration
    {
        public static IEnumerable<Category> GetPreConfigurationCategory() =>
            new List<Category>
            {
                new Category{ Name = "Cake" },
                new Category{ Name = "Pie"}
            };

        public static IEnumerable<Ingredient> GetPreConfigurationIngredients() =>
            new List<Ingredient>
            {
                new Ingredient{ Name = "Decor", Price = 150 },
                new Ingredient{ Name = "Flowers", Price = 15}
            };

        public static IEnumerable<Cake> GetPreConfigurationCakes() =>
            new List<Cake>
            {
                new Cake{ Name = "Napoleon", Price = 250, CategotyId = 1 },
                new Cake{ Name = "Pancake", Price = 15, CategotyId = 2 },
            };
    }
}
