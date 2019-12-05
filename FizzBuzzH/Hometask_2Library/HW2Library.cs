using System;
using System.Collections.Generic;

namespace Hometask_2Library
{
    public class HW2Library
    {
        public static double InValidation(string input)
        {
            double result;
            while (!double.TryParse(input, out result))
            {
                Console.WriteLine("This is not a number!");
                input = Console.ReadLine();
            }

            return result;
        }

        public static double FizzBuzzH(double currentNumber, double lastNumber, double firstPrime, double secondPrime)
        {

            Console.WriteLine("Please enter the definition for special numbers \n  1. For the first value \n 2. For the second value ");
            string firstDefinition = Console.ReadLine();
            string secondDefinition = Console.ReadLine();

            for (; currentNumber <= lastNumber; currentNumber++)
            {
                if (currentNumber % (firstPrime * secondPrime) == 0)
                {
                    Console.WriteLine(firstDefinition + secondDefinition);

                    Console.WriteLine(secondDefinition);
                }
                else if (currentNumber % firstPrime == 0)
                {
                    Console.WriteLine(firstDefinition);
                }
                else
                {
                    Console.WriteLine(currentNumber);
                }
            }
            return currentNumber;
        }

        public static int InPrimeNumberChecker(int inputNumber)
        {
            while (inputNumber < 2)
            {
                Console.WriteLine("Prime number cannot be less than 2!");
                inputNumber = int.Parse(Console.ReadLine());
            }
            for (int i = 2; i < inputNumber; i++)
                if (inputNumber % i == 0)
                {
                    Console.WriteLine("Please input prime number!");
                    inputNumber = int.Parse(Console.ReadLine());
                }

            return inputNumber;
        }
    }
    public class ResultKeeper
    {
        public string removalItem { get; set; }

        public static List<TrainingProcess> Results = new List<TrainingProcess>();
        public static void Add(TrainingProcess results)
        {
            Results.Add(results);
        }
        public static void Remove(TrainingProcess results)
        {
            Results.Remove(results);
        }
    }
    public class TrainingProcess
    {
        public double firstDay { get; set; }
        public double progress { get; set; }
        public double finalDistance { get; set; }
        public double totalDays { get; set; }
        public double totalDistance { get; set; }
        public string sportsmanName { get; set; }

        public TrainingProcess(double firstDay, double progress, double finalDistance, string sportsmanName)
        {
            this.totalDays = 1;
            this.totalDistance = 0;
            this.progress = progress;
            this.firstDay = firstDay; ;
            this.finalDistance = finalDistance;
            this.sportsmanName = sportsmanName;
            for (int i = 1; totalDistance <= finalDistance; i += 2)
            {
                if (i == 1) totalDays = i;
                else totalDays = i + 2;
                firstDay *= (1 + (progress / 100));
                totalDistance += firstDay;
            }
        }
        public override string ToString()
        {
            return $"Sportsman {sportsmanName} overcome {finalDistance} km distance in {totalDays} days!";
        }
    }
}