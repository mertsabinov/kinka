namespace kinka.Data;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
   
    public string Password { get; set; }
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