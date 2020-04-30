using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Updated_ALvl_HW2_Lib;

namespace Updated_ALvl_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the \n 1.The start number \n 2.The final one");

            var inputStartNumber = CheckConvertToDouble(Console.ReadLine());

            var inputLastNumber = CheckConvertToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the prime numbers \n 1. First prime number \n 2. Second prime number ");

            var firstPrime = PrimeNumberValidation(Console.ReadLine());

            var secondPrime = PrimeNumberValidation(Console.ReadLine());

            Console.WriteLine("Please enter the definition for special numbers \n  1. For the first value \n 2. For the second value ");

            string firstDefinition = Console.ReadLine();
            string secondDefinition = Console.ReadLine();

            Console.WriteLine("______________________________________________________");

            var fizzBuzz = new FizzBuzzModel()
            {
                startNumber = inputStartNumber,
                lastNumber = inputLastNumber,
                firstPrime = firstPrime,
                secondPrime = secondPrime,
                firstDefinition = firstDefinition,
                secondDefinition = secondDefinition
            };

            FizzBuzzLib.FizzBuzzLogic(fizzBuzz);

            Console.ReadKey();
        }

        public static double CheckConvertToDouble(string input)
        {

            while (FizzBuzzLib.NumberValidation(input).Equals(false))
            {
                var message = FizzBuzzLib.Message;
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            double value = FizzBuzzLib.ParseToDouble(input);

            return value;
        }

        public static double PrimeNumberValidation(string input)
        {
            while (FizzBuzzLib.IsPrimeNumberChecker(input).Equals(false))
            {
                var message = FizzBuzzLib.Message;
                Console.WriteLine(message);
                input = Console.ReadLine();
            }

            double value = FizzBuzzLib.ParseToDouble(input);

            return value;
        }
    }
}
