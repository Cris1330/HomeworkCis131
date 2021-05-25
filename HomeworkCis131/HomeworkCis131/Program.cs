using System;
using HomeworkCis131.Models;

namespace HomeworkCis131
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersDTO myUser = new UsersDTO();
            myUser.UserId = 1;
            myUser.UserName = "Cristal Zavala";

            Console.WriteLine(myUser.UserId);
            Console.WriteLine(myUser.UserName);
        }
        
        

    }
}



