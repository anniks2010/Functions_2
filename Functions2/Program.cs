using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you coming or leaving?");
            string userAnswer = Console.ReadLine();

            Console.WriteLine($"What is your sex?");
            string userSex = Console.ReadLine();

            Console.WriteLine("What is your birth of year?");
            int birthYear = int.Parse(Console.ReadLine());

            if (userAnswer.ToLower() == "coming")
            {
             Coming(userSex,birthYear);
            }
            else if (userAnswer.ToLower() == "leaving")
            {
             Leaving(userSex,birthYear);
            }
            else
            {
                Console.WriteLine("Do not be rude!");
            }
            
            Console.ReadLine();  
        }
        public static void Coming (string gender, int birthYear)
        {
            int Age = 2019 - birthYear;
            if (gender == "male")
            {
                Console.WriteLine($" Hello, Sir! your age is {Age}");
            }
            else
            {
                Console.WriteLine($" Hello, Madam! your age is {Age}");
            }

            
            
            
        }
         public static void Leaving (string gender, int birthYear)
        {
            int Age = 2019 - birthYear;
            if (gender== "male")
            {
                Console.WriteLine($" Goodby Sir! your age is {Age}");
            }
            else
            {
                Console.WriteLine($" Goodby Madam! your age is {Age}");
            }
            
            
        }
       
        
    }
}
