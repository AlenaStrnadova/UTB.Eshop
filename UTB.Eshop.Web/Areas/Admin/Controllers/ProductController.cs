using Microsoft.AspNetCore.Mvc;

namespace UTB.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
