using CakesMarket.Models.Model;
using CakesMarket.Models.ViewModel;

namespace CakesMarket.Models.Services
{
    public interface ICakeService
    {
        public CakesListViewModel GetAll();
        public void Add(Cake cake);
        public void Update(Cake cake);
        public void Remove(Cake cake);
    }
}
