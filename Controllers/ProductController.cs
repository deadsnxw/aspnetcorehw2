using Microsoft.AspNetCore.Mvc;

namespace shop_app.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
