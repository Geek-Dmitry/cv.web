using Microsoft.AspNetCore.Mvc;

namespace cv.web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}