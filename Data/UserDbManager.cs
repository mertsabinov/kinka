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
         user.Id = Guid.NewGuid().ToString();
         _db.Add(user);
      }
      else
      {
         return UserError.UsernameIsAlreadyExist();
      }
      return null;
   }

   public static Dictionary<string,string> UserLogin(User user)
   {
      Dictionary<string, string> tmpData = new Dictionary<string, string>();
      User u = _db.Find(u => u.UserName.Equals(user.UserName) && u.Password.Equals(user.Password));
      if (u is null)
      {
         tmpData["Error"] = UserError.UsernameOrPasswordWrong();
         return tmpData;
      }
      tmpData["UserId"] = u.Id;
      return tmpData;
   }

   public static User GetUserByUserId(string userID)
   {
      User user = _db.Find(u => u.Id.Equals(userID));
      return user;
   }

   public static void UserProfileImgUpdate(string userID, string newImg)
   {
      foreach (User user in _db)
      {
         if (user.Id.Equals(userID))
         {
            user.UserImg = newImg;
         } 
      }
   }

   public static void UserProfilePasswordImage(string userID, string newPassword)
   {
      foreach (User user in _db)
      {
         if (user.Id.Equals(userID))
         {
            user.Password = newPassword;
         }
      }
   }

   public static void UserProfileEmail(string userID, string newEmail)
   {
      foreach (User user in _db)
      {
         if (user.Id.Equals(userID))
         {
            user.Email = newEmail;
         }
      }
   }
}