﻿using System;
using HomeworkCis131.Models;

namespace HomeworkCis131
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myFirstDate = new DateTime(2003, 7, 15);
            DateTime mySecondDate = new DateTime(2005, 2, 8);

            if(myFirstDate>mySecondDate)
            {
                Console.WriteLine("First date is greater than the second date");
            }
            else
            {
                Console.WriteLine("First date is lower than the second date");
            }
        }
        

    }
}



