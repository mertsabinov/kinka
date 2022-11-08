
using kinka.Data;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Control(User user)
    {
        string error = UserDbManager.UserLogin(user);
        if (error is not null)
        {
            return RedirectToAction("Index");
        }
        return Redirect("/");
    }
}