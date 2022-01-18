using CakesMarket.DBContext;
using CakesMarket.Models.Repository;
using CakesMarket.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CakesMarket.Web.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeController(DatabaseContext databaseContext)
        {
            _cakeRepository = new CakeRepository(databaseContext);
        }
        public IActionResult Index()
        {
            return View(_cakeRepository.GetAll());
        }
    }
}
