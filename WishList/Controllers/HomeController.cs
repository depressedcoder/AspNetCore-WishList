using Microsoft.AspNetCore.Mvc;

namespace WishList
{
    public class HomeCortroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}