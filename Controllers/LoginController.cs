
using kinka.Data;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        string user = HttpContext.Session.GetString("UserId");
        if (user is not null)
        {
            return Redirect("/");
        }
        return View();
    }
    
    [HttpPost]
    public IActionResult Control(User user)
    {
        Dictionary<string, string> loginData = UserDbManager.UserLogin(user);
        string error = loginData.GetValueOrDefault("Error", null);
        string userId = loginData.GetValueOrDefault("UserId", null);
        if (error is not null)
        {
            return RedirectToAction("Index");
        }
        HttpContext.Session.SetString("UserId",userId);
        return Redirect("/");
    }
}

