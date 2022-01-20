using CakesMarket.DBContext;
using CakesMarket.Models.Model;
using CakesMarket.Models.Repository;
using System.Collections.Generic;

namespace CakesMarket.Web.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext _databaseContext;
        public CategoryRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }
        public IEnumerable<Category> GetAll()
        {
            return _databaseContext.Categories;
        }
        public void AddCategory(Category category)
        {
            _databaseContext.Categories.AddRange(category);
            _databaseContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _databaseContext.Categories.Update(category);
            _databaseContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _databaseContext.Categories.Remove(category);
            _databaseContext.SaveChanges();
        }
    }
}
