namespace kinka.Models;
public static class UserError
{
    public static string UsernameIsAlreadyExist()
    { 
       return "username is already exist";
    }
    
    public static string UsernameOrPasswordWrong()
    {
        return "username or password wrong";
    }
}