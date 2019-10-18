using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNumber;
            Console.WriteLine("Enter your ID number");
            idNumber = Console.ReadLine();
            bool idValid;
            idValid = CheckIDLength(idNumber);

            if (idValid) ///sama mis 'idValid == true'
            {
                
                GenderCalculator(idNumber); // ok ei ole vaja kirjutada.
                GetYear(idNumber);
            }
            else
            {
                Console.WriteLine("Not ok!");
            }

            
            Console.ReadLine();
        }
        public static void GenderCalculator(string idCode)
        {


            int firstNumber = int.Parse(idCode[0].ToString()); ///kõige pealt suurendame char-i stringiks ning siis selle stringi int-iks 

            if (firstNumber== 4 || firstNumber== 6 || firstNumber == 2)
            {
                Console.WriteLine("Hello, madam!");
            }
            else
            {
                Console.WriteLine("Hello, sir!");
            }


            
        }
        public static bool CheckIDLength(string idCode)
        {
            bool isValid;
            if (idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        public static void GetYear (string idCode)
        {
            string year = idCode.Substring(1, 2);

            string fullYear = $"19{year}";
            Console.WriteLine($"Your birth year is {fullYear} ");

            
        }
    }
}
