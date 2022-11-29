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
    
    public IActionResult UpdateProfileImage(string imageUrl)
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }
        UserDbManager.UserProfileImgUpdate(userID, imageUrl);
        return View();
    }

    public IActionResult UpdatePassword(string oldPassword, string newPassword)
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }

        User user = UserDbManager.GetUserByUserId(userID);
        if (user.Password.Equals(oldPassword))
        {
            UserDbManager.UserProfilePasswordImage(userID, newPassword);
            return Redirect("/profile");
        }
        return View();
    }

    public IActionResult UpdateEmail(string oldEmail ,string newEmail)
    {
        string userID = HttpContext.Session.GetString("UserId");
        if (userID == null)
        {
            return Redirect("/");
        }

        User user = UserDbManager.GetUserByUserId(userID);
        if (user.Email.Equals(oldEmail))
        {
            UserDbManager.UserProfileEmail(userID, newEmail);
            return Redirect("/profile");
        }
        return View();
    }
}