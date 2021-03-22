using System;
using System.Collections.Generic;

namespace exercise_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Hello! please enter a number");
            try
            {
                int usernum = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            while (true)
            {
                Console.WriteLine("enter new num");
                string newnum = Console.ReadLine();
                if ()
                {
                    
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}