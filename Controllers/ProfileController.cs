using kinka.Data;
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

        User user = UserDbManager.GetUserByUserId(userID);
        return View(user);
    }
    
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return Redirect("/");
    }

    public IActionResult UpdateProfileImage()
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }
        return View();
    }

    public IActionResult UpdatePassword()
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }
        return View();
    }

    public IActionResult UpdateEmail()
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }
        return View();
    }
}