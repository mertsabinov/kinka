using kinka.Data;
using kinka.Models;

public static class DbManager
{
   private static List<User> _db = new List<User>();

   public static string RegisterUser(User user)
   { 
      User u = _db.Find(u => u.UserName == user.UserName);
      if (u is null)
      {
         _db.Add(user);
      }
      else
      {
         return UserError.UsernameIsAlreadyExist();
      }
      return null;
   }
}