using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_2Library;

namespace FizzBuzzH
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the \n 1.The start number \n 2.The final one");

            string inputStartNumber = (Console.ReadLine());
            string inputLastNumber = (Console.ReadLine());

            var currentNumber = Hometask_2Library.HW2Library.InValidation(inputStartNumber);
            var lastNumber = Hometask_2Library.HW2Library.InValidation(inputLastNumber);

            Console.WriteLine("Please enter the prime numbers \n 1. First prime number \n 2. Second prime number ");
            int firstPrime = Hometask_2Library.HW2Library.InPrimeNumberChecker(Convert.ToInt32((Console.ReadLine())));
            int secondPrime = Hometask_2Library.HW2Library.InPrimeNumberChecker(Convert.ToInt32((Console.ReadLine())));

            currentNumber = Hometask_2Library.HW2Library.FizzBuzzH(currentNumber, lastNumber, firstPrime, secondPrime);

            Console.ReadKey();
        }
    }
}
