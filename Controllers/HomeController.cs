using System.Diagnostics;
using kinka.Data;
using Microsoft.AspNetCore.Mvc;
using kinka.Models;

namespace kinka.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var data = ContentDbManager.ContentGetAll();
        if (data is null)
        {
            data = new List<Content>();
        }
        return View(data);
    }

    [HttpPost]
    public IActionResult CreatePost(Content content)
    {
        string userID = null;
        try
        {
            userID = HttpContext.Session.GetString("UserId");
        }
        catch (Exception e)
        {
            return Redirect("/login");
        }

        User user = UserDbManager.GetUserByUserId(userID);
        content.OwnerUserName = user.UserName;
        ContentDbManager.ContentSave(content);
        return Redirect("/");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}