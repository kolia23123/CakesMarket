using Microsoft.AspNetCore.Mvc;

namespace CakesMarket.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
