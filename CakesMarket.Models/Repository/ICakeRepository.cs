using CakesMarket.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.Models.Repository
{
    public interface ICakeRepository
    {
        public IEnumerable<Cake> GetAll();
        public void Add(Cake cake);
        public void Update(Cake cake);
        public void Delete(int idCake);
    }
}
