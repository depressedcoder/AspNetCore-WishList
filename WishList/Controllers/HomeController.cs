using Microsoft.AspNetCore.Mvc;

public class HomeCortroller : Controller{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Error()
    {
        return View();
    }
}