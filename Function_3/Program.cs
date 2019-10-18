using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userBirth;
            Console.WriteLine("Enter your birth year");
            userBirth = int.Parse(Console.ReadLine());
            Age(userBirth);

            Console.ReadLine();
        }
        public static void Age (int birthYear)
        {
            int Age = 2019 - birthYear;
            Console.WriteLine($"Your age is: {Age} years");
        }
    }
}
