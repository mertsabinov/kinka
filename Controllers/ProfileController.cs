using Microsoft.AspNetCore.Mvc;
namespace kinka.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }
        return View();
    }
    
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return Redirect("/");
    }
}