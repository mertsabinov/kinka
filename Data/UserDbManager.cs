using kinka.Data;
using kinka.Models;

public static class UserDbManager
{
   private static List<User> _db = new List<User>();

   public static string UserRegister (User user)
   { 
      User u = _db.Find(u => u.UserName.Equals(user.UserName));
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