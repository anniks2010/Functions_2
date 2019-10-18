using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space__counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSentence;
            Console.WriteLine("Enter your sentence:");
            userSentence = Console.ReadLine();

            CountSpace(userSentence);



            Console.ReadLine();
        }
        public static void CountSpace(string sentence)
        {
            int counter = 0;
            foreach (char symbol in sentence)
            {
                if (symbol == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} spaces in your sentence");
        }
    }
}
