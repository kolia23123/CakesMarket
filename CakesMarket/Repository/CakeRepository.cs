using CakesMarket.DBContext;
using CakesMarket.Models.Model;
using CakesMarket.Models.Repository;
using System.Collections.Generic;

namespace CakesMarket.Web.Repository
{
    public class CakeRepository : ICakeRepository
    {
        private readonly DatabaseContext _dbContext;
        public CakeRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Cake cake)
        {
            _dbContext.Cakes.AddRange(cake);
            _dbContext.SaveChanges();
        }

        public void Delete(Cake cake)
        {
            _dbContext.Cakes.Remove(cake);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Cake> GetAll()
        {
            return _dbContext.Cakes;
        }

        public void Update(Cake cake)
        {
            _dbContext.Cakes.Update(cake);
            _dbContext.SaveChanges();   
        }
    }
}
