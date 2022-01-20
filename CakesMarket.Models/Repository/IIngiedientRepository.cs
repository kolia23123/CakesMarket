using CakesMarket.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.Models.Repository
{
    public interface IIngiedientRepository
    {
        public IEnumerable<Ingredient> GetAll();
        public void Add(Ingredient ingredient);
        public void Update(Ingredient ingredient);
        public void Delete(Ingredient ingredient);
    }
}
