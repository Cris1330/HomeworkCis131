using System;

namespace HomeworkCis131
{
    class Program
    {
        static void Main(string[] args)
        {
            Users myUser = new Users();
            myUser.UserId = 1;
            myUser.UserName = "Cristal Zavala";

            Console.WriteLine(myUser.UserId);
            Console.WriteLine(myUser.UserName);
        }
        
        

    }
}
public class Users
{
    public int UserId { get; set; }
 public string UserName { get; set; }
}
public class Roles
{
    public int RoledId { get; set; }
    public string RoleName { get; set; }
}
public class Images
{
    public int ImagesId{ get; set; }
    public string ImagesName { get; set; }
}
}
public class Post
{
    public int PostId { get; set; }
    public string PostName { get; set; }
}
}
public class Comments
{
    public int CommentsId { get; set; }
    public string CommentsName { get; set; }
}
}