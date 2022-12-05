using System.ComponentModel.DataAnnotations;

namespace kinka.Data;

public class User
{
    [Required]
    public string Id { get; set; }
    [Display(Name = "your name")]
    [Required]
    public string Name { get; set; }
    [Display(Name = "your surname")]
    [Required]
    public string Surname { get; set; }
    [Display(Name = "your Email")]
    [Required]
    public string Email { get; set; }
    [Display(Name = "your username")]
    [Required]
    public string UserName { get; set; }
    [Display(Name = "your password")]
    [Required]
    public string Password { get; set; }
   [Display(Name = "your user profile image url")]
   [Required] 
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