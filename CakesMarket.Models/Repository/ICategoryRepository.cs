using CakesMarket.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.Models.Repository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAll();
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);
    }
}
