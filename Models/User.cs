using System.ComponentModel.DataAnnotations;

namespace kinka.Data;

public class User
{
    public string Id { get; set; }
    
    [Display(Name = "your name")]
    public string Name { get; set; }
    [Display(Name = "your surname")]
    public string Surname { get; set; }
    [Display(Name = "your Email")]
    public string Email { get; set; }
    [Display(Name = "your username")]
    public string UserName { get; set; }
    [Display(Name = "your password")]
    public string Password { get; set; }
   [Display(Name = "your user profile image url")]
    public string UserImg { get; set; }
    public User(){}
    public User(string name, string surname,string email, string userName, string password)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Surname = surname;
        Email = email;
        UserName = userName;
        Password = password;
    }

}