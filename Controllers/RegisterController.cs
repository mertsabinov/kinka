using kinka.Data;
using Microsoft.AspNetCore.Mvc;

public class RegisterController: Controller {
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Control(User user)
    {
        string error = UserDbManager.UserRegister(user);
        if (error is not null)
        {
            return RedirectToAction("Index");
        }
        return Redirect("/");
    }
}