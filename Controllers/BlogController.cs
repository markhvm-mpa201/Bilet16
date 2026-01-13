using Microsoft.AspNetCore.Mvc;

namespace Bilet16.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
