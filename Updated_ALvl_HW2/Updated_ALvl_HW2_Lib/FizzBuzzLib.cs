using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updated_ALvl_HW2_Lib
{
    public class FizzBuzzLib
    {
        public static double Value { get; set; }
        public static string Message { get; set; }

        public static bool NumberValidation(string input)
        {
            bool result;

            if (NotNullValidation(input).Equals(false)|| CheckIsNumber(input).Equals(false)|| IsPositiveNumber(Value).Equals(false))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        public static bool NotNullValidation(string input)
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(input) == true)
            {
                Message = "Input cannot be null or white space";
                return false;
            }
            return result;
        }

        public static bool CheckIsNumber(string input)
        {
            bool result = true;
            double value;

            if (!double.TryParse(input, out value))
            {
                Message = "This is not a number!";
                result = false;
            }
            Value = value;
            return result;
        }

        public static bool IsPrimeNumberChecker(string input)
        {
            bool result = false;

            if (NumberValidation(input).Equals(true))
            {
                var inputNumber = Value;

                if (inputNumber < 2)
                {
                    result = false;

                    Message = "Prime number cannot be less than 2!";     
                }
                for (double i = 2; i < inputNumber; i++)
                    if (inputNumber % i == 0)
                    {

                        result = false;

                        Message = "Please input prime number!";
                    }
                result = true;
            }
            return result;
        }

        public static bool IsPositiveNumber(double input)
        {
            bool result = true;
            if (input <= 0)
            {
                Message = "Value cannot be negative. Please input number more than 0";

                return false;
            }
            return result;
        }

        public static double ParseToDouble(string input)
        {
            double.TryParse(input, out double value);

            return value;
        }

        public static void StartLastNumberChecker(ref double startNumber, ref double lastNumber)
        {
            if (startNumber >= lastNumber)
            {
                var keepNumber = lastNumber;

                lastNumber = startNumber;

                startNumber = keepNumber;
            }
        }

        public static void FizzBuzzLogic(FizzBuzzModel fizzBuzz)
        {

            double startNumber = fizzBuzz.startNumber;
            double lastNumber = fizzBuzz.lastNumber;
            double firstPrime = fizzBuzz.firstPrime;
            double secondPrime = fizzBuzz.secondPrime;
            string firstDefinition = fizzBuzz.firstDefinition;
            string secondDefinition = fizzBuzz.secondDefinition;

            StartLastNumberChecker(ref startNumber, ref lastNumber);

            for (; startNumber <= lastNumber; startNumber++)
            {
                string definition = "";

                if (startNumber % firstPrime == 0 || startNumber % secondPrime == 0 || (startNumber % (firstPrime * secondPrime) == 0))
                {
                    if (startNumber % (firstPrime * secondPrime) == 0)
                    {
                        definition = firstDefinition + secondDefinition;
                    }
                    else if (startNumber % firstPrime == 0)
                    {
                        definition = firstDefinition;
                    }

                    else if (startNumber % secondPrime == 0)
                    {
                        definition = secondDefinition;
                    }
                    Console.WriteLine(definition);
                }
                else
                {
                    Console.WriteLine(startNumber.ToString());
                }
            }
        }
    }
}
