using Microsoft.AspNetCore.Mvc;

namespace kinka.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}