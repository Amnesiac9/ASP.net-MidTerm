using Microsoft.AspNetCore.Mvc;

namespace john_moreau_MidTerm.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
