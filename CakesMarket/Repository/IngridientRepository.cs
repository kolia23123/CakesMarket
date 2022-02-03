using CakesMarket.DBContext;
using CakesMarket.Models.Model;
using CakesMarket.Models.Repository;
using System.Collections.Generic;

namespace CakesMarket.Web.Repository
{
    public class IngridientRepository : IIngridientRepository
    {
        private readonly DatabaseContext _databaseContext;
        public IngridientRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }
        public IEnumerable<Ingredient> GetAll()
        {
            return _databaseContext.Ingredients;
        }

        public void Add(Ingredient ingredient)
        {
            _databaseContext.Ingredients.AddRange(ingredient);
            _databaseContext.SaveChanges();
        }

        public void Update(Ingredient ingredient)
        {
            _databaseContext.Ingredients.Update(ingredient);
            _databaseContext.SaveChanges();
        }

        public void Delete(Ingredient ingredient)
        {
            _databaseContext.Ingredients.Remove(ingredient);
            _databaseContext.SaveChanges();
        }

    }
}
