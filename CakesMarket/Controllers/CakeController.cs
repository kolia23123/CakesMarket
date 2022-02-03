using CakesMarket.Models.Model;
using CakesMarket.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace CakesMarket.Web.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeService _cakeService;

        public CakeController(ICakeService cakeService )
        {
            this._cakeService = cakeService;
        }
        public IActionResult Index()
        {
            return View(_cakeService.GetAll());
        }

        public ActionResult AddCakes()
        {
            return View("AddCakes");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCakes(Cake cake)
        {
            _cakeService.Add(cake);
            return RedirectToAction("Index");
        }
    }
}
