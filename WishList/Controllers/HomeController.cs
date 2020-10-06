using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeCortroller : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}